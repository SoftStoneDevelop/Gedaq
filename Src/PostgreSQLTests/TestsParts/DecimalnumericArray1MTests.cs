

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
    internal partial interface IDecimalArraynumericArray
    {
    }
    
    internal partial class DecimalArraynumericArray : IDecimalArraynumericArray
    {


#region TestData

        private readonly DecimalnumericArray1M[] _testData = new DecimalnumericArray1M[]
        {
            new DecimalnumericArray1M
{
    Id = 6,
    Value = 
new System.Decimal[4]
{
0.678722480811479m,
0.0581271683531008m,
0.265265280648088m,
0.714172983672377m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.210441474381597m,
0.202184893806648m,
0.544305360490307m,
},
},
            new DecimalnumericArray1M
{
    Id = 14,
    Value = 
new System.Decimal[3]
{
0.984593779778525m,
0.542408291183191m,
0.616012951600873m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 3,
    Value = 
new System.Decimal[3]
{
0.37781833144388m,
0.490543260309044m,
0.752432236050701m,
},
    NullableValue = 
new System.Decimal[4]
{
0.349708972599391m,
0.23214018551146m,
0.902893419075791m,
0.38822586785795m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 16,
    Value = 
new System.Decimal[4]
{
0.551566447499976m,
0.453176956581667m,
0.170408275581102m,
0.780186594750829m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 23,
    Value = 
new System.Decimal[4]
{
0.121923517162109m,
0.737293413095558m,
0.990027402617181m,
0.55836102468633m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 6,
    Value = 
new System.Decimal[3]
{
0.627647248036419m,
0.0235678506507258m,
0.326187504045181m,
},
    NullableValue = 
new System.Decimal[4]
{
0.519180949094256m,
0.139077659390273m,
0.188260787463906m,
0.00963254197657304m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 24,
    Value = 
new System.Decimal[3]
{
0.919211342884917m,
0.862764977360578m,
0.973907802898185m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.518979103633519m,
0.1380591234996m,
0.819349402834564m,
0.474419321337972m,
},
},
            new DecimalnumericArray1M
{
    Id = 31,
    Value = 
new System.Decimal[3]
{
0.338651785421882m,
0.210340626703211m,
0.567646594863748m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 12,
    Value = 
new System.Decimal[3]
{
0.615319088977844m,
0.109283169982882m,
0.398563082933864m,
},
    NullableValue = 
new System.Decimal[4]
{
0.256984269488613m,
0.660082854290331m,
0.740957721188869m,
0.932449376156806m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.968603643555045m,
0.835645248568408m,
0.910385875295723m,
},
},
            new DecimalnumericArray1M
{
    Id = 36,
    Value = 
new System.Decimal[4]
{
0.622539570116715m,
0.266202799152556m,
0.319200560892953m,
0.468592579107731m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 38,
    Value = 
new System.Decimal[3]
{
0.636338493779238m,
0.593713275277709m,
0.337483211669968m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 21,
    Value = 
new System.Decimal[4]
{
0.765026019438064m,
0.214131813950454m,
0.693604110130589m,
0.197646236218818m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 44,
    Value = 
new System.Decimal[4]
{
0.186643861310903m,
0.791387978829568m,
0.572284959932597m,
0.544285568148722m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 51,
    Value = 
new System.Decimal[4]
{
0.315569394967437m,
0.198523772812417m,
0.437988353587331m,
0.372635833568636m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 27,
    Value = 
new System.Decimal[3]
{
0.204705031017924m,
0.629742408782858m,
0.220608089317378m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.175514712908982m,
0.975317266616063m,
0.141275357446345m,
0.690472748337037m,
},
},
            new DecimalnumericArray1M
{
    Id = 60,
    Value = 
new System.Decimal[4]
{
0.510095349775953m,
0.103808018404408m,
0.00528487244215936m,
0.0000276481944461171m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 67,
    Value = 
new System.Decimal[3]
{
0.523128235141436m,
0.859756840804333m,
0.554144064806654m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 29,
    Value = 
new System.Decimal[3]
{
0.696820612824372m,
0.0506219299537167m,
0.764819911434087m,
},
    NullableValue = 
new System.Decimal[4]
{
0.266866770082567m,
0.568400389096122m,
0.985288324975045m,
0.626867028806181m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 72,
    Value = 
new System.Decimal[3]
{
0.0471030995728906m,
0.22484989836499m,
0.66431262260849m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 79,
    Value = 
new System.Decimal[4]
{
0.386271926281742m,
0.406456968569751m,
0.996643270786138m,
0.499248696586668m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 33,
    Value = 
new System.Decimal[4]
{
0.135243399121887m,
0.195879445774112m,
0.745635671562192m,
0.63916246496172m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.556161305080164m,
0.112330280112779m,
0.433495845168109m,
0.726456856028371m,
},
},
            new DecimalnumericArray1M
{
    Id = 86,
    Value = 
new System.Decimal[4]
{
0.675911791477841m,
0.226209754376863m,
0.01525835916312m,
0.518302564912372m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 89,
    Value = 
new System.Decimal[3]
{
0.388391194488243m,
0.597819845660122m,
0.272441284200319m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 37,
    Value = 
new System.Decimal[3]
{
0.971351113394146m,
0.146209901964053m,
0.999156888789412m,
},
    NullableValue = 
new System.Decimal[4]
{
0.166242304534268m,
0.323690058787269m,
0.194157312036383m,
0.255181817539543m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.0939177086178241m,
0.694366039581355m,
0.495300046099266m,
},
},
            new DecimalnumericArray1M
{
    Id = 97,
    Value = 
new System.Decimal[3]
{
0.639066103082691m,
0.708907775192468m,
0.925948818137773m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 101,
    Value = 
new System.Decimal[4]
{
0.412689546969051m,
0.708849131312772m,
0.489161456506807m,
0.236008768679347m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 41,
    Value = 
new System.Decimal[4]
{
0.760244062246409m,
0.0781666589212178m,
0.187277323503899m,
0.877663605638438m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 109,
    Value = 
new System.Decimal[3]
{
0.757521704045865m,
0.0487209541802613m,
0.0556473260934398m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 110,
    Value = 
new System.Decimal[3]
{
0.902813974520945m,
0.953498782160564m,
0.34648500108666m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 44,
    Value = 
new System.Decimal[4]
{
0.201203948604696m,
0.810247009166223m,
0.0736897563873329m,
0.843491991100162m,
},
    NullableValue = 
new System.Decimal[3]
{
0.305562046037664m,
0.411509493158029m,
0.30696961980695m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.986891036502417m,
0.313395353574465m,
0.147093441653867m,
0.189424276645284m,
},
},
            new DecimalnumericArray1M
{
    Id = 119,
    Value = 
new System.Decimal[3]
{
0.262453740003021m,
0.762283752465368m,
0.0923343875463519m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.978852418146m,
0.118832133714829m,
0.669917715896959m,
0.146367154041307m,
},
},
            new DecimalnumericArray1M
{
    Id = 121,
    Value = 
new System.Decimal[4]
{
0.80210915066071m,
0.311761520132151m,
0.520919710319467m,
0.345469594698563m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 53,
    Value = 
new System.Decimal[3]
{
0.339393735725826m,
0.388705156022244m,
0.807199835684162m,
},
    NullableValue = 
new System.Decimal[4]
{
0.659484701560568m,
0.775137333743572m,
0.161569567024674m,
0.757389029483267m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 128,
    Value = 
new System.Decimal[4]
{
0.353419436220186m,
0.0746172378219164m,
0.150511994039874m,
0.575829585096046m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 133,
    Value = 
new System.Decimal[3]
{
0.550196705017571m,
0.88225698418933m,
0.575766162192075m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 58,
    Value = 
new System.Decimal[4]
{
0.573735426542032m,
0.0258851378285716m,
0.684859183016083m,
0.820373969956187m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.482728411648438m,
0.145974594803792m,
0.390778627723067m,
0.544195248970529m,
},
},
            new DecimalnumericArray1M
{
    Id = 135,
    Value = 
new System.Decimal[4]
{
0.759939836831039m,
0.127444885889773m,
0.0953898225209196m,
0.313479262522462m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 141,
    Value = 
new System.Decimal[4]
{
0.35510295446963m,
0.0625966600380765m,
0.920216359930745m,
0.0700812225296125m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 64,
    Value = 
new System.Decimal[4]
{
0.390324903482953m,
0.208767815707732m,
0.351712498614519m,
0.0116825693572201m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 143,
    Value = 
new System.Decimal[4]
{
0.17578555587773m,
0.357512494708706m,
0.643890557667721m,
0.0120415752708066m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.505555274413501m,
0.69171960635086m,
0.725568212239422m,
0.243043810694631m,
},
},
            new DecimalnumericArray1M
{
    Id = 150,
    Value = 
new System.Decimal[3]
{
0.232257004869074m,
0.936053279901642m,
0.192100947044286m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 66,
    Value = 
new System.Decimal[4]
{
0.137904521366606m,
0.98852388104019m,
0.945785125519974m,
0.918136548898443m,
},
    NullableValue = 
new System.Decimal[4]
{
0.219832817957319m,
0.0422364043874397m,
0.329869517495002m,
0.135878163401402m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 155,
    Value = 
new System.Decimal[4]
{
0.437238421476732m,
0.39511393312973m,
0.53777694174973m,
0.729345033168725m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 159,
    Value = 
new System.Decimal[4]
{
0.413299050490919m,
0.984422055031194m,
0.752918563966106m,
0.536583193400943m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 72,
    Value = 
new System.Decimal[4]
{
0.843733419726179m,
0.344727212436656m,
0.115306904352106m,
0.218210452495756m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.950638212383032m,
0.670160794723104m,
0.00828290837798884m,
0.778724938879867m,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1mi(
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1mi(
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
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
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

                changedRows =  ((IDecimalArraynumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalArraynumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalArraynumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalArraynumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalArraynumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalArraynumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
            asPartInterface: typeof(IDecimalArraynumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray1mi_id", 
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
                changedRows =  ((IDecimalArraynumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalArraynumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalArraynumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalArraynumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.518979103633519m,
0.1380591234996m,
0.819349402834564m,
0.474419321337972m,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.968603643555045m,
0.835645248568408m,
0.910385875295723m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray1mi_id", 
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
                System.Decimal[] nullable = null;
                nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.175514712908982m,
0.975317266616063m,
0.141275357446345m,
0.690472748337037m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray1M> models = null;

                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray1M> models = null;

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await((IDecimalArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[29], false);
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
                var models = ((IDecimalArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[4], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[5], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[6], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 150, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 79, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[29], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 24, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[29], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 60, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 6, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[29], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 150, query1, 6, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 67, query1, 44, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[29], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 110, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await((IDecimalArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 79, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[29], false);
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
                var models = ((IDecimalArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 38, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[29], false);
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
                await using var cmd = await ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 14);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
DecimalnumericArray1M.AssertModel(models[0],_testData[2], false);DecimalnumericArray1M.AssertModel(models[1],_testData[3], false);DecimalnumericArray1M.AssertModel(models[2],_testData[4], false);DecimalnumericArray1M.AssertModel(models[3],_testData[5], false);DecimalnumericArray1M.AssertModel(models[4],_testData[6], false);DecimalnumericArray1M.AssertModel(models[5],_testData[7], false);DecimalnumericArray1M.AssertModel(models[6],_testData[8], false);DecimalnumericArray1M.AssertModel(models[7],_testData[9], false);DecimalnumericArray1M.AssertModel(models[8],_testData[10], false);DecimalnumericArray1M.AssertModel(models[9],_testData[11], false);DecimalnumericArray1M.AssertModel(models[10],_testData[12], false);DecimalnumericArray1M.AssertModel(models[11],_testData[13], false);DecimalnumericArray1M.AssertModel(models[12],_testData[14], false);DecimalnumericArray1M.AssertModel(models[13],_testData[15], false);DecimalnumericArray1M.AssertModel(models[14],_testData[16], false);DecimalnumericArray1M.AssertModel(models[15],_testData[17], false);DecimalnumericArray1M.AssertModel(models[16],_testData[18], false);DecimalnumericArray1M.AssertModel(models[17],_testData[19], false);DecimalnumericArray1M.AssertModel(models[18],_testData[20], false);DecimalnumericArray1M.AssertModel(models[19],_testData[21], false);DecimalnumericArray1M.AssertModel(models[20],_testData[22], false);DecimalnumericArray1M.AssertModel(models[21],_testData[23], false);DecimalnumericArray1M.AssertModel(models[22],_testData[24], false);DecimalnumericArray1M.AssertModel(models[23],_testData[25], false);DecimalnumericArray1M.AssertModel(models[24],_testData[26], false);DecimalnumericArray1M.AssertModel(models[25],_testData[27], false);DecimalnumericArray1M.AssertModel(models[26],_testData[28], false);DecimalnumericArray1M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
DecimalnumericArray1M.AssertModel(models[0],_testData[14], false);DecimalnumericArray1M.AssertModel(models[1],_testData[15], false);DecimalnumericArray1M.AssertModel(models[2],_testData[16], false);DecimalnumericArray1M.AssertModel(models[3],_testData[17], false);DecimalnumericArray1M.AssertModel(models[4],_testData[18], false);DecimalnumericArray1M.AssertModel(models[5],_testData[19], false);DecimalnumericArray1M.AssertModel(models[6],_testData[20], false);DecimalnumericArray1M.AssertModel(models[7],_testData[21], false);DecimalnumericArray1M.AssertModel(models[8],_testData[22], false);DecimalnumericArray1M.AssertModel(models[9],_testData[23], false);DecimalnumericArray1M.AssertModel(models[10],_testData[24], false);DecimalnumericArray1M.AssertModel(models[11],_testData[25], false);DecimalnumericArray1M.AssertModel(models[12],_testData[26], false);DecimalnumericArray1M.AssertModel(models[13],_testData[27], false);DecimalnumericArray1M.AssertModel(models[14],_testData[28], false);DecimalnumericArray1M.AssertModel(models[15],_testData[29], false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MIWA),
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
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MI),
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
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericArray1M),
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
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
FROM public.binary_decimalnumericarray1m m
LEFT JOIN public.binary_decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray1M>(15);

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
                ((IDecimalArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DecimalnumericArray1M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray1M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray1M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray1M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray1M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray1M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray1M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray1M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IDecimalArraynumericArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDecimalArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DecimalnumericArray1M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray1M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray1M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray1M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray1M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray1M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray1M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray1M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray1M.AssertModel(models[14],_testData[14], false);
                DecimalnumericArray1M.AssertModel(models[15],_testData[15], false);
                DecimalnumericArray1M.AssertModel(models[16],_testData[16], false);
                DecimalnumericArray1M.AssertModel(models[17],_testData[17], false);
                DecimalnumericArray1M.AssertModel(models[18],_testData[18], false);
                DecimalnumericArray1M.AssertModel(models[19],_testData[19], false);
                DecimalnumericArray1M.AssertModel(models[20],_testData[20], false);
                DecimalnumericArray1M.AssertModel(models[21],_testData[21], false);
                DecimalnumericArray1M.AssertModel(models[22],_testData[22], false);
                DecimalnumericArray1M.AssertModel(models[23],_testData[23], false);
                DecimalnumericArray1M.AssertModel(models[24],_testData[24], false);
                DecimalnumericArray1M.AssertModel(models[25],_testData[25], false);
                DecimalnumericArray1M.AssertModel(models[26],_testData[26], false);
                DecimalnumericArray1M.AssertModel(models[27],_testData[27], false);
                DecimalnumericArray1M.AssertModel(models[28],_testData[28], false);
                DecimalnumericArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
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
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalArraynumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraynumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
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
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraynumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDecimalArraynumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
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
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IDecimalArraynumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

