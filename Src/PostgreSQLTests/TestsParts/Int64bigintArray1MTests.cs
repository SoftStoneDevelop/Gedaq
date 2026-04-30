

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
    internal partial interface IInt64ArraybigintArray
    {
    }
    
    internal partial class Int64ArraybigintArray : IInt64ArraybigintArray
    {


#region TestData

        private readonly Int64bigintArray1M[] _testData = new Int64bigintArray1M[]
        {
            new Int64bigintArray1M
{
    Id = 1,
    Value = 
new System.Int64[3]
{
8527090287818203112L,
383968990349678881L,
7605966199022943356L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
8858569217992551055L,
7749353976598573473L,
4610237623647283969L,
},
},
            new Int64bigintArray1M
{
    Id = 5,
    Value = 
new System.Int64[3]
{
4918066818402356083L,
4366392333912861554L,
2014734253665924237L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 4,
    Value = 
new System.Int64[3]
{
808864132268373746L,
5437164183014837377L,
7492365947331515170L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 13,
    Value = 
new System.Int64[4]
{
1892154775626435002L,
46066476367666513L,
8643211808053793154L,
2668156292442526490L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
9189548992154901425L,
7679044697618409608L,
7578537633462737506L,
8880469902343334128L,
},
},
            new Int64bigintArray1M
{
    Id = 17,
    Value = 
new System.Int64[4]
{
6069243446593761025L,
5162231288142936475L,
2569499126621024679L,
2329894329499585744L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 11,
    Value = 
new System.Int64[4]
{
4054421893879838295L,
7634198289930485718L,
2278593007745101767L,
8953647164956417092L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
1199854474149733551L,
921369509304158874L,
5884753629671241630L,
},
},
            new Int64bigintArray1M
{
    Id = 26,
    Value = 
new System.Int64[3]
{
1342576641283257700L,
2794743355244352219L,
6644686196938709043L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 34,
    Value = 
new System.Int64[4]
{
1693135761158161616L,
5828666777270858388L,
9114977457623291692L,
7010260706420220041L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 19,
    Value = 
new System.Int64[3]
{
7589551075683012702L,
6049812992915215450L,
2464619514329197623L,
},
    NullableValue = 
new System.Int64[3]
{
1271077715770378458L,
3453814955297844965L,
4157647339339862062L,
},
},
    NullableValue = 
new System.Int64[4]
{
5495821336993164222L,
8969096748684175536L,
8711600020288702945L,
8810668763630786443L,
},
},
            new Int64bigintArray1M
{
    Id = 37,
    Value = 
new System.Int64[4]
{
7899037922612772704L,
8246122214023446128L,
2945100817776403769L,
805311723543613078L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 41,
    Value = 
new System.Int64[3]
{
2837165709891630545L,
8387125516128028047L,
3418063628129461416L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 24,
    Value = 
new System.Int64[4]
{
6415798888700222757L,
2603091380849368202L,
342922099613486493L,
4360533323344597096L,
},
    NullableValue = 
new System.Int64[4]
{
7291602687373050213L,
3511656124421322065L,
3754925045417714676L,
6035795284878254797L,
},
},
    NullableValue = 
new System.Int64[4]
{
2036646619373697213L,
1069609062238469315L,
4636546046283512626L,
2522830926696565797L,
},
},
            new Int64bigintArray1M
{
    Id = 48,
    Value = 
new System.Int64[3]
{
3521206053421466365L,
2690564887834962208L,
8081157557421874711L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 57,
    Value = 
new System.Int64[3]
{
8060864722104136885L,
2882929445587545864L,
3591566436080450013L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 27,
    Value = 
new System.Int64[3]
{
4247619849341820128L,
4808274010079719642L,
5593311489255298573L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
1638495875736902916L,
5406149271108673927L,
7457027192297360286L,
},
},
            new Int64bigintArray1M
{
    Id = 64,
    Value = 
new System.Int64[3]
{
7407645642217192333L,
2749393631825935487L,
7854826625062913117L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 69,
    Value = 
new System.Int64[3]
{
3010425990926750862L,
3696179106442611543L,
3104474841976889567L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 34,
    Value = 
new System.Int64[4]
{
3159301661243532528L,
5404217802058584792L,
2784268740571071411L,
4783843931954995323L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 76,
    Value = 
new System.Int64[3]
{
9021484824714218637L,
2512357496832243221L,
3614283095398886624L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 77,
    Value = 
new System.Int64[4]
{
5541673879931331287L,
1615986684622218239L,
7408493820475555559L,
4276662631470882483L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 39,
    Value = 
new System.Int64[3]
{
1047767629327102722L,
8745484465591283868L,
1746420794100270270L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 79,
    Value = 
new System.Int64[3]
{
6764887705910305915L,
5711770757513001455L,
1214215615770211379L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
1379086656966764366L,
1136047718350027967L,
2472765934763994881L,
},
},
            new Int64bigintArray1M
{
    Id = 88,
    Value = 
new System.Int64[3]
{
2296462851770470256L,
7074031094576702675L,
3334528929552455148L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 48,
    Value = 
new System.Int64[4]
{
6551475247955490402L,
2979296505998814703L,
9175812179441970287L,
3930545574660806669L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
5510461829847977553L,
2390880147003901333L,
3850665107824425882L,
},
},
            new Int64bigintArray1M
{
    Id = 89,
    Value = 
new System.Int64[3]
{
3238750889195700059L,
5443425597528885422L,
4450477317671060623L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
5676821663876213575L,
2095697701590862025L,
2427916395199903260L,
1024258849203498500L,
},
},
            new Int64bigintArray1M
{
    Id = 90,
    Value = 
new System.Int64[4]
{
7491534500996957414L,
4496458157078640522L,
2521108387093073550L,
5966930847273940229L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 50,
    Value = 
new System.Int64[4]
{
3385194144421579491L,
5112610609674367449L,
5327213774790874803L,
5929057805231504845L,
},
    NullableValue = 
new System.Int64[4]
{
7189700701692756923L,
555302292565511658L,
5724805459774139441L,
7962481982984015184L,
},
},
    NullableValue = 
new System.Int64[3]
{
8140789610364023047L,
4435365271511397223L,
5817894953791961527L,
},
},
            new Int64bigintArray1M
{
    Id = 95,
    Value = 
new System.Int64[3]
{
4211951600022880480L,
2413443147063720222L,
6080237095455394905L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 98,
    Value = 
new System.Int64[4]
{
5420383292570327751L,
3623744378414648481L,
462618330039199437L,
1757415197595738764L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 57,
    Value = 
new System.Int64[3]
{
999961581252826253L,
524415103202337905L,
890660519285568140L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
7024369246292061645L,
8691128343715066388L,
1987319877844161423L,
2599029691236804314L,
},
},
            new Int64bigintArray1M
{
    Id = 106,
    Value = 
new System.Int64[3]
{
622543885760057910L,
5347997993788555086L,
5684674133654667756L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 112,
    Value = 
new System.Int64[3]
{
9085747550910435070L,
4983374265689743503L,
2603772454112013687L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 66,
    Value = 
new System.Int64[3]
{
3803668110321292097L,
6183366040841150373L,
7445003826873698806L,
},
    NullableValue = 
new System.Int64[4]
{
1246485505943585864L,
2838782845239468981L,
8164871839754194317L,
167078886535051661L,
},
},
    NullableValue = 
new System.Int64[3]
{
5948991827681016022L,
1976849119663695234L,
1444243954609181008L,
},
},
            new Int64bigintArray1M
{
    Id = 115,
    Value = 
new System.Int64[3]
{
1932455684818483494L,
3676396783883289762L,
6765034431305238373L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 123,
    Value = 
new System.Int64[4]
{
1031846468707105669L,
7491378376284900543L,
3747693798834904835L,
5676565426119390229L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 71,
    Value = 
new System.Int64[3]
{
1534525651290245380L,
7967944149041466507L,
6190098524957155731L,
},
    NullableValue = 
new System.Int64[3]
{
6535392025320378255L,
8487030283889777079L,
4348146479264621242L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 124,
    Value = 
new System.Int64[3]
{
7030330044653770249L,
325015442073504796L,
7347731975242439516L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4522269910383915501L,
8379611331850476154L,
3020235026577982752L,
1245552897353783477L,
},
},
            new Int64bigintArray1M
{
    Id = 127,
    Value = 
new System.Int64[4]
{
1844247982236038429L,
5354730277292326752L,
2883913132035546804L,
8280588317758591494L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 73,
    Value = 
new System.Int64[4]
{
3761887952541813655L,
7171503973905806838L,
3526248309303164309L,
197716220991076525L,
},
    NullableValue = 
new System.Int64[4]
{
5324945797480769656L,
8956349744088871426L,
6662735799342095904L,
3232141473664152951L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 136,
    Value = 
new System.Int64[3]
{
695997656978856417L,
6211973668743679457L,
1558818484620288282L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
6507358958946711704L,
2894121911294684621L,
6093101927914313271L,
},
},
            new Int64bigintArray1M
{
    Id = 138,
    Value = 
new System.Int64[4]
{
6354880055743237140L,
7242615512701413237L,
209297908973490948L,
4498109024378191921L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 76,
    Value = 
new System.Int64[3]
{
2150200428928414980L,
1039862754662276656L,
711636199922588375L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 142,
    Value = 
new System.Int64[3]
{
4081387909023359029L,
571773850905311782L,
1034921587922582215L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
6361440933980247196L,
2310719892515946152L,
4308099484594769721L,
8016464255868535029L,
},
},
            new Int64bigintArray1M
{
    Id = 143,
    Value = 
new System.Int64[4]
{
4064326618895340549L,
6090334537750132316L,
8772109106440104920L,
2583379861701641752L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 84,
    Value = 
new System.Int64[3]
{
8916829107656781280L,
2426603331454994591L,
6251679024513285738L,
},
    NullableValue = 
new System.Int64[3]
{
3694614552576681869L,
5794283119407186357L,
2931328138125210178L,
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
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

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
            asPartInterface: typeof(IInt64ArraybigintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
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
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
5495821336993164222L,
8969096748684175536L,
8711600020288702945L,
8810668763630786443L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
2036646619373697213L,
1069609062238469315L,
4636546046283512626L,
2522830926696565797L,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
1638495875736902916L,
5406149271108673927L,
7457027192297360286L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ArraybigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ArraybigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
                parametr2.Value = 124;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[29], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Int64bigintArray1M.AssertModel(models[0],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintArray1M.AssertModel(models[0],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[29], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Int64bigintArray1M.AssertModel(models[0],_testData[2], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[3], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[4], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int64bigintArray1M.AssertModel(models[0],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 17, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 90, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[29], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 77, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 112, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 37, query1, 115, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[29], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 136, query1, 41, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 123, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[29], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 41, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 79, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigintArray1M.AssertModel(models[0],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigintArray1M.AssertModel(models[0],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[29], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 69, 69))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int64bigintArray1M.AssertModel(models[0],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Int64bigintArray1M.AssertModel(models[0],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[29], false);
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
                await using var cmd = await ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
Int64bigintArray1M.AssertModel(models[0],_testData[21], false);Int64bigintArray1M.AssertModel(models[1],_testData[22], false);Int64bigintArray1M.AssertModel(models[2],_testData[23], false);Int64bigintArray1M.AssertModel(models[3],_testData[24], false);Int64bigintArray1M.AssertModel(models[4],_testData[25], false);Int64bigintArray1M.AssertModel(models[5],_testData[26], false);Int64bigintArray1M.AssertModel(models[6],_testData[27], false);Int64bigintArray1M.AssertModel(models[7],_testData[28], false);Int64bigintArray1M.AssertModel(models[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
Int64bigintArray1M.AssertModel(models[0],_testData[11], false);Int64bigintArray1M.AssertModel(models[1],_testData[12], false);Int64bigintArray1M.AssertModel(models[2],_testData[13], false);Int64bigintArray1M.AssertModel(models[3],_testData[14], false);Int64bigintArray1M.AssertModel(models[4],_testData[15], false);Int64bigintArray1M.AssertModel(models[5],_testData[16], false);Int64bigintArray1M.AssertModel(models[6],_testData[17], false);Int64bigintArray1M.AssertModel(models[7],_testData[18], false);Int64bigintArray1M.AssertModel(models[8],_testData[19], false);Int64bigintArray1M.AssertModel(models[9],_testData[20], false);Int64bigintArray1M.AssertModel(models[10],_testData[21], false);Int64bigintArray1M.AssertModel(models[11],_testData[22], false);Int64bigintArray1M.AssertModel(models[12],_testData[23], false);Int64bigintArray1M.AssertModel(models[13],_testData[24], false);Int64bigintArray1M.AssertModel(models[14],_testData[25], false);Int64bigintArray1M.AssertModel(models[15],_testData[26], false);Int64bigintArray1M.AssertModel(models[16],_testData[27], false);Int64bigintArray1M.AssertModel(models[17],_testData[28], false);Int64bigintArray1M.AssertModel(models[18],_testData[29], false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray1MI),
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ArraybigintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ArraybigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray1M),
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
FROM public.binary_int64bigintarray1m m
LEFT JOIN public.binary_int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigintArray1M>(15);

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
                ((IInt64ArraybigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int64bigintArray1M.AssertModel(models[0],_testData[0], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[1], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[2], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[3], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[4], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[5], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[6], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[7], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[8], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[9], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[10], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[11], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[12], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[13], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IInt64ArraybigintArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt64ArraybigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int64bigintArray1M.AssertModel(models[0],_testData[0], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[1], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[2], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[3], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[4], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[5], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[6], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[7], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[8], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[9], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[10], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[11], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[12], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[13], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[14], false);
                Int64bigintArray1M.AssertModel(models[15],_testData[15], false);
                Int64bigintArray1M.AssertModel(models[16],_testData[16], false);
                Int64bigintArray1M.AssertModel(models[17],_testData[17], false);
                Int64bigintArray1M.AssertModel(models[18],_testData[18], false);
                Int64bigintArray1M.AssertModel(models[19],_testData[19], false);
                Int64bigintArray1M.AssertModel(models[20],_testData[20], false);
                Int64bigintArray1M.AssertModel(models[21],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[22],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[23],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[24],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[25],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[26],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[27],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[28],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64ArraybigintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64ArraybigintArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

