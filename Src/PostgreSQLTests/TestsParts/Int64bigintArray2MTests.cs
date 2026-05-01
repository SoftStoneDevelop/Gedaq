

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6254578166755031917L,

8435288664750508134L,

227825038403872460L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2082682250122835365L,

4395977560186380125L,

4044431515629327504L,

5043418545130168840L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4588613568435823125L,

50759168191090220L,

8350379761124213384L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4620312722405729059L,

4454376081554260315L,

5313797552245838436L,

6782349487859962295L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4395944617839214906L,

241037061541218232L,

8918057988301361520L,

},
},
            new Int64bigintArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3624109875342109739L,

3984814509114162008L,

183824099665271024L,

7744874116052130544L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3175399016107244975L,

3915666710999414432L,

6449623318604230420L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3924155734885222228L,

1829349730812420653L,

3260167647254699613L,

1014646953429652203L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3198747349794507450L,

3217105023986019978L,

8415450631704855768L,

7333823001152997551L,

},
},
            new Int64bigintArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3541692765244109053L,

1079074409336158703L,

4525833655828738044L,

2611948238802032050L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1969287759107081602L,

604708920598287826L,

5662327447563162L,

564664358513377833L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3519148761697406352L,

8774536965191228436L,

8909956923600802038L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4677537017637625229L,

5500322793334172195L,

5677656930454461307L,

8534077288298380449L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6507412965990269150L,

109702760638889653L,

5901689652472765650L,

7870982021706763313L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8324292174202257379L,

7082187942054629332L,

6158388732788140420L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3229328463555909491L,

6250624674611046350L,

8519678461901380935L,

},
},
            new Int64bigintArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8297178490424739754L,

2917597410419760111L,

7689165642780526040L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2607196411240383800L,

1267402634729130524L,

3801017343094934406L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1320475012340354992L,

2071071717058059210L,

6952062163679563093L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3044337151123574694L,

4892905813078694451L,

7474904112760562153L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8732491597459179306L,

6202510784392230401L,

3317240395560913504L,

},
},
            new Int64bigintArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3261747003622759340L,

5638618873400391366L,

5268033906977263668L,

4032292917664673595L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8504698954371904984L,

5811744509647885128L,

4687188966579998541L,

5836040194488270637L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6187261558672848359L,

8104113841962503145L,

4805206252117237352L,

5289175894939104462L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6981198855541510648L,

5808317955387197214L,

8043173887663540818L,

},
},
            new Int64bigintArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8952807359125337921L,

6189635567422806249L,

3830913449877864976L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5918176606318966532L,

6202308630429521999L,

4154470711226873884L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5625250612950512502L,

3080650323268017924L,

8157409834076495199L,

6295934180254294731L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6772862216373974499L,

3437846661684231652L,

355363865718102891L,

},
},
            new Int64bigintArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7462273559461121058L,

1577715262106459283L,

3618458570926884050L,

6885547779359398430L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6616980502458961174L,

3224985144398255011L,

1643334447472485934L,

3860670757642569004L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8306862340245099375L,

9037667916671622691L,

2622279247719657436L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4927208704556111726L,

7749500398380355991L,

6404566270872869104L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2566300575857122940L,

6843421134408333724L,

4799229336138612523L,

},
},
            new Int64bigintArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
493865687728959711L,

7209192268698114283L,

5859150733508555715L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1062246880039243837L,

5049019594815486510L,

4248243993937348136L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7748487446032649068L,

1170774925895352069L,

5008976163733031772L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6001709280322497436L,

7943536234836641298L,

2202777736436322292L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5165694522155260664L,

4129694154807044161L,

8709482408139545825L,

},
},
            new Int64bigintArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3781037885850015135L,

7604624807356808852L,

5360854882004363631L,

538174200163706902L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2004028735893692298L,

5363947458817839121L,

616723122553132589L,

1355390960280659534L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
226300154989305938L,

4699076487455164552L,

3684273672298330191L,

6338284396631117605L,

},
},
            new Int64bigintArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6261968166358548565L,

487887141294345012L,

199527873196758963L,

4632950019799062454L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1300241642075005435L,

7561178109846623552L,

8326704356165423946L,

},
},
            new Int64bigintArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8617245645104165550L,

7984075019942812321L,

8115159302807496505L,

6202637971869941092L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8389579943289256108L,

1944184585267705614L,

2337335218842236554L,

3190635451803199461L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2377785411180755424L,

7123259363543909157L,

7039960241908010038L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7547516327407717678L,

5163987970390205219L,

4608350802046554335L,

},
},
            new Int64bigintArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4213916630266882801L,

911069665339989298L,

6234159909195202490L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3846074563961295604L,

361960458999138187L,

2595090980546495738L,

6342402202904866584L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6973317822947016303L,

4981624321461305345L,

7217894582480494535L,

1308015951091321292L,

},
},
            new Int64bigintArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6024030834534695584L,

113021285854293982L,

5818158629586334213L,

4898291320220370639L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2798251995322814737L,

6888965607428109583L,

7854990919787739156L,

1215763060686924770L,

},
},
            new Int64bigintArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6494280883249629330L,

4035802963605245124L,

8323088551816596678L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6612994606375493760L,

6976923308149044433L,

7835582899134343617L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1500133055480555171L,

8847356568511562545L,

5789171660460558650L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2908716377797910298L,

8178933707463813020L,

1457314092519388824L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2359624719354047695L,

7331915805078853673L,

6962303301396058084L,

9103069165872819312L,

},
},
            new Int64bigintArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
692161178424767428L,

7167715000757173096L,

4762061548996055320L,

3684826605254524687L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4593544056351264557L,

6510993028775528616L,

8250376445695100990L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8669240987291988473L,

215648762434713051L,

8347281377988985879L,

327999900344951486L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6544041485132335838L,

2351595496158569940L,

8480754015570855180L,

3260527526370369988L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4667487951567463991L,

8785969866540249736L,

4937805333281605402L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1292141337307596199L,

2574435305800518116L,

2491318794928166258L,

7139243407828134047L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
882931151643841035L,

6340498146730009915L,

3411521132617381784L,

82904261173353792L,

},
},
            new Int64bigintArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
337469374288604480L,

5831998312406135600L,

133262346923388000L,

9034196748792229577L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2599999824947421838L,

6571726292043096448L,

5850946770324612246L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2828374185709989127L,

686267814990289187L,

7121497462495850304L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8426050329738475621L,

5782086609171460064L,

8077997829181703347L,

},
},
            new Int64bigintArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1182221311268783649L,

1017731578762586469L,

6013455995772446329L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1327512763290542698L,

7557298706227408480L,

5247127429981675073L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6006690082089057238L,

8736210289125787710L,

8614889346961653865L,

8806747316672128541L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4703305820984329774L,

236731705424928866L,

6277331171321325472L,

},
},
            new Int64bigintArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
751814520203024003L,

8463437365661039523L,

1111418986876741723L,

597055149195615893L,

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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[34], false);
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
                parametr1.Value = 115;
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
                parametr1.Value = 45;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                parametr1.Value = 144;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[34], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int64bigintArray2M.AssertModel(models[0],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int64bigintArray2M.AssertModel(models[0],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 5, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 52, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[34], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 137, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 18, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 26, query1, 137, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 9, query1, 75, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 9, query1, 33, query2))
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[27],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[28],_testData[34], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 133, query1, 144, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 45, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int64bigintArray2M.AssertModel(models[0],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatch(connection, 9, 94))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 145);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
Int64bigintArray2M.AssertModel(models[0],_testData[30], false);Int64bigintArray2M.AssertModel(models[1],_testData[31], false);Int64bigintArray2M.AssertModel(models[2],_testData[32], false);Int64bigintArray2M.AssertModel(models[3],_testData[33], false);Int64bigintArray2M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 154);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
Int64bigintArray2M.AssertModel(models[0],_testData[32], false);Int64bigintArray2M.AssertModel(models[1],_testData[33], false);Int64bigintArray2M.AssertModel(models[2],_testData[34], false);
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

