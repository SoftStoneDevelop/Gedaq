

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
    internal partial interface IDecimalMArraynumericMArrayD2
    {
    }
    
    internal partial class DecimalMArraynumericMArrayD2 : IDecimalMArraynumericMArrayD2
    {


#region TestData

        private readonly DecimalnumericMArrayD2E1M[] _testData = new DecimalnumericMArrayD2E1M[]
        {
            new DecimalnumericMArrayD2E1M
{
    Id = 5,
    Value = 
new System.Decimal[,] { {
0.566378552237502m,
0.26562154730173m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.701262182986882m,
0.0268653405676766m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 11,
    Value = 
new System.Decimal[,] { {
0.283196649215523m,
0.212517631741857m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 1,
    Value = 
new System.Decimal[,] { {
0.656868440061023m,
0.565391410647555m, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Decimal[,] { {
0.0371390291430222m,
0.606703591474362m, } },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Decimal[,] { {
0.754242021234573m,
0.42704471197874m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 10,
    Value = 
new System.Decimal[,] { {
0.932138656268271m,
0.278392518269921m, } },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { {
0.349571092375269m,
0.0366887671897153m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Decimal[,] { {
0.673568679318118m,
0.688009216577449m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.96585941753452m,
0.336953112110556m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Decimal[,] { {
0.538709476696274m,
0.921783651425253m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 13,
    Value = 
new System.Decimal[,] { {
0.159231207118803m,
0.854402304772791m, } },
    NullableValue = 
new System.Decimal[,] { {
0.180293066022745m,
0.554524058270968m, } },
},
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 22,
    Value = 
new System.Decimal[,] { {
0.0812531888517284m,
0.578494632782159m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.923784787969386m,
0.992081350098492m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Decimal[,] { {
0.144604012543702m,
0.428346963950009m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 17,
    Value = 
new System.Decimal[,] { {
0.71021902820547m,
0.072543264400977m, } },
    NullableValue = 
new System.Decimal[,] { {
0.608450794025167m,
0.592336121218754m, } },
},
    NullableValue = 
new System.Decimal[,] { {
0.981724201754403m,
0.169155521073912m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 30,
    Value = 
new System.Decimal[,] { {
0.49174799800488m,
0.306799261855007m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.327196762940145m,
0.414986841567905m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Decimal[,] { {
0.871745349619318m,
0.602475988565191m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 21,
    Value = 
new System.Decimal[,] { {
0.360443640936723m,
0.801591003833403m, } },
    NullableValue = 
new System.Decimal[,] { {
0.197902050669895m,
0.308674969003733m, } },
},
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Decimal[,] { {
0.361712353353581m,
0.536752404147195m, } },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 54,
    Value = 
new System.Decimal[,] { {
0.583527526778276m,
0.542254874723078m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 29,
    Value = 
new System.Decimal[,] { {
0.094549564089433m,
0.763116978448846m, } },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { {
0.328912346665005m,
0.836310360407508m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Decimal[,] { {
0.539933027544883m,
0.616584497204008m, } },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 68,
    Value = 
new System.Decimal[,] { {
0.114661338724646m,
0.972084266544043m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 33,
    Value = 
new System.Decimal[,] { {
0.0193691481918749m,
0.76880092652506m, } },
    NullableValue = 
new System.Decimal[,] { {
0.203263550981502m,
0.562615242441202m, } },
},
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Decimal[,] { {
0.937962357245304m,
0.380386449057857m, } },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Decimal[,] { {
0.465070290036027m,
0.15612483108674m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 38,
    Value = 
new System.Decimal[,] { {
0.124415253596955m,
0.855552417984454m, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 89,
    Value = 
new System.Decimal[,] { {
0.646398031246633m,
0.76050078889831m, } },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 95,
    Value = 
new System.Decimal[,] { {
0.21115465436975m,
0.318914396835884m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 46,
    Value = 
new System.Decimal[,] { {
0.616132243724337m,
0.606788743520182m, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 102,
    Value = 
new System.Decimal[,] { {
0.636269167596944m,
0.14712930055556m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.43192842197657m,
0.245595937528263m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Decimal[,] { {
0.313302617542272m,
0.965477053366631m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 54,
    Value = 
new System.Decimal[,] { {
0.100552682925219m,
0.910484076624489m, } },
    NullableValue = 
new System.Decimal[,] { {
0.556387732151639m,
0.0307344095778346m, } },
},
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Decimal[,] { {
0.727598417602832m,
0.568671727262136m, } },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Decimal[,] { {
0.897549285570361m,
0.181293254996948m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 55,
    Value = 
new System.Decimal[,] { {
0.616526028888368m,
0.879081201136115m, } },
    NullableValue = 
new System.Decimal[,] { {
0.646344240784701m,
0.500495654369098m, } },
},
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Decimal[,] { {
0.114951664455355m,
0.533344630385013m, } },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Decimal[,] { {
0.484105322034558m,
0.54978306721836m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 60,
    Value = 
new System.Decimal[,] { {
0.602413424199219m,
0.220300193736882m, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 133,
    Value = 
new System.Decimal[,] { {
0.917647485568981m,
0.506506308413078m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.62219450514049m,
0.666945863285439m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 142,
    Value = 
new System.Decimal[,] { {
0.191297022573878m,
0.000150850744831454m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 64,
    Value = 
new System.Decimal[,] { {
0.711894641056232m,
0.72889292990535m, } },
    NullableValue = 
new System.Decimal[,] { {
0.820665663066331m,
0.575362533308464m, } },
},
    NullableValue = 
new System.Decimal[,] { {
0.162203211473023m,
0.91923934897527m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Decimal[,] { {
0.525509452080128m,
0.0756019767282529m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.577114187082768m,
0.927799082675948m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Decimal[,] { {
0.309881432602269m,
0.570259560192909m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 67,
    Value = 
new System.Decimal[,] { {
0.181741611389215m,
0.480082691236973m, } },
    NullableValue = 
new System.Decimal[,] { {
0.0207878835764824m,
0.0550368766717687m, } },
},
    NullableValue = 
new System.Decimal[,] { {
0.750200891225852m,
0.045554121770458m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Decimal[,] { {
0.510684980939525m,
0.918329352324726m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.357629438965851m,
0.36384999151447m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 158,
    Value = 
new System.Decimal[,] { {
0.171596366869084m,
0.673265964827015m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 69,
    Value = 
new System.Decimal[,] { {
0.148952252051729m,
0.989146699808327m, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 160,
    Value = 
new System.Decimal[,] { {
0.892145981724018m,
0.520959954128683m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.514001951899693m,
0.255489945842092m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 166,
    Value = 
new System.Decimal[,] { {
0.290848816625981m,
0.0198830041652688m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 70,
    Value = 
new System.Decimal[,] { {
0.211981769357944m,
0.484698085080319m, } },
    NullableValue = 
new System.Decimal[,] { {
0.83833184747887m,
0.388583566018413m, } },
},
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 171,
    Value = 
new System.Decimal[,] { {
0.0913164006460594m,
0.856477553278384m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.600018962295541m,
0.74119581588295m, } },
},
            new DecimalnumericMArrayD2E1M
{
    Id = 173,
    Value = 
new System.Decimal[,] { {
0.65467201065825m,
0.11914523977103m, } },
    ModelInner = new DecimalnumericMArrayD21MI
{
    Id = 76,
    Value = 
new System.Decimal[,] { {
0.654679425418247m,
0.0576862910195118m, } },
    NullableValue = 
new System.Decimal[,] { {
0.241071311793962m,
0.664217259155248m, } },
},
    NullableValue = null,
},
            new DecimalnumericMArrayD2E1M
{
    Id = 174,
    Value = 
new System.Decimal[,] { {
0.588011154043733m,
0.305518918553701m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.736245569891814m,
0.880661190513218m, } },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmarrayd21mi(
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
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmarrayd21mi(
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
            queryMapTypes: [typeof(DecimalnumericMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IDecimalMArraynumericMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalMArraynumericMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalMArraynumericMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmarrayd2e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmarrayd21mi_id
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
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmarrayd21mi_id", 
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
                changedRows =  ((IDecimalMArraynumericMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalMArraynumericMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalMArraynumericMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalMArraynumericMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmarrayd2e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmarrayd21mi_id
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
    decimalnumericmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
                System.Decimal[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[,]>();
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalMArraynumericMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { {
0.96585941753452m,
0.336953112110556m, } }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[,]>();
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalMArraynumericMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[,]>();
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalMArraynumericMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { {
0.923784787969386m,
0.992081350098492m, } }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[,]>();
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalMArraynumericMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { {
0.981724201754403m,
0.169155521073912m, } }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmarrayd2e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmarrayd21mi_id
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
    decimalnumericmarrayd21mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmarrayd21mi_id", 
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
                System.Decimal[,] nullable = null;
                nullable =  ((IDecimalMArraynumericMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { {
0.327196762940145m,
0.414986841567905m, } }));
                nullable =  ((IDecimalMArraynumericMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[,] nullable = null;
                nullable = await ((IDecimalMArraynumericMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDecimalMArraynumericMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { {
0.328912346665005m,
0.836310360407508m, } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMArrayD2E1M> models = null;

                models =  ((IDecimalMArraynumericMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalMArraynumericMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalMArraynumericMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalMArraynumericMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMArrayD2E1M> models = null;

                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalMArraynumericMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMArrayD2E1M), typeof(FlatDecimalnumericMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
FROM public.decimalnumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMArrayD2E1M>();
                await ((IDecimalMArraynumericMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMArrayD2E1M>();
                ((IDecimalMArraynumericMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
FROM public.decimalnumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalMArraynumericMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalMArraynumericMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmarrayd2e1m m
LEFT JOIN public.decimalnumericmarrayd21mi mi ON mi.id = m.decimalnumericmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
                var models = await ((IDecimalMArraynumericMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalMArraynumericMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMArrayD2E1M), typeof(FlatDecimalnumericMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
FROM public.decimalnumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMArrayD2E1M>();
                await ((IDecimalMArraynumericMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMArrayD2E1M>();
                ((IDecimalMArraynumericMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
FROM public.decimalnumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalMArraynumericMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmarrayd2e1m m
LEFT JOIN public.decimalnumericmarrayd21mi mi ON mi.id = m.decimalnumericmarrayd21mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
                var models = await ((IDecimalMArraynumericMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalMArraynumericMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMArrayD2E1M), typeof(FlatDecimalnumericMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMArrayD2E1M>();
                await((IDecimalMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
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
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                await ((IDecimalMArraynumericMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                await ((IDecimalMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMArrayD2E1M>();
                ((IDecimalMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                 ((IDecimalMArraynumericMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[15],_testData[34], false);
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
                parametr2.Value = 38;
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
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                 ((IDecimalMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                await ((IDecimalMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                 ((IDecimalMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.decimalnumericmarrayd2e1m m
LEFT JOIN public.decimalnumericmarrayd21mi mi ON mi.id = m.decimalnumericmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
                var models = await((IDecimalMArraynumericMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMArrayD2E1M), typeof(FlatDecimalnumericMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMArrayD2E1M>();
                await((IDecimalMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                await ((IDecimalMArraynumericMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 16, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                await ((IDecimalMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 166, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMArrayD2E1M>();
                ((IDecimalMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                 ((IDecimalMArraynumericMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 19, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                 ((IDecimalMArraynumericMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 166, query1, 158, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                await ((IDecimalMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 160, query1, 12, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 5, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.decimalnumericmarrayd2e1m m
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
FROM public.decimalnumericmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMArrayD2E1M>();
                 ((IDecimalMArraynumericMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 12, query1, 118, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimalnumericMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.decimalnumericmarrayd2e1m m
LEFT JOIN public.decimalnumericmarrayd21mi mi ON mi.id = m.decimalnumericmarrayd21mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
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
                var models = await((IDecimalMArraynumericMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalMArraynumericMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 160, 144))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalMArraynumericMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 144, 38))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        DecimalnumericMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
                await using var cmd = await ((IDecimalMArraynumericMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalMArraynumericMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models = await ((IDecimalMArraynumericMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalMArraynumericMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalMArraynumericMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models =  ((IDecimalMArraynumericMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                DecimalnumericMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                DecimalnumericMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.binary_decimalnumericmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericMArrayD21MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMArrayD21MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMArrayD21MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMArrayD21MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMArrayD21MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmarrayd21mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericMArrayD21MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMArrayD21MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMArrayD21MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMArrayD21MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMArrayD21MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmarrayd21mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmarrayd21mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericMArrayD21MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMArrayD21MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMArrayD21MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMArrayD21MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericmarrayd21mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
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
FROM public.binary_decimalnumericmarrayd2e1m m
LEFT JOIN public.binary_decimalnumericmarrayd21mi mi ON mi.id = m.decimalnumericmarrayd21mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IDecimalMArraynumericMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericmarrayd21mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models =  ((IDecimalMArraynumericMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalMArraynumericMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMArrayD21MIWA), typeof(DecimalnumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericMArrayD21MIWA>();
                var models2 = new List<DecimalnumericMArrayD21MIWA>();
                await ((IDecimalMArraynumericMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMArrayD21MIWA>();
                var models2 = new List<DecimalnumericMArrayD21MIWA>();
                ((IDecimalMArraynumericMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalMArraynumericMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmarrayd21mi
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
                    DecimalnumericMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericmarrayd21mi
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
                    DecimalnumericMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMArrayD21MIWA), typeof(DecimalnumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
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
                var models1 = new List<DecimalnumericMArrayD21MIWA>();
                var models2 = new List<DecimalnumericMArrayD21MIWA>();
                await ((IDecimalMArraynumericMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMArrayD21MIWA>();
                var models2 = new List<DecimalnumericMArrayD21MIWA>();
                ((IDecimalMArraynumericMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmarrayd21mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
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
                var models = await ((IDecimalMArraynumericMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmarrayd21mi
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
                    DecimalnumericMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericmarrayd21mi
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
                    DecimalnumericMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMArrayD21MI), typeof(DecimalnumericMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericMArrayD21MI>();
                var models2 = new List<DecimalnumericMArrayD21MI>();
                await ((IDecimalMArraynumericMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMArrayD21MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMArrayD21MI>();
                var models2 = new List<DecimalnumericMArrayD21MI>();
                ((IDecimalMArraynumericMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMArrayD21MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMArrayD21MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmarrayd21mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMArrayD21MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalMArraynumericMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMArrayD21MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMArrayD21MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmarrayd21mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMArrayD21MIWA), typeof(DecimalnumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
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
                var models1 = new List<DecimalnumericMArrayD21MIWA>();
                var models2 = new List<DecimalnumericMArrayD21MIWA>();
                await ((IDecimalMArraynumericMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMArrayD21MIWA>();
                var models2 = new List<DecimalnumericMArrayD21MIWA>();
                ((IDecimalMArraynumericMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmarrayd21mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMArrayD21MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMArrayD2))]
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
                var models = await ((IDecimalMArraynumericMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMArrayD21MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

