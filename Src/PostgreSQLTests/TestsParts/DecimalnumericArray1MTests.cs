

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
    Id = 9,
    Value = 
new System.Decimal[3]
{
0.725496758385668m,
0.140130651499917m,
0.205302719350287m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 13,
    Value = 
new System.Decimal[4]
{
0.980100376790947m,
0.656790328525856m,
0.056586129489474m,
0.991391866149007m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 1,
    Value = 
new System.Decimal[4]
{
0.219914299841265m,
0.607393153187708m,
0.812440278874442m,
0.72253275385448m,
},
    NullableValue = 
new System.Decimal[4]
{
0.0934845053009994m,
0.342018029298767m,
0.479144925457429m,
0.542341182011394m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 15,
    Value = 
new System.Decimal[4]
{
0.77156907470728m,
0.268939945487223m,
0.0390829298348425m,
0.618590049592296m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 24,
    Value = 
new System.Decimal[4]
{
0.0928724474295135m,
0.778610806258776m,
0.29328870187301m,
0.121861079279487m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 5,
    Value = 
new System.Decimal[3]
{
0.516979095224401m,
0.500035965876928m,
0.89628089661635m,
},
    NullableValue = 
new System.Decimal[4]
{
0.29284579273977m,
0.478864174899346m,
0.933927919713332m,
0.796780231741549m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 25,
    Value = 
new System.Decimal[3]
{
0.695085939044425m,
0.84067341458301m,
0.0898654022567188m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 30,
    Value = 
new System.Decimal[4]
{
0.165159983896079m,
0.408615227545949m,
0.095868742560297m,
0.691601567644287m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 11,
    Value = 
new System.Decimal[4]
{
0.700948426678279m,
0.192837032897629m,
0.91824732592757m,
0.657785011576031m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.0339627555800744m,
0.521471626133004m,
0.00185821754109883m,
0.390403051047467m,
},
},
            new DecimalnumericArray1M
{
    Id = 33,
    Value = 
new System.Decimal[4]
{
0.026299750312493m,
0.533834568819979m,
0.875778347830446m,
0.179730821673074m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.301100545998625m,
0.236830932742686m,
0.866140048699426m,
0.0241447724311106m,
},
},
            new DecimalnumericArray1M
{
    Id = 38,
    Value = 
new System.Decimal[3]
{
0.653719250417203m,
0.774928885933774m,
0.74177343431646m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 13,
    Value = 
new System.Decimal[4]
{
0.859264399013726m,
0.783885063091944m,
0.823711288555547m,
0.68556322533562m,
},
    NullableValue = 
new System.Decimal[3]
{
0.263071243184494m,
0.907476222321489m,
0.701470109174006m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 47,
    Value = 
new System.Decimal[4]
{
0.536725424379651m,
0.0400714655692697m,
0.879439040782868m,
0.628511892122854m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 53,
    Value = 
new System.Decimal[3]
{
0.689635854912913m,
0.492574196297552m,
0.73260764564219m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 17,
    Value = 
new System.Decimal[4]
{
0.149945462829178m,
0.973058851014378m,
0.784806832898422m,
0.274891249964657m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.983867895088315m,
0.484567903368813m,
0.695263198773556m,
},
},
            new DecimalnumericArray1M
{
    Id = 58,
    Value = 
new System.Decimal[4]
{
0.522979432664928m,
0.867143898710439m,
0.175456645079977m,
0.293891840900243m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 61,
    Value = 
new System.Decimal[4]
{
0.518104247220008m,
0.550458890536028m,
0.732550108058109m,
0.441057883554728m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 20,
    Value = 
new System.Decimal[4]
{
0.277189293411353m,
0.628605094439282m,
0.567935537056123m,
0.517074646358099m,
},
    NullableValue = 
new System.Decimal[4]
{
0.158183891603375m,
0.344701016335666m,
0.533046515721728m,
0.226457180106537m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.717383712345423m,
0.195864874373518m,
0.716585384391028m,
0.275888806213711m,
},
},
            new DecimalnumericArray1M
{
    Id = 70,
    Value = 
new System.Decimal[3]
{
0.589616167596952m,
0.389396832538604m,
0.561206630956766m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.90694035684541m,
0.821835431553232m,
0.491994762489909m,
},
},
            new DecimalnumericArray1M
{
    Id = 78,
    Value = 
new System.Decimal[4]
{
0.840052724746368m,
0.98006409517935m,
0.81526896966015m,
0.199034242531995m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 21,
    Value = 
new System.Decimal[3]
{
0.346341420146478m,
0.378010671470565m,
0.992185884388879m,
},
    NullableValue = 
new System.Decimal[3]
{
0.0253591346595757m,
0.0492855376539606m,
0.587830546042989m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 87,
    Value = 
new System.Decimal[3]
{
0.542587399656807m,
0.865983416488986m,
0.586681586077326m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 93,
    Value = 
new System.Decimal[3]
{
0.00542874318302411m,
0.516667153474437m,
0.283969575877838m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 24,
    Value = 
new System.Decimal[4]
{
0.932038222615106m,
0.451546983649888m,
0.161531945563655m,
0.261093085061037m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.285022218544727m,
0.53560555076993m,
0.525537855088121m,
},
},
            new DecimalnumericArray1M
{
    Id = 96,
    Value = 
new System.Decimal[4]
{
0.293169849478395m,
0.724077527752521m,
0.687900183944351m,
0.585347382289688m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.588084798840696m,
0.905186129969208m,
0.0116722168002985m,
},
},
            new DecimalnumericArray1M
{
    Id = 98,
    Value = 
new System.Decimal[4]
{
0.183794853342026m,
0.788471327666392m,
0.122469827714033m,
0.993604843841295m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 32,
    Value = 
new System.Decimal[3]
{
0.66199215202435m,
0.0655945223343824m,
0.790464004896913m,
},
    NullableValue = 
new System.Decimal[4]
{
0.984622466343433m,
0.0799129577813426m,
0.309520146273574m,
0.29657343937825m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 102,
    Value = 
new System.Decimal[3]
{
0.059966197524494m,
0.689882828560994m,
0.0889659523747116m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 110,
    Value = 
new System.Decimal[4]
{
0.403043285695661m,
0.823186461803604m,
0.32957252841242m,
0.199078949823754m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 40,
    Value = 
new System.Decimal[4]
{
0.135261485665091m,
0.911040983923519m,
0.206832333625418m,
0.878289097740855m,
},
    NullableValue = 
new System.Decimal[4]
{
0.573025956678521m,
0.702033029225701m,
0.703459679424083m,
0.0822861987429441m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 111,
    Value = 
new System.Decimal[3]
{
0.0641443101068349m,
0.42479230218623m,
0.0864084783067694m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.633149375266154m,
0.388477568166629m,
0.946851986178355m,
0.591660671606434m,
},
},
            new DecimalnumericArray1M
{
    Id = 113,
    Value = 
new System.Decimal[3]
{
0.163902829287295m,
0.222904326855378m,
0.789870135262592m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 42,
    Value = 
new System.Decimal[4]
{
0.811088599529966m,
0.109283957991184m,
0.739278464664393m,
0.274054197849894m,
},
    NullableValue = 
new System.Decimal[3]
{
0.305222641431526m,
0.273948471186653m,
0.096373259805254m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.321225809743678m,
0.908566420701207m,
0.709758402031289m,
0.991752858105576m,
},
},
            new DecimalnumericArray1M
{
    Id = 116,
    Value = 
new System.Decimal[3]
{
0.291078669520573m,
0.742111100461806m,
0.572698479672453m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 123,
    Value = 
new System.Decimal[4]
{
0.09370222354603m,
0.258074571204925m,
0.199886471718673m,
0.625238550200233m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 49,
    Value = 
new System.Decimal[4]
{
0.752445426954685m,
0.402494873280249m,
0.590004279764769m,
0.551927414921158m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.109807115757701m,
0.306996210605311m,
0.687345180202521m,
0.697539122323856m,
},
},
            new DecimalnumericArray1M
{
    Id = 127,
    Value = 
new System.Decimal[4]
{
0.310317301244065m,
0.747467781317291m,
0.28023029100831m,
0.123501628519351m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 136,
    Value = 
new System.Decimal[3]
{
0.165122539283641m,
0.570567586881668m,
0.573073596847042m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 55,
    Value = 
new System.Decimal[4]
{
0.352779537334601m,
0.626715150857734m,
0.519186456164856m,
0.22219838674542m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.926617438008304m,
0.284447800156581m,
0.531057888734084m,
0.797077769430839m,
},
},
            new DecimalnumericArray1M
{
    Id = 140,
    Value = 
new System.Decimal[3]
{
0.0474213827701697m,
0.958662968095518m,
0.504474743066685m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 145,
    Value = 
new System.Decimal[4]
{
0.938701019637618m,
0.415747315182105m,
0.965841033947077m,
0.249388855574738m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 59,
    Value = 
new System.Decimal[3]
{
0.964145073104539m,
0.999623152089318m,
0.828430584813032m,
},
    NullableValue = 
new System.Decimal[3]
{
0.762362121478516m,
0.188813851427692m,
0.998403862730086m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 147,
    Value = 
new System.Decimal[3]
{
0.393283860028158m,
0.0918216899633215m,
0.0994636607701128m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 156,
    Value = 
new System.Decimal[3]
{
0.202272847663436m,
0.0114862294897383m,
0.913127933647659m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 67,
    Value = 
new System.Decimal[4]
{
0.613149564454661m,
0.65466254823221m,
0.00303152268620055m,
0.544393555045489m,
},
    NullableValue = 
new System.Decimal[4]
{
0.174022552054094m,
0.0278111726647823m,
0.950633623174432m,
0.202786954495888m,
},
},
    NullableValue = null,
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
                Assert.That(nullable, Is.Null);
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
new System.Decimal[4]
{
0.0339627555800744m,
0.521471626133004m,
0.00185821754109883m,
0.390403051047467m,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.301100545998625m,
0.236830932742686m,
0.866140048699426m,
0.0241447724311106m,
}));
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
new System.Decimal[3]
{
0.983867895088315m,
0.484567903368813m,
0.695263198773556m,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.717383712345423m,
0.195864874373518m,
0.716585384391028m,
0.275888806213711m,
}));
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[29], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[29], false);
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
                parametr1.Value = 25;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 61;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[5], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[6], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[2], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[3], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[4], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[5], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[6], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[26],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[2], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[3], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[4], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[5], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[6], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[26],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[6], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[29], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 145, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[29], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 78, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[29], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 70, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[29], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 113, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[29], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 123, query1, 30, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 30, query1, 113, query2))
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[29], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 98, query1, 58, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 58, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[29], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 98, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[29], false);
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
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 53);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
DecimalnumericArray1M.AssertModel(models[0],_testData[10], false);DecimalnumericArray1M.AssertModel(models[1],_testData[11], false);DecimalnumericArray1M.AssertModel(models[2],_testData[12], false);DecimalnumericArray1M.AssertModel(models[3],_testData[13], false);DecimalnumericArray1M.AssertModel(models[4],_testData[14], false);DecimalnumericArray1M.AssertModel(models[5],_testData[15], false);DecimalnumericArray1M.AssertModel(models[6],_testData[16], false);DecimalnumericArray1M.AssertModel(models[7],_testData[17], false);DecimalnumericArray1M.AssertModel(models[8],_testData[18], false);DecimalnumericArray1M.AssertModel(models[9],_testData[19], false);DecimalnumericArray1M.AssertModel(models[10],_testData[20], false);DecimalnumericArray1M.AssertModel(models[11],_testData[21], false);DecimalnumericArray1M.AssertModel(models[12],_testData[22], false);DecimalnumericArray1M.AssertModel(models[13],_testData[23], false);DecimalnumericArray1M.AssertModel(models[14],_testData[24], false);DecimalnumericArray1M.AssertModel(models[15],_testData[25], false);DecimalnumericArray1M.AssertModel(models[16],_testData[26], false);DecimalnumericArray1M.AssertModel(models[17],_testData[27], false);DecimalnumericArray1M.AssertModel(models[18],_testData[28], false);DecimalnumericArray1M.AssertModel(models[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 96);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
DecimalnumericArray1M.AssertModel(models[0],_testData[17], false);DecimalnumericArray1M.AssertModel(models[1],_testData[18], false);DecimalnumericArray1M.AssertModel(models[2],_testData[19], false);DecimalnumericArray1M.AssertModel(models[3],_testData[20], false);DecimalnumericArray1M.AssertModel(models[4],_testData[21], false);DecimalnumericArray1M.AssertModel(models[5],_testData[22], false);DecimalnumericArray1M.AssertModel(models[6],_testData[23], false);DecimalnumericArray1M.AssertModel(models[7],_testData[24], false);DecimalnumericArray1M.AssertModel(models[8],_testData[25], false);DecimalnumericArray1M.AssertModel(models[9],_testData[26], false);DecimalnumericArray1M.AssertModel(models[10],_testData[27], false);DecimalnumericArray1M.AssertModel(models[11],_testData[28], false);DecimalnumericArray1M.AssertModel(models[12],_testData[29], false);
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
            query: null,
            methodName:"DynQueryImportModelInner",
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDecimalArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
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
                await ((IDecimalArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((IDecimalArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDecimalArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
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
                await ((IDecimalArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDecimalArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalArraynumericArray)this).ExportModelInner(connection).ToList();
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

        [Test, Order(2)]
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

#endregion

    }
}

