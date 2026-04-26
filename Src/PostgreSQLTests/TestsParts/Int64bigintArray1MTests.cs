

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
    Id = 2,
    Value = 
new System.Int64[3]
{
6646226788360960501L,
5806059964790950131L,
4977452798336480874L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 11,
    Value = 
new System.Int64[3]
{
4251822964056768832L,
872801784798706401L,
345320957226616374L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 3,
    Value = 
new System.Int64[3]
{
5895306726041041914L,
4397713914904662468L,
6987611853243459928L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
9060632668956087350L,
5634421506539020292L,
7385323690879117431L,
},
},
            new Int64bigintArray1M
{
    Id = 14,
    Value = 
new System.Int64[4]
{
7885272721260262253L,
6233335805885365028L,
6297640099628796176L,
5501390510421136906L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 15,
    Value = 
new System.Int64[4]
{
5412517602530390990L,
5963537467497307911L,
3895458519214968019L,
8615818017108160300L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 11,
    Value = 
new System.Int64[4]
{
7896430035650559664L,
665706098061587981L,
2009668861128454897L,
166800390144711159L,
},
    NullableValue = 
new System.Int64[3]
{
6805316457832466156L,
769642035672022232L,
5245673342323225671L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 16,
    Value = 
new System.Int64[3]
{
6631880668352922989L,
2517154866958467814L,
1296880845674698912L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
6453614387800220358L,
5836497719225643402L,
7183502695836481244L,
},
},
            new Int64bigintArray1M
{
    Id = 17,
    Value = 
new System.Int64[3]
{
2080304142966606557L,
5309761611536679583L,
1386238527669195274L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 16,
    Value = 
new System.Int64[4]
{
363489499129634823L,
5090720182665542548L,
8142382024399205979L,
947946526882488319L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6519099524138274015L,
7281968510151335479L,
3960121790996389959L,
8596281513403966961L,
},
},
            new Int64bigintArray1M
{
    Id = 26,
    Value = 
new System.Int64[4]
{
3258986028481622983L,
2423774413754506204L,
7847444197663175747L,
2871492353778388542L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 35,
    Value = 
new System.Int64[4]
{
1730382344944845549L,
8584818754503526040L,
1323883234438411393L,
6238605278475454063L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 23,
    Value = 
new System.Int64[3]
{
8231696650656504619L,
7266366731056802562L,
2448203042390423906L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
1050534289944730717L,
9212776270289038965L,
5848119590702731565L,
9150830335596881519L,
},
},
            new Int64bigintArray1M
{
    Id = 42,
    Value = 
new System.Int64[4]
{
4288373622952806669L,
4873239359772382872L,
4472460572890787331L,
5787020306286489859L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
6196669809714373621L,
4201759535025918465L,
7170869237937039165L,
},
},
            new Int64bigintArray1M
{
    Id = 43,
    Value = 
new System.Int64[3]
{
4221394192867358682L,
4038199023385331044L,
6835951864148723801L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 27,
    Value = 
new System.Int64[3]
{
7876639874462463981L,
215961050897811559L,
8735437484160010058L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
6316148803087334844L,
1591577976679130748L,
6013387399099205088L,
},
},
            new Int64bigintArray1M
{
    Id = 45,
    Value = 
new System.Int64[3]
{
3521242279766506338L,
4745939447179078866L,
1406839691877390531L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3387883249052122691L,
4676274865579230413L,
2510065557063202228L,
5929699866062092528L,
},
},
            new Int64bigintArray1M
{
    Id = 52,
    Value = 
new System.Int64[3]
{
5032020989778372728L,
872435317225400895L,
3370108847857973494L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 32,
    Value = 
new System.Int64[3]
{
1691933984260160100L,
8443435290917569158L,
4012857344792736389L,
},
    NullableValue = 
new System.Int64[3]
{
1050893635398260799L,
4235845167550944348L,
475008118586072167L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 60,
    Value = 
new System.Int64[3]
{
4334311899758274680L,
798251599533889462L,
7862857850036584878L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1380574687649167064L,
5884924933715239643L,
7258570081510389922L,
8991630773970551084L,
},
},
            new Int64bigintArray1M
{
    Id = 63,
    Value = 
new System.Int64[3]
{
6919466661223307920L,
4134598742314220626L,
8267965398588685182L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 35,
    Value = 
new System.Int64[4]
{
148340555761658655L,
1234721130591230761L,
8981331332698637333L,
8672986501001551719L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
7384808602379937174L,
9057292221733705303L,
7417007467411232659L,
689607065495499583L,
},
},
            new Int64bigintArray1M
{
    Id = 70,
    Value = 
new System.Int64[4]
{
8232613070163068129L,
2685295967879632657L,
8427945972332523234L,
1690806159417946330L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 72,
    Value = 
new System.Int64[4]
{
6773569015380879899L,
5775281971602859945L,
8710388321607010908L,
6045182328797126318L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 42,
    Value = 
new System.Int64[4]
{
8354514520395890202L,
4729874247944304707L,
7536560651955376159L,
6854922325740766270L,
},
    NullableValue = 
new System.Int64[3]
{
8690735286390766704L,
2794802037500005709L,
6764472738735515512L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 74,
    Value = 
new System.Int64[4]
{
2639435418526941076L,
3241671813217692687L,
3539444050065143856L,
4279690068295498735L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 77,
    Value = 
new System.Int64[3]
{
5628766260401668133L,
3913693877887397977L,
5837363816162481668L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 51,
    Value = 
new System.Int64[3]
{
7474075812506511545L,
6309803737966620852L,
3365072949869976083L,
},
    NullableValue = 
new System.Int64[3]
{
8294720578872632211L,
6988515186962500312L,
6190265115239349091L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 84,
    Value = 
new System.Int64[3]
{
3678590227173546925L,
2455877070635131938L,
4212604615031114476L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1131789237956283808L,
5101961377307873008L,
2937331075533943066L,
4175431377089572502L,
},
},
            new Int64bigintArray1M
{
    Id = 88,
    Value = 
new System.Int64[4]
{
7935986954966717484L,
8285819052232902644L,
3807862465666624598L,
1239880852597385577L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 59,
    Value = 
new System.Int64[4]
{
4973579002583484100L,
6737718546013497173L,
3436713466007963009L,
732505561585765938L,
},
    NullableValue = 
new System.Int64[3]
{
8268038593860607406L,
4107671109068547066L,
1760950672430975422L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 94,
    Value = 
new System.Int64[3]
{
7004732111900946182L,
3741809565847138213L,
2804411320908996965L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
6043572584653167163L,
2243371732385462354L,
2823154760936346041L,
9125066442722722917L,
},
},
            new Int64bigintArray1M
{
    Id = 101,
    Value = 
new System.Int64[3]
{
1830959108400564096L,
4787499999614777610L,
3977288497560696198L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 62,
    Value = 
new System.Int64[3]
{
1562527534492548498L,
5043445583083134709L,
3156701552406930436L,
},
    NullableValue = 
new System.Int64[3]
{
2474049690037250639L,
8628976112267374536L,
5204307109447597511L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 103,
    Value = 
new System.Int64[3]
{
1731088387353892163L,
7146467009607310418L,
4066200377762046361L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 110,
    Value = 
new System.Int64[4]
{
3237633060232669945L,
6242194426746910154L,
4863132779309787187L,
5889779767977735787L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 69,
    Value = 
new System.Int64[3]
{
4277365570470796087L,
5413685219170382931L,
3580163186184736200L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 113,
    Value = 
new System.Int64[4]
{
2524371621059871914L,
5384933890185866390L,
3958846660003742010L,
3154024603874079633L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 119,
    Value = 
new System.Int64[4]
{
8668190786790586725L,
4564445482458541889L,
7345419955830807692L,
8868638908444077226L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 75,
    Value = 
new System.Int64[3]
{
6746761768277414633L,
7907868042314204345L,
4869155051788646990L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 126,
    Value = 
new System.Int64[4]
{
2152201315447664629L,
1025423416475950094L,
4547729197196044507L,
7995527432283075048L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
5532572688318524229L,
6066178700997625620L,
9008450421659005135L,
5944603881219616232L,
},
},
            new Int64bigintArray1M
{
    Id = 131,
    Value = 
new System.Int64[4]
{
4527702092665061664L,
2218802858986983401L,
4279687810917290856L,
4455929572722945798L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 79,
    Value = 
new System.Int64[4]
{
8705659393698886523L,
2441870641972868498L,
1549709647824683597L,
5903596860097192696L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 133,
    Value = 
new System.Int64[3]
{
2129200292390371352L,
509616614289364219L,
7367171605653493271L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 138,
    Value = 
new System.Int64[4]
{
878187074238031687L,
303519138978648024L,
6527276975954414814L,
4282129667608762842L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 81,
    Value = 
new System.Int64[3]
{
1499483851174931245L,
167243716230085710L,
6279810998535630705L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
5446759591740633228L,
3255032485528657526L,
1685807941549853539L,
4503342703422182978L,
},
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
6453614387800220358L,
5836497719225643402L,
7183502695836481244L,
}));
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
6519099524138274015L,
7281968510151335479L,
3960121790996389959L,
8596281513403966961L,
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
1050534289944730717L,
9212776270289038965L,
5848119590702731565L,
9150830335596881519L,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
6196669809714373621L,
4201759535025918465L,
7170869237937039165L,
}));
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
6316148803087334844L,
1591577976679130748L,
6013387399099205088L,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
3387883249052122691L,
4676274865579230413L,
2510065557063202228L,
5929699866062092528L,
}));
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 14;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[30], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintArray1M.AssertModel(models[0],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int64bigintArray1M.AssertModel(models[0],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintArray1M.AssertModel(models[0],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintArray1M.AssertModel(models[0],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 131, query1, 15, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 60, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 88, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 17, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[29], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 72, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[30], false);
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 103, query1, 60, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 52, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[30], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 14, 101))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int64bigintArray1M.AssertModel(models[0],_testData[3], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[4], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintArray1M.AssertModel(models[0],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[29], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 35, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintArray1M.AssertModel(models[0],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Int64bigintArray1M.AssertModel(models[0],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[29], false);
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
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 94);
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
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
Int64bigintArray1M.AssertModel(models[0],_testData[10], false);Int64bigintArray1M.AssertModel(models[1],_testData[11], false);Int64bigintArray1M.AssertModel(models[2],_testData[12], false);Int64bigintArray1M.AssertModel(models[3],_testData[13], false);Int64bigintArray1M.AssertModel(models[4],_testData[14], false);Int64bigintArray1M.AssertModel(models[5],_testData[15], false);Int64bigintArray1M.AssertModel(models[6],_testData[16], false);Int64bigintArray1M.AssertModel(models[7],_testData[17], false);Int64bigintArray1M.AssertModel(models[8],_testData[18], false);Int64bigintArray1M.AssertModel(models[9],_testData[19], false);Int64bigintArray1M.AssertModel(models[10],_testData[20], false);Int64bigintArray1M.AssertModel(models[11],_testData[21], false);Int64bigintArray1M.AssertModel(models[12],_testData[22], false);Int64bigintArray1M.AssertModel(models[13],_testData[23], false);Int64bigintArray1M.AssertModel(models[14],_testData[24], false);Int64bigintArray1M.AssertModel(models[15],_testData[25], false);Int64bigintArray1M.AssertModel(models[16],_testData[26], false);Int64bigintArray1M.AssertModel(models[17],_testData[27], false);Int64bigintArray1M.AssertModel(models[18],_testData[28], false);Int64bigintArray1M.AssertModel(models[19],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigintArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt64ArraybigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
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
                await ((IInt64ArraybigintArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt64ArraybigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

