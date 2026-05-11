

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
new System.Collections.Generic.List<System.Int64>(3)
{
3673303549273851493L,

2427818906522818252L,

816650712013026891L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7387693969597936985L,

1839259334384375511L,

5495961140999225771L,

1794851990619074451L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3797256049121716527L,

7061799073310711921L,

3921173957949894480L,

8083729606072687180L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
825382634890122179L,

7054726301604096489L,

6590434083454541482L,

942698253008966381L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1028838865294494843L,

4288636767128521032L,

773321547775392703L,

},
},
            new Int64bigintListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1875915069101938176L,

4282311922162567972L,

2053933013325437423L,

9105200520270450288L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7046106974831974466L,

2653805234796666300L,

8487924600522491369L,

6277755341281523533L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7270100607938460537L,

1097407304484333731L,

7891329443735393711L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4611611506716832630L,

2936205757827927687L,

8689438508455408132L,

7011280104218941495L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5285646149248153910L,

2003624199657808010L,

1522591996635428129L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
364345456179143318L,

2391593855464175146L,

6740779634854430135L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8397889638798719768L,

2466077193073020975L,

3488164313003397434L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8151920877702130360L,

7290888421246123202L,

5411884841822881345L,

3303543347599191611L,

},
},
            new Int64bigintListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1002207032690875643L,

8654221064720052904L,

1233501732956283300L,

6158727216377864567L,

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
7435358112281309993L,

2270128643879878379L,

6126731449086753713L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6079585083041627471L,

2695126520968885403L,

7873114839607420973L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6030169251527921746L,

4971400255614937756L,

1978383976703682107L,

5949624454408955777L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7953798930069054454L,

4283598333192147489L,

804074525197107810L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5948818728248897224L,

2271710645539551757L,

1233323480188943222L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
691753160051283980L,

4883006532257209725L,

8072003245219979495L,

3382502520131242633L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8675601737254746983L,

1105009975676288017L,

4339272801668276052L,

4518669337017028815L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1286112416914828303L,

5823654857315271389L,

8045667556046036931L,

},
},
            new Int64bigintListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8149457920132533412L,

8984703835150466979L,

993756025598096023L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
676611066944274852L,

543536144518232816L,

1947957324746815102L,

5700198345118163403L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4396976881355776004L,

5560935801668880347L,

7364061436850275581L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2263862150980244764L,

9067533978893108557L,

5280553911168022123L,

3917530177832522837L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6116731314901328661L,

4156128871599187386L,

49290848118485915L,

3016156875555445853L,

},
},
            new Int64bigintListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8166511518323287480L,

1147809065883110577L,

3911696242974851961L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5292855945819734316L,

7232554972407723631L,

2099599047942457573L,

5367600549089915505L,

},
},
            new Int64bigintListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1375084546874157497L,

1395317893890503620L,

5207669692266926140L,

5998392183675465492L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2487703894735604104L,

8970195183206164458L,

4920074702044548658L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6238279761581193787L,

5190709001721240104L,

8084178110365822219L,

3208302490154645934L,

},
},
            new Int64bigintListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2460545288320944559L,

1905026398122915670L,

4177553851175249198L,

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
7322044847547423552L,

166693766804846114L,

144088085155425427L,

4640526897165385477L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8257212339014102316L,

1137880285084206985L,

7347209458007390767L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2216436807355412395L,

8830004200196095575L,

4370454100777659830L,

3707064583927662579L,

},
},
            new Int64bigintListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4329968680248064390L,

55992309385229696L,

6255085064891482291L,

5416424071393309092L,

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
1471776683230296623L,

7172960104919150942L,

3467757306101992985L,

5149353932669911640L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2206503252987022338L,

5411720316860162326L,

8775868188695480115L,

5339115707822867426L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6396196779367951329L,

4779338504419167069L,

1810197200853002488L,

2073190096635631813L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2512692226412789979L,

3775487858333541479L,

8144536678934375441L,

},
},
            new Int64bigintListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1557646054291818850L,

8809591976330806016L,

203455120013674918L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1824950185487309741L,

2921627927256121702L,

2037270423477720592L,

},
},
            new Int64bigintListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8658856693200086128L,

8176134278621463458L,

2027348627502517665L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3992923182794894173L,

6707388077166293143L,

2972161418058832376L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2054548140935663860L,

2139907478848618251L,

1135358806657582973L,

6127536504579834529L,

},
},
            new Int64bigintListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
790739535969154866L,

3551699102699386853L,

519550733001338151L,

3548502859299435945L,

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
8849062241792450537L,

1428803497907090064L,

379435358124629035L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8057935849865116743L,

5784855144832348195L,

8698401586648115004L,

4207924844977008010L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4113574268969568189L,

5971618621876585260L,

7340899300161623432L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4143623059721800355L,

8144291706808056375L,

5278168640536336894L,

4384492545507788484L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2567519313616507478L,

437178179879606261L,

1848278029786393116L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5189094560404981879L,

6621283120187818189L,

108187243948999989L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6177771275256685777L,

5022296025437142976L,

2106272602669733424L,

3471588752915907215L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5064968899364482210L,

1186180460017125161L,

5718070946809094992L,

3650852920667823092L,

},
},
            new Int64bigintListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5468988507608443740L,

4762283410271652914L,

6934464936074399079L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7195694934195596329L,

7936639692349128156L,

3757166649970382650L,

3343897035510000505L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5884465830956936668L,

906215812028115238L,

8167751646454854159L,

1922473752563552195L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7533833809507741883L,

6375659824706980217L,

1934099800470761312L,

},
},
            new Int64bigintListD1E2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6274207598503399452L,

4227052847191863181L,

4119630618108518210L,

9120178137205448628L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1490122569574602047L,

1209211023769215662L,

4193674419791225087L,

7852902611606984485L,

},
},
            new Int64bigintListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4481039610900482801L,

6471896077585144132L,

1294036242877904832L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3070515279198285572L,

4174447399740753063L,

4930415108734721541L,

5488238537811756165L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5596472081852609412L,

8394860470492402391L,

3752015908159727423L,

2899862966179398334L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4222995717737384659L,

5945561615263970177L,

6446469291468055979L,

5737127968985561679L,

},
},
            new Int64bigintListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2297923932177984415L,

8149643481048987649L,

7887173981829357309L,

4441082926733535609L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4783998030598231695L,

6225231782604500084L,

35635388149638995L,

},
},
            new Int64bigintListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7035712830858835860L,

4626979167035189341L,

3412679275266729454L,

3343343008623115087L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1400126077994299273L,

5906672536420009038L,

4995126522401040767L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5017523657201746351L,

6503951244889330976L,

3722522855558276583L,

597076306850844884L,

},
},
            new Int64bigintListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1123460193046418560L,

2065666575619945136L,

2302242209092116921L,

598911832628295187L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4784699368211411516L,

7862160308935288787L,

5077812429975594327L,

2717144210251907355L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7552209423385362744L,

5440073932276131931L,

1547982086971850709L,

1144921307607990380L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6142292764137805991L,

2117966330605926942L,

2228074231980783950L,

2143603121163620607L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8934755760271627118L,

4534195901613604155L,

9101493354963439765L,

4763773971556101189L,

},
},
            new Int64bigintListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5914474933934471584L,

2104512622513764041L,

6486239378343300346L,

5033399722088632708L,

},
    ModelInner = new Int64bigintListD1E2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4198877924815450177L,

1506840248382711862L,

7625192741984426095L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9211555591942859722L,

5412015414271470018L,

2226671311784723505L,

4328791349102820296L,

},
},
    NullableValue = null,
},
            new Int64bigintListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7257892607367170906L,

8961335108007130793L,

8170982933943889779L,

4137395308243953515L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6205427112179870964L,

2110362234140524464L,

5385080218125811435L,

},
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
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
                parametr2.Value = 133;
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 120;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
                parametr1.Value = 99;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 113, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
                await ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 7, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
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
                 ((IInt64ListbigintListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 58, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
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
                 ((IInt64ListbigintListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 61, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 84, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt64bigintListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 34, query1, 34, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 7, query1, 16, query2))
                {
                    if(++resultIndex == 1)
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
                 ((IInt64ListbigintListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 90, query1, 59, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 42, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[7], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[8], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[9], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[10], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[11], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[12], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[22],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[23],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[24],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[25],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[26],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[11], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[12], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[22],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[23],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintListD1)this).DbConnectionSTSelectModelBatch(connection, 42, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[7], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[8], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[9], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[10], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[11], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[12], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[22],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[23],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[24],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[25],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[26],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintListD1E2M.AssertModel(models[0],_testData[7], false);
                        Int64bigintListD1E2M.AssertModel(models[1],_testData[8], false);
                        Int64bigintListD1E2M.AssertModel(models[2],_testData[9], false);
                        Int64bigintListD1E2M.AssertModel(models[3],_testData[10], false);
                        Int64bigintListD1E2M.AssertModel(models[4],_testData[11], false);
                        Int64bigintListD1E2M.AssertModel(models[5],_testData[12], false);
                        Int64bigintListD1E2M.AssertModel(models[6],_testData[13], false);
                        Int64bigintListD1E2M.AssertModel(models[7],_testData[14], false);
                        Int64bigintListD1E2M.AssertModel(models[8],_testData[15], false);
                        Int64bigintListD1E2M.AssertModel(models[9],_testData[16], false);
                        Int64bigintListD1E2M.AssertModel(models[10],_testData[17], false);
                        Int64bigintListD1E2M.AssertModel(models[11],_testData[18], false);
                        Int64bigintListD1E2M.AssertModel(models[12],_testData[19], false);
                        Int64bigintListD1E2M.AssertModel(models[13],_testData[20], false);
                        Int64bigintListD1E2M.AssertModel(models[14],_testData[21], false);
                        Int64bigintListD1E2M.AssertModel(models[15],_testData[22], false);
                        Int64bigintListD1E2M.AssertModel(models[16],_testData[23], false);
                        Int64bigintListD1E2M.AssertModel(models[17],_testData[24], false);
                        Int64bigintListD1E2M.AssertModel(models[18],_testData[25], false);
                        Int64bigintListD1E2M.AssertModel(models[19],_testData[26], false);
                        Int64bigintListD1E2M.AssertModel(models[20],_testData[27], false);
                        Int64bigintListD1E2M.AssertModel(models[21],_testData[28], false);
                        Int64bigintListD1E2M.AssertModel(models[22],_testData[29], false);
                        Int64bigintListD1E2M.AssertModel(models[23],_testData[30], false);
                        Int64bigintListD1E2M.AssertModel(models[24],_testData[31], false);
                        Int64bigintListD1E2M.AssertModel(models[25],_testData[32], false);
                        Int64bigintListD1E2M.AssertModel(models[26],_testData[33], false);
                        Int64bigintListD1E2M.AssertModel(models[27],_testData[34], false);
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
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models = await ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintListD1)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models =  ((IInt64ListbigintListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

