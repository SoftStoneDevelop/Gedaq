

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
    internal partial interface IDecimalMArraynumericMMArrayD2
    {
    }
    
    internal partial class DecimalMArraynumericMMArrayD2 : IDecimalMArraynumericMMArrayD2
    {


#region TestData

        private readonly DecimalnumericMMArrayD2E1M[] _testData = new DecimalnumericMMArrayD2E1M[]
        {
            new DecimalnumericMMArrayD2E1M
{
    Id = 2,
    Value = 
new System.Decimal[,] { {
0.817627408725457m,
0.178997245121768m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.28123765888445m,
0.864384671424336m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 4,
    Value = 
new System.Decimal[,] { {
0.539288380123741m,
0.013219615495989m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Decimal[,] { {
0.714388977453756m,
0.0416539431233183m, } },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { {
0.812856655295696m,
0.934911495233639m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Decimal[,] { {
0.319541471093825m,
0.888617560247894m, } },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Decimal[,] { {
0.530848742708956m,
0.502546541492754m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 4,
    Value = 
new System.Decimal[,] { {
0.472967657992817m,
0.45628439121921m, } },
    NullableValue = 
new System.Decimal[,] { {
0.834293070466321m,
0.962948439589172m, } },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Decimal[,] { {
0.72843449800973m,
0.770527572293047m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.489464333635537m,
0.229004327304976m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 33,
    Value = 
new System.Decimal[,] { {
0.318304784711431m,
0.726288857617252m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Decimal[,] { {
0.0765598849585349m,
0.802068999102048m, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 37,
    Value = 
new System.Decimal[,] { {
0.652293479712825m,
0.664040279547027m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.52220476611095m,
0.877147067004787m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Decimal[,] { {
0.801914417220568m,
0.710497140318826m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Decimal[,] { {
0.930780228167048m,
0.528411119745273m, } },
    NullableValue = 
new System.Decimal[,] { {
0.318870715530764m,
0.423509138487535m, } },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 40,
    Value = 
new System.Decimal[,] { {
0.849428391720101m,
0.139006924370621m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.725068143679677m,
0.739453598396116m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 44,
    Value = 
new System.Decimal[,] { {
0.551854977264777m,
0.22778573965829m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Decimal[,] { {
0.962685020393553m,
0.816219274271755m, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Decimal[,] { {
0.464943579817753m,
0.355998324223569m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.645763960536887m,
0.764829377438831m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 51,
    Value = 
new System.Decimal[,] { {
0.0277207280174849m,
0.103088996563257m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Decimal[,] { {
0.828616461130523m,
0.099965474053099m, } },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { {
0.689836880924491m,
0.690365843730578m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Decimal[,] { {
0.962740750877452m,
0.497101360541955m, } },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 57,
    Value = 
new System.Decimal[,] { {
0.613723276934794m,
0.943584683824119m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Decimal[,] { {
0.0324111377258182m,
0.116634966456112m, } },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { {
0.518809660429207m,
0.0691695666506075m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Decimal[,] { {
0.62105247619184m,
0.0389467403659629m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.775100008039476m,
0.187206239247302m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Decimal[,] { {
0.743405905740352m,
0.917297114469456m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Decimal[,] { {
0.684775286946063m,
0.0946888569608825m, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 73,
    Value = 
new System.Decimal[,] { {
0.905516199060196m,
0.990333576511392m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.79522689470939m,
0.764702206318208m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Decimal[,] { {
0.51328254085994m,
0.698807461911176m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Decimal[,] { {
0.846566491533567m,
0.195126071322358m, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Decimal[,] { {
0.350077260420825m,
0.0318622675612596m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.919075317171382m,
0.811775221948452m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Decimal[,] { {
0.622709291911501m,
0.970543055497929m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Decimal[,] { {
0.0340958348110189m,
0.324258809137965m, } },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { {
0.136272617980069m,
0.882010872362639m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 93,
    Value = 
new System.Decimal[,] { {
0.657537059801783m,
0.0111494623127024m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.127200740926234m,
0.255996799722469m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Decimal[,] { {
0.731997452731066m,
0.22282767304942m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Decimal[,] { {
0.297705339488482m,
0.513584654230295m, } },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { {
0.777846271495699m,
0.554698262941018m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 105,
    Value = 
new System.Decimal[,] { {
0.155251907319331m,
0.611152051634628m, } },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Decimal[,] { {
0.293577076486658m,
0.662502052282375m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Decimal[,] { {
0.055697347871495m,
0.448154460281036m, } },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { {
0.616177695865574m,
0.164480338370585m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Decimal[,] { {
0.737702579643313m,
0.0286884529191307m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.507614603200351m,
0.304670148942883m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 114,
    Value = 
new System.Decimal[,] { {
0.0357424850030975m,
0.829315271132138m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Decimal[,] { {
0.547302019465143m,
0.424221375074342m, } },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { {
0.606733224810161m,
0.8613788123832m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Decimal[,] { {
0.280941410317461m,
0.793657023747048m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.228665651524724m,
0.661415402997383m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Decimal[,] { {
0.963212102563245m,
0.19768918059574m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Decimal[,] { {
0.699202241990794m,
0.106910243206978m, } },
    NullableValue = 
new System.Decimal[,] { {
0.639342402756736m,
0.543739345022637m, } },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 138,
    Value = 
new System.Decimal[,] { {
0.643232255299997m,
0.300053330479457m, } },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Decimal[,] { {
0.605100922451337m,
0.730332259523672m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Decimal[,] { {
0.227865531111962m,
0.481334239934973m, } },
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[,] { {
0.714368235271371m,
0.33716661903221m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Decimal[,] { {
0.319181363231003m,
0.725845290978592m, } },
    ModelInner = null,
    NullableValue = 
new System.Decimal[,] { {
0.586043223516024m,
0.792711085208077m, } },
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 158,
    Value = 
new System.Decimal[,] { {
0.0561552744122439m,
0.610865321888357m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Decimal[,] { {
0.324613129441502m,
0.0445434285443069m, } },
    NullableValue = 
new System.Decimal[,] { {
0.293068085732584m,
0.302773323008162m, } },
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 162,
    Value = 
new System.Decimal[,] { {
0.468798554568461m,
0.506560399250023m, } },
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 166,
    Value = 
new System.Decimal[,] { {
0.731449232902662m,
0.883254761826686m, } },
    ModelInner = new DecimalnumericMMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Decimal[,] { {
0.747249748291942m,
0.591036880242179m, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD2E1M
{
    Id = 170,
    Value = 
new System.Decimal[,] { {
0.739391609239658m,
0.572293947384776m, } },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1mi(
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
INSERT INTO public.decimalnumericmmarrayd2e1mi(
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
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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

                changedRows =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd2e1mi_id
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)), 
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
                methodParametrName: "decimalnumericmmarrayd2e1mi_id", 
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
                changedRows =  ((IDecimalMArraynumericMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalMArraynumericMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd2e1mi_id
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
    decimalnumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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

                    nullable =  ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { {
0.489464333635537m,
0.229004327304976m, } }));
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

                    nullable =  ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { {
0.52220476611095m,
0.877147067004787m, } }));
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

                    nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd2e1mi_id
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
    decimalnumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                methodParametrName: "decimalnumericmmarrayd2e1mi_id", 
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
                nullable =  ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { {
0.725068143679677m,
0.739453598396116m, } }));
                nullable =  ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { {
0.645763960536887m,
0.764829377438831m, } }));
                nullable = await ((IDecimalMArraynumericMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[,] { {
0.689836880924491m,
0.690365843730578m, } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD2E1M> models = null;

                models =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD2E1M> models = null;

                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M), typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                ((IDecimalMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
LEFT JOIN public.decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M), typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                ((IDecimalMArraynumericMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
LEFT JOIN public.decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalMArraynumericMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M), typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
LEFT JOIN public.decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await((IDecimalMArraynumericMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M), typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 44, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 78, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 33, query1, 44, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 25, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 109, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 78, query1, 33, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 51, query1, 78, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
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
FROM public.decimalnumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD2E1M>();
                 ((IDecimalMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDecimalnumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.decimalnumericmmarrayd2e1m m
LEFT JOIN public.decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await((IDecimalMArraynumericMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 52, 97))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 93, 111))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((IDecimalMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models =  ((IDecimalMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                DecimalnumericMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                DecimalnumericMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.binary_decimalnumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD2E1MI),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericMMArrayD2E1M),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
FROM public.binary_decimalnumericmmarrayd2e1m m
LEFT JOIN public.binary_decimalnumericmmarrayd2e1mi mi ON mi.id = m.decimalnumericmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models =  ((IDecimalMArraynumericMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalMArraynumericMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA), typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                ((IDecimalMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
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
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
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
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA), typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                ((IDecimalMArraynumericMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
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
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd2e1mi
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
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MI), typeof(DecimalnumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models1 = new List<DecimalnumericMMArrayD2E1MI>();
                var models2 = new List<DecimalnumericMMArrayD2E1MI>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD2E1MI>();
                var models2 = new List<DecimalnumericMMArrayD2E1MI>();
                ((IDecimalMArraynumericMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2)),
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA), typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD2E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD2E1MIWA>();
                ((IDecimalMArraynumericMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD2))]
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
                var models = await ((IDecimalMArraynumericMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

