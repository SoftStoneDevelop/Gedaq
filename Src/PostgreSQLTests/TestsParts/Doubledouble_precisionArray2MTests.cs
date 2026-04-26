

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
    internal partial interface IDoubleListdouble_precisionArray
    {
    }
    
    internal partial class DoubleListdouble_precisionArray : IDoubleListdouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray2M[] _testData = new Doubledouble_precisionArray2M[]
        {
            new Doubledouble_precisionArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.10810465632495381d,

0.012945253530766698d,

0.2779591376015552d,

0.5268011225968897d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.10232595475979411d,

0.4579397620578567d,

0.4238749670046885d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9704569605090043d,

0.39284220116647084d,

0.22445143650289878d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2626033347766247d,

0.202675953848362d,

0.333705404870721d,

0.09162667347360609d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5589638815320419d,

0.07463111144245715d,

0.380611545530813d,

0.5613515582395497d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7215108575457253d,

0.652207862190323d,

0.33565490651076324d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.49905624382210556d,

0.5987033558521411d,

0.41488329697672066d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.060904506636973d,

0.640404932210749d,

0.7037853333138117d,

0.21581344372307432d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7200580217177874d,

0.5777299787123711d,

0.3746745266447097d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262353566008165d,

0.8611955902613966d,

0.8560189528065268d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.13125718188290436d,

0.5443934905607776d,

0.7538532950768865d,

0.8293594734283037d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.19801307007048785d,

0.5578307144846292d,

0.2000526161983125d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7269788794802442d,

0.1507463422271118d,

0.14076807732503605d,

0.4530448319406828d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1344261232921361d,

0.8309322766671228d,

0.7977321619738433d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6292654878250231d,

0.5546685006317648d,

0.1638710490176014d,

0.9625464875653326d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7575598628723784d,

0.33246336714011293d,

0.9797064322987717d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4715611186822546d,

0.10874965592434094d,

0.16205541182666505d,

0.279945763015077d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4307588460050574d,

0.11169657297277957d,

0.12070563610411877d,

0.8401561808728388d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.900272826951948d,

0.3517452690161419d,

0.9225285686275007d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.20477960108452697d,

0.6862980328481165d,

0.8009154911724947d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.13332304563255382d,

0.8832599158058155d,

0.4430848472266927d,

0.9357262358504576d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2634238519304627d,

0.43916087703178674d,

0.5141746452978336d,

0.710040256285293d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.25149902485020137d,

0.006757181982935179d,

0.7125672360445012d,

0.42664255108807714d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7676270859091143d,

0.3827234711998655d,

0.012154930266545794d,

0.8398603699368531d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8117538015995635d,

0.6125050351937857d,

0.4262696006657031d,

0.7063795310559637d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.06909636056405954d,

0.2333170003492674d,

0.5791653004707463d,

0.7241627246925955d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.43288901477981356d,

0.2057314113532741d,

0.5229991092877591d,

0.6967366148503417d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4058049037078115d,

0.21990251868152655d,

0.5153816793063496d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6766487973704025d,

0.8367705468757679d,

0.5916794984650766d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.19238822150684987d,

0.7300037005965868d,

0.24536277186286004d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7307465878665921d,

0.05114190179069622d,

0.16657450623138703d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.34760306818896725d,

0.5705548362719285d,

0.5717402688911166d,

0.6053734124147696d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6165615037062387d,

0.46316750298009746d,

0.005308298312556858d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.05832327846514984d,

0.8476970514646656d,

0.8370773836746502d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6439532223656133d,

0.20778717944047143d,

0.3725526816184035d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.14086304013671336d,

0.7639058245773114d,

0.8704209652240512d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8989677485040591d,

0.5388944835724835d,

0.07778321671568145d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7741435199511545d,

0.7716229189519164d,

0.6986969934572154d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5232938268039091d,

0.22156079867556777d,

0.6660684665701601d,

0.7128114293322612d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5214607033498304d,

0.166785610475905d,

0.28199548612463865d,

0.20033836148694306d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9160993298521395d,

0.8355430408932119d,

0.10775435303395153d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.83031686999424d,

0.8775612732322406d,

0.03755859951787899d,

0.7442815954850772d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.11874090814997895d,

0.4608959760556608d,

0.9059685833323641d,

0.08833041568670497d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7890855183119758d,

0.25757709747505997d,

0.9129421523418544d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.14293491993130147d,

0.5841823709013331d,

0.0880892827448353d,

0.5139010228528439d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8167017627318452d,

0.4666603507651307d,

0.06079818502958001d,

0.4904012284601028d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8535273356094124d,

0.29328243300731205d,

0.4903641877834195d,

0.5247586558917012d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07358247212978852d,

0.5788074466352373d,

0.7665709088827856d,

0.5615465584795997d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8521753840936174d,

0.6303051686840754d,

0.8186293364122232d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.262739706920466d,

0.8828118289617196d,

0.5594285346227487d,

0.2530260540429544d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5557242673471624d,

0.7360776106318658d,

0.565738628649233d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19821256301086942d,

0.8525581079329361d,

0.6852096839484825d,

0.3271004426619113d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.27601794032252946d,

0.2621670657161582d,

0.5434365327170652d,

0.2064991329957837d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6774673131264204d,

0.7407728532871525d,

0.41016540720697303d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.06073155607511804d,

0.6004664771471121d,

0.2295338368395624d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5046133148860609d,

0.3566034573311905d,

0.23845507699967927d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05876153326397093d,

0.5015687397931321d,

0.6611886587944641d,

0.8346783787597731d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7315290659863778d,

0.8497166828731103d,

0.07818716224635192d,

0.4996122518778199d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3092085458934195d,

0.9084887044727605d,

0.004596104299418258d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6145163929144609d,

0.18413307078841123d,

0.005749186481919688d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11915413003974762d,

0.8461427455878477d,

0.5931386750978223d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5846430273132571d,

0.4796818623593657d,

0.9272531120553953d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.47375444193340366d,

0.06151167971910343d,

0.3032400154324294d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2444204181237264d,

0.7502968624358264d,

0.42746941206700917d,

0.11561741810519843d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.38770076523429675d,

0.971251776962693d,

0.7303934612428737d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.41284002471566483d,

0.89228205286246d,

0.22985018826833892d,

0.13500750362087244d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9162427520718794d,

0.9627755369574296d,

0.28432064726500184d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6970679101345488d,

0.11329761840358221d,

0.8267457691310266d,

0.7227397767468542d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5241768356965453d,

0.1683530268433474d,

0.5795973021075347d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9969689838751151d,

0.9258477119629036d,

0.2809077085880122d,

0.6464459531180877d,

},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
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

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                List<Doubledouble_precisionArray2M> models = null;

                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray2M> models = null;

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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

                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((IDoubleListdouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IDoubleListdouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[4], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[5], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[6], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[7], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[8], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[9], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[10], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[11], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[12], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[13], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[2], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[3], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[4], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[5], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[6], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[7], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[8], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[9], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[10], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[11], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[12], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[13], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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

                var models = await ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[1], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[2], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[3], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[4], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[5], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[6], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[7], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[8], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[21],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[22],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[23],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[24],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[25],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[26],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[27],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[29], false);
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

                var models =  ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 121, query1, 10, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[2], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[3], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[4], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[5], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[6], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[7], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[8], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[9], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[10], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[11], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[12], false);FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[13], false);FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[14], false);FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[15], false);FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[16], false);FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[17], false);FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[18], false);FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 145, query1, 104, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[19], false);FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[20], false);FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[21], false);FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[22], false);FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[23], false);FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[24], false);FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[25], false);FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[26], false);FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[27], false);FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[28], false);FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelBatchAsync(connection, 92, 133))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[29], false);
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
                var models =  ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelBatch(connection, 17, 49))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[4], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[5], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[6], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[7], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[8], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[21],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[22],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[23],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[24],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[29], false);
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
                await using var cmd = await ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 56);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDoubleListdouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
                await ((IDoubleListdouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2m m
LEFT JOIN public.binary_doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray2M>(15);

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
                ((IDoubleListdouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IDoubleListdouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[14], false);
                Doubledouble_precisionArray2M.AssertModel(models[15],_testData[15], false);
                Doubledouble_precisionArray2M.AssertModel(models[16],_testData[16], false);
                Doubledouble_precisionArray2M.AssertModel(models[17],_testData[17], false);
                Doubledouble_precisionArray2M.AssertModel(models[18],_testData[18], false);
                Doubledouble_precisionArray2M.AssertModel(models[19],_testData[19], false);
                Doubledouble_precisionArray2M.AssertModel(models[20],_testData[20], false);
                Doubledouble_precisionArray2M.AssertModel(models[21],_testData[21], false);
                Doubledouble_precisionArray2M.AssertModel(models[22],_testData[22], false);
                Doubledouble_precisionArray2M.AssertModel(models[23],_testData[23], false);
                Doubledouble_precisionArray2M.AssertModel(models[24],_testData[24], false);
                Doubledouble_precisionArray2M.AssertModel(models[25],_testData[25], false);
                Doubledouble_precisionArray2M.AssertModel(models[26],_testData[26], false);
                Doubledouble_precisionArray2M.AssertModel(models[27],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[28],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

