

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
new System.Collections.Generic.List<System.Int64>(3)
{
6154106713609612336L,

3442834111000828812L,

5878412779332506490L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4997499207329045967L,

109609423998536059L,

4691017474754913349L,

2993947762093273938L,

},
},
            new Int64bigintListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7170106377096044520L,

263530288901512373L,

5276497923360185827L,

220782086196318509L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3189355881979205640L,

875501619498338654L,

8613304297400966398L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
813372293391977977L,

6361615878663657448L,

3625167193039982694L,

166654034700593522L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6205231915890542725L,

8629754067164853253L,

1799007942548537297L,

6871523685763001144L,

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
2715313539338354265L,

6839041426821254654L,

8003032649844116470L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5646776780173390476L,

2590357534651856965L,

7102713362225059771L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8366981699169020346L,

7782632299253646629L,

5451650966868917795L,

5473317331484789737L,

},
},
            new Int64bigintListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4817589888934448608L,

3462480434346664967L,

2900051933290189228L,

1076957456070174070L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7110083775576064546L,

3743142249455862974L,

2597222068228004978L,

1590792661237593628L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8507935766142470543L,

4493514585866061137L,

7754979876222281352L,

6479772805622868274L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6430708632282293092L,

5698860017505101089L,

4215912042675727899L,

2002283103164199564L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
578449041523370714L,

2044659085972350462L,

5557856839117447442L,

8267079640456718336L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6955401558370178964L,

6061364551343644264L,

3597877491996820013L,

},
},
            new Int64bigintListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1385160530177613936L,

6427783481656439622L,

8207251950563535715L,

2948720790372711194L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3401256692598952121L,

3919550296205898887L,

7493314171649367774L,

4371038785995279754L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6320364088780644711L,

3019010464943058227L,

5258212557894777262L,

8036411268017432190L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3806499560039068507L,

9125112020199204662L,

1779097555641184330L,

},
},
            new Int64bigintListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7396118731743614093L,

2213832797885349647L,

6523036652993630014L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
552965672277830713L,

5337257055392717135L,

2527282986415799439L,

},
},
            new Int64bigintListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4298971294363364259L,

7234737252785449757L,

914289989715907880L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6689119575938477972L,

3556861464851351382L,

5955943766163113202L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6002504343019604535L,

7085810433235282201L,

4949356314279214278L,

6011432122896302665L,

},
},
            new Int64bigintListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4605631982994977105L,

5315595823996284766L,

9165647002846939582L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
306092428718292382L,

8608267590425134648L,

6710768087796106694L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7006716797337594901L,

501209818748886933L,

373608027331369267L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8039518437873258326L,

2366239275764639247L,

3614310758889193110L,

5549897145743362479L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1382821834152724417L,

2607215362966617383L,

9041768864156036600L,

1662990697942043557L,

},
},
            new Int64bigintListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5862830400536371539L,

4714867155560786073L,

8994445877624105664L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4350793600634305331L,

6006807430243033411L,

5942508753691683344L,

5924708840531815786L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9168323177726920633L,

5741434358464353029L,

1251973395044474798L,

8595081037954466563L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5860621958057743141L,

1022951382971411881L,

1915210000377467836L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8498560348020206552L,

3253821032443745908L,

3872640790074294730L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1306662638136569482L,

1055896412269301540L,

523773544854465846L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7762900271341046134L,

2523372038483620045L,

7021152709325222638L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3679436841891479260L,

7046751499390153793L,

6210014731978534689L,

301843269298073497L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3821247810896228797L,

5596979753159473247L,

3307794211351583244L,

2038647295625146972L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1683019241401478083L,

2226999660673384642L,

5342967771104150077L,

8792472835379419045L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5868732532877384796L,

8069998888710403268L,

638891105979672769L,

5014776906107757288L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7566088402923167901L,

9214729524925855133L,

4908731722350510009L,

630645788656876309L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1018607235045959842L,

9083752880496034881L,

6440034276590716368L,

5090035673541897589L,

},
},
            new Int64bigintListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7391866899037770844L,

6990605120756280208L,

2488591654532694900L,

3469225192652663741L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8728459982067082149L,

36840141791269956L,

129700735443590581L,

1490400229489916867L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2201978448323257891L,

2616632940204750538L,

6974237630844840162L,

3980820957363050617L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8603359251796402056L,

6071313749542125298L,

6502047154930292458L,

593856152401400006L,

},
},
            new Int64bigintListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6936548917197994754L,

8657115413322459530L,

5019364550551218692L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7145471693283041014L,

5183912250200816752L,

8421502317856319193L,

},
},
            new Int64bigintListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8700964147044662584L,

6084583921624199867L,

2470291984763645645L,

9208770564952968062L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6978903002071048463L,

7507595841161107482L,

2771671092354914742L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
680521543567187181L,

5716458971731956269L,

7583387659848485560L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6497228708327649630L,

3999861384441759642L,

733544059277545515L,

},
},
            new Int64bigintListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8588737059880548977L,

4402926534533523142L,

2391036779223042191L,

3897788378615135371L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5088282576431168615L,

7398499937581967541L,

491653184914313916L,

1337403392453573022L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5733877811318876338L,

2065295261596434136L,

6170369751101493192L,

7645721184293581821L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7170891825280652441L,

683769600542811501L,

7253193296613348772L,

6930798293565909237L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1789648867744159225L,

536591615755180418L,

6876447933901263728L,

8457937825737012838L,

},
},
            new Int64bigintListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1686374870467655349L,

1289872535559459108L,

3642150670111394321L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2401460884674389821L,

5320978786064164524L,

8013534354093039142L,

2303656354107226584L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
405804296691361876L,

2398999498645610727L,

9092087959846587511L,

3375171564300553918L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1136414688685851275L,

8818081654357791818L,

3600946248010176033L,

},
},
            new Int64bigintListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5019456247969872738L,

4443302376764696631L,

4809175717038047872L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7641797753202580088L,

3886310677819339525L,

4804927470015132675L,

5622605391031807088L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1365574927965282238L,

4372308715077852724L,

40508836232475594L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5894563920949723600L,

2806150725277043659L,

5638430923995609127L,

7351890851950499960L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
231025151668945700L,

7106635444576652117L,

794312335454019325L,

6684463100769972502L,

},
},
            new Int64bigintListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5284343999411840728L,

87066143893576827L,

549230381215898716L,

1611770933406529813L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1358567521856885921L,

5381072414528754245L,

829566956656244012L,

5250103560345019595L,

},
},
            new Int64bigintListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2559872495920619497L,

4778616950787101724L,

3922977660116450519L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6503616659175564011L,

7859801039660890913L,

5177840851773557457L,

4437772604421123095L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7886510716954387204L,

1772697856674213280L,

1060248664770413615L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4701788579402443783L,

8561722121947952763L,

4917952324386058306L,

},
},
            new Int64bigintListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8478658066891076143L,

2916182177025104899L,

5884839719164341865L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
33059698122161794L,

5605426175381002741L,

4602464499748498517L,

},
},
            new Int64bigintListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
225824529747503707L,

7956401124414433282L,

5440475346058928657L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1089527146040853764L,

7014092975478186513L,

5978904662218626973L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9077408479892763708L,

5000622375019115010L,

45326427274047323L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2608332972200977383L,

8836033507689793383L,

6946567924399224736L,

7651769686116780702L,

},
    ModelInner = new Int64bigintListD12MI
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6785795736688272968L,

297809880400761779L,

1325152701653813245L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8970850724833398754L,

5513397351454089352L,

3708114716326190331L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
870320793326951470L,

5624306240582635621L,

6111671493589993216L,

2644150714378384939L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3100175889213436604L,

4135697914594005281L,

2248798062839445766L,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintlistd12mi(
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
INSERT INTO public.int64bigintlistd12mi(
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
            queryMapTypes: [typeof(Int64bigintListD12MI)],
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
    int64bigintlistd12mi_id
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
                methodParametrName: "int64bigintlistd12mi_id", 
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
    int64bigintlistd12mi_id
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
    int64bigintlistd12mi_id,
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
    int64bigintlistd12mi_id
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
    int64bigintlistd12mi_id,
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
                methodParametrName: "int64bigintlistd12mi_id", 
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
LEFT JOIN public.int64bigintlistd12mi mi ON mi.id = m.int64bigintlistd12mi_id
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
LEFT JOIN public.int64bigintlistd12mi mi ON mi.id = m.int64bigintlistd12mi_id
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
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
                parametr1.Value = 110;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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

                    if(resultIndex == 2)
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
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
LEFT JOIN public.int64bigintlistd12mi mi ON mi.id = m.int64bigintlistd12mi_id
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[6], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[7], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[8], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[9], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[10], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[11], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[12], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[22],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[23],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[24],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[25],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[26],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[27],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 63, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[31],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 5, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
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
                 ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 112, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
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
                 ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 88, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 120, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[31],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 111, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 55, query1, 112, query2))
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[34], false);
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
                 ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 22, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
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
LEFT JOIN public.int64bigintlistd12mi mi ON mi.id = m.int64bigintlistd12mi_id
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
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 108, 108))
                {
                    if(++resultIndex == 1)
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
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatch(connection, 51, 45))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[12], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[22],_testData[34], false);
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
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 10);
                var models = await ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models =  ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                Int64bigintListD1E2M.AssertModel(models[0],_testData[3], false);
                Int64bigintListD1E2M.AssertModel(models[1],_testData[4], false);
                Int64bigintListD1E2M.AssertModel(models[2],_testData[5], false);
                Int64bigintListD1E2M.AssertModel(models[3],_testData[6], false);
                Int64bigintListD1E2M.AssertModel(models[4],_testData[7], false);
                Int64bigintListD1E2M.AssertModel(models[5],_testData[8], false);
                Int64bigintListD1E2M.AssertModel(models[6],_testData[9], false);
                Int64bigintListD1E2M.AssertModel(models[7],_testData[10], false);
                Int64bigintListD1E2M.AssertModel(models[8],_testData[11], false);
                Int64bigintListD1E2M.AssertModel(models[9],_testData[12], false);
                Int64bigintListD1E2M.AssertModel(models[10],_testData[13], false);
                Int64bigintListD1E2M.AssertModel(models[11],_testData[14], false);
                Int64bigintListD1E2M.AssertModel(models[12],_testData[15], false);
                Int64bigintListD1E2M.AssertModel(models[13],_testData[16], false);
                Int64bigintListD1E2M.AssertModel(models[14],_testData[17], false);
                Int64bigintListD1E2M.AssertModel(models[15],_testData[18], false);
                Int64bigintListD1E2M.AssertModel(models[16],_testData[19], false);
                Int64bigintListD1E2M.AssertModel(models[17],_testData[20], false);
                Int64bigintListD1E2M.AssertModel(models[18],_testData[21], false);
                Int64bigintListD1E2M.AssertModel(models[19],_testData[22], false);
                Int64bigintListD1E2M.AssertModel(models[20],_testData[23], false);
                Int64bigintListD1E2M.AssertModel(models[21],_testData[24], false);
                Int64bigintListD1E2M.AssertModel(models[22],_testData[25], false);
                Int64bigintListD1E2M.AssertModel(models[23],_testData[26], false);
                Int64bigintListD1E2M.AssertModel(models[24],_testData[27], false);
                Int64bigintListD1E2M.AssertModel(models[25],_testData[28], false);
                Int64bigintListD1E2M.AssertModel(models[26],_testData[29], false);
                Int64bigintListD1E2M.AssertModel(models[27],_testData[30], false);
                Int64bigintListD1E2M.AssertModel(models[28],_testData[31], false);
                Int64bigintListD1E2M.AssertModel(models[29],_testData[32], false);
                Int64bigintListD1E2M.AssertModel(models[30],_testData[33], false);
                Int64bigintListD1E2M.AssertModel(models[31],_testData[34], false);
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
FROM public.binary_int64bigintlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD12MIWA)],
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
            queryMapType: typeof(Int64bigintListD12MIWA),
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
                var importCollection = new List<Int64bigintListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintlistd12mi
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
                    Int64bigintListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintlistd12mi
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
                    Int64bigintListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD12MIWA)],
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
            queryMapType: typeof(Int64bigintListD12MIWA),
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
                var importCollection = new List<Int64bigintListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintlistd12mi
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
                    Int64bigintListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintlistd12mi
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
                    Int64bigintListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD12MI)],
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
COPY public.binary_int64bigintlistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintListD12MI),
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
                var importCollection = new List<Int64bigintListD12MI>(2);
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
                    Int64bigintListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD12MI>(2);
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
                    Int64bigintListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintListD12MIWA)],
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
COPY public.binary_int64bigintlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintListD12MIWA),
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
                var importCollection = new List<Int64bigintListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD12MIWA
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
                    Int64bigintListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintListD12MIWA
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
                    Int64bigintListD12MIWA.AssertModel(actual, expect, false);
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
int64bigintlistd12mi_id,
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
LEFT JOIN public.binary_int64bigintlistd12mi mi ON mi.id = m.int64bigintlistd12mi_id
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
    int64bigintlistd12mi_id,
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
            queryMapTypes: [typeof(Int64bigintListD12MIWA), typeof(Int64bigintListD12MIWA)],
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
                var models1 = new List<Int64bigintListD12MIWA>();
                var models2 = new List<Int64bigintListD12MIWA>();
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
    FROM public.binary_int64bigintlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD12MIWA>();
                var models2 = new List<Int64bigintListD12MIWA>();
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
    FROM public.binary_int64bigintlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD12MIWA)],
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
COPY public.binary_int64bigintlistd12mi
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
                    Int64bigintListD12MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_int64bigintlistd12mi
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
                    Int64bigintListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD12MIWA), typeof(Int64bigintListD12MIWA)],
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
                var models1 = new List<Int64bigintListD12MIWA>();
                var models2 = new List<Int64bigintListD12MIWA>();
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
    FROM public.binary_int64bigintlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD12MIWA>();
                var models2 = new List<Int64bigintListD12MIWA>();
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
    FROM public.binary_int64bigintlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD12MIWA)],
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
COPY public.binary_int64bigintlistd12mi
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
                    Int64bigintListD12MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_int64bigintlistd12mi
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
                    Int64bigintListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD12MI), typeof(Int64bigintListD12MI)],
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
                var models1 = new List<Int64bigintListD12MI>();
                var models2 = new List<Int64bigintListD12MI>();
                await ((IInt64ListbigintListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD12MI>();
                var models2 = new List<Int64bigintListD12MI>();
                ((IInt64ListbigintListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintlistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD12MI)],
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
                    Int64bigintListD12MI.AssertModel(model, expectedModel, false);
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
                    Int64bigintListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD12MIWA), typeof(Int64bigintListD12MIWA)],
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
                var models1 = new List<Int64bigintListD12MIWA>();
                var models2 = new List<Int64bigintListD12MIWA>();
                await ((IInt64ListbigintListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintListD12MIWA>();
                var models2 = new List<Int64bigintListD12MIWA>();
                ((IInt64ListbigintListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintlistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintListD12MIWA)],
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
                    Int64bigintListD12MIWA.AssertModel(model, expectedModel, false);
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
                    Int64bigintListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

