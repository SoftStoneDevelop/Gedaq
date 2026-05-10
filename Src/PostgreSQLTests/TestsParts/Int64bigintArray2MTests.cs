

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
new System.Collections.Generic.List<System.Int64>(3)
{
2955460430076518938L,

8869736508201479730L,

6106893303289453089L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4899614529617809009L,

233322404545423486L,

2273271552845602619L,

1792331990421929368L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4153521354972261500L,

8438711873877357293L,

4915459847502847657L,

7680389955297192188L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5579791095956161890L,

2096173204413709365L,

7771734390669083304L,

417429426799308099L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9149330836461065656L,

5158642743924122577L,

1791363316934779352L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5796139448033343312L,

578286650584872375L,

4143362588927447884L,

4879978882926821166L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
872431787656792510L,

829588068618195152L,

5085590861856170170L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3853940440753152791L,

1602210268282847217L,

8629646399949924371L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5954479453347192905L,

3929758444679050408L,

6522588062959679464L,

8466395113150351671L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6341074200423064619L,

5163450036209055779L,

3693061452132151403L,

7174956156297525150L,

},
},
            new Int64bigintArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8928258255189933051L,

3650948682056753895L,

9215869032957288745L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
646481323808183899L,

7871090786952762661L,

5974075354036248291L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
767809520379878696L,

5893716161373500605L,

2866540026299105406L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7334739519472897068L,

8048208407501346401L,

307379017599028774L,

8910906403902600838L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
342139236624212388L,

3500976242136154881L,

1822025885369250693L,

},
},
            new Int64bigintArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4811632354030510206L,

8717373758474042703L,

6821043903575027915L,

8631801181435145877L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
795395429549876163L,

5048111896839846478L,

8462518145835209389L,

7044214655287952547L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5745269729428054690L,

3771090210921668992L,

6447752887971646413L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3317007050758947002L,

275060673223842571L,

9010396853476162458L,

},
},
            new Int64bigintArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7775868434652581149L,

6511726058920392705L,

1370028328317141901L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8078163949321460258L,

1122510767619772704L,

3750864297398053894L,

2117934954007075121L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2605891363678618118L,

6533866961503165682L,

5151363060793820748L,

888288479513515876L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5289706861759055636L,

4584193928354585794L,

7842615478553104352L,

1001931975364843323L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6381899710937953670L,

4232938987015560327L,

8545554675473125874L,

1519303199633881469L,

},
},
            new Int64bigintArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5262512983988613027L,

5905729420599646540L,

2005936448602627522L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
95149728128012478L,

2560277218241989047L,

8321972576871797923L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3957549379150077101L,

5566155657970794955L,

7453567650338865207L,

2357515530913961553L,

},
},
            new Int64bigintArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8633880462255003110L,

862864621127756942L,

7418177962770713658L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3588455990042991365L,

6200116066297596585L,

7007613357030680593L,

2622522956178278238L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2424277182710435943L,

806094863841585650L,

2309333552235293328L,

7072652238753571963L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6351587470880115558L,

2041244059563160778L,

4786618753091255763L,

2322067728113209716L,

},
},
            new Int64bigintArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
192065327623574749L,

6891047958893823012L,

111855962996726542L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4781429443343288499L,

5384643266730964100L,

5832516523393555406L,

8738955223436827715L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4251121725530549276L,

1126892696876179929L,

1551101536574158406L,

7693529302838920894L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4431074075046768066L,

3415674295210892357L,

6496954750512210721L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
836571578509930149L,

3125802059477458747L,

7638431225681671723L,

8473442913935021610L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8154330729466244589L,

3284000304917268225L,

2286871979287304418L,

3508446236725937146L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4066106782405879528L,

2568548669270560984L,

6463587644508793848L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
74247293057615545L,

2012573169025690071L,

2533029252302148178L,

2496992726692695321L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4495430359183878093L,

7463714273492888645L,

825816890101409141L,

8370064252213539612L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
792481177940274714L,

5604822949634336999L,

3520709669523132286L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5657003825559892890L,

5939473915640159840L,

2066857922079913286L,

8188609984913313590L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4681380158340479120L,

8551808042092764094L,

7276606846965279L,

9131989275984971694L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
125093417597022384L,

654296689179946401L,

2066354797065995458L,

},
},
            new Int64bigintArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8874112435562557277L,

7466838099931329193L,

8002436101040882845L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6114133319805480298L,

8029202750962793603L,

4518551365992919417L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
607074133659869968L,

3020560576717618585L,

101887861326575196L,

5720910305987017643L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
398593645011826409L,

8045929204354630424L,

2679643816905750556L,

2640964874314960419L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5321547175692553158L,

6445257259325189011L,

6047051483346695335L,

6338498139636975436L,

},
},
            new Int64bigintArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6185837362617822246L,

8839434522479734674L,

7494303566941961328L,

5109095803368133958L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5218074337329607333L,

6035359910980186633L,

6516905584815676825L,

},
},
            new Int64bigintArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8987522299931650055L,

8509838504564783054L,

8280136872095003943L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8917183742887491837L,

7511628447846216833L,

6119328178118703930L,

870604838112269708L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3697959231110141140L,

8157734848550750150L,

5295905943494046095L,

4699542718412880977L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3042527330306399494L,

2374116127813279715L,

6715568104127419172L,

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
4202345948559688544L,

5681483694806499813L,

3389798610330468808L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2833171887946422546L,

505673386957245189L,

1592705796093579823L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1976558269153434739L,

6638755154542458323L,

1605877940991940328L,

3304991159928589961L,

},
},
            new Int64bigintArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3894350598363419922L,

3385954118650451598L,

5465451024279684801L,

4914617166213437998L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5176235753524012920L,

4217209677472115465L,

169214711208195548L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3213307374525178984L,

936128700363726502L,

7505526027634637151L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4414657623287930197L,

9177640627261843504L,

7931238724847629886L,

165312219872077590L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2435822487127492659L,

3928629658145286370L,

730461579421154932L,

},
},
            new Int64bigintArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3883574904966768500L,

5964780899544418203L,

8225290577232193031L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
832323398231054136L,

8947046343140922093L,

219935636063198275L,

},
},
            new Int64bigintArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
799658144246541737L,

1149505820982957108L,

5979617191828727986L,

5627378360455881998L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7932288359054443091L,

8481015440622634461L,

572791455523044281L,

6547007106098412353L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6209931469775896727L,

3051750106683278212L,

6932304166516785603L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6043917464367409212L,

1704975797651942852L,

1822974433513591198L,

7528270480815217863L,

},
},
            new Int64bigintArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5603709943018435939L,

5327625170458321342L,

383907589497283962L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8373350880896168981L,

4914656146492958301L,

5921487481474158078L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3206230410147306740L,

6418875220321664131L,

5415975023548212391L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6442193269072787524L,

9163086618382456993L,

8104949882266772158L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7636529225205601641L,

8242533956101669983L,

7058813946585158301L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4745501933594673199L,

6812670311367720168L,

9120717226669909499L,

4540624563276799659L,

},
},
            new Int64bigintArray2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
416043118876740451L,

154841279973007897L,

5794600643469361881L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
555152251514398220L,

2479497386811261432L,

4643411647381953699L,

8250265377175206057L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1325175774220730578L,

6105984363068807097L,

1926125205102798532L,

2473024605395656897L,

},
},
            new Int64bigintArray2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5975945117092315082L,

6396528325319537960L,

2745753950529221223L,

4033023830926370361L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5543907258218406078L,

2035894033965477492L,

6740483777049394537L,

5052500980962386402L,

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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                parametr1.Value = 7;
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[34], false);
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
                parametr1.Value = 102;
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[34], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintArray2M.AssertModel(models[0],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintArray2M.AssertModel(models[0],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigintArray2M.AssertModel(models[0],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[34], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 132, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 78, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[34], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 61, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 73, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 155, query1, 20, query2))
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
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 132, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 155, query1, 7, query2))
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
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 139, query1, 170, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 105, 153))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintArray2M.AssertModel(models[0],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatch(connection, 20, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int64bigintArray2M.AssertModel(models[0],_testData[4], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[5], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[28],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[29],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintArray2M.AssertModel(models[0],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[28],_testData[34], false);
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
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 100);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 170);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                Int64bigintArray2M.AssertModel(models[0],_testData[33], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[34], false);
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

