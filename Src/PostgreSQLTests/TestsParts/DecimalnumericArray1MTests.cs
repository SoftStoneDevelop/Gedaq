

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
    Id = 5,
    Value = 
new System.Decimal[3]
{
0.614324231899932m,
0.970099678658654m,
0.447886040299092m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.71053916766369m,
0.148289278771081m,
0.498437448236174m,
},
},
            new DecimalnumericArray1M
{
    Id = 11,
    Value = 
new System.Decimal[3]
{
0.345645896259575m,
0.739949437698347m,
0.106220243855462m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 9,
    Value = 
new System.Decimal[4]
{
0.447293826239477m,
0.986860429426886m,
0.377145756862969m,
0.331787116211992m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.311993051991608m,
0.843563724169568m,
0.193501718515617m,
},
},
            new DecimalnumericArray1M
{
    Id = 17,
    Value = 
new System.Decimal[3]
{
0.172144383489319m,
0.271837010739549m,
0.588335918238126m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 20,
    Value = 
new System.Decimal[3]
{
0.460048999124576m,
0.654460778793704m,
0.674059517888424m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 11,
    Value = 
new System.Decimal[4]
{
0.0329434456190564m,
0.546222525498356m,
0.972777879530529m,
0.792861512139696m,
},
    NullableValue = 
new System.Decimal[4]
{
0.690684357121714m,
0.875879682300684m,
0.980725042534128m,
0.931152805313368m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 28,
    Value = 
new System.Decimal[3]
{
0.501147639470255m,
0.674565679901667m,
0.212516970972771m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 36,
    Value = 
new System.Decimal[4]
{
0.640215632708985m,
0.591075695656279m,
0.0254236293954924m,
0.0387943215810946m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 12,
    Value = 
new System.Decimal[4]
{
0.479179158044941m,
0.00733080006973108m,
0.624820365780555m,
0.409314731792833m,
},
    NullableValue = 
new System.Decimal[3]
{
0.131220118816886m,
0.0185981068068194m,
0.13958460448059m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 37,
    Value = 
new System.Decimal[3]
{
0.743355076224164m,
0.146774146867568m,
0.570494639695378m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 44,
    Value = 
new System.Decimal[4]
{
0.209110924602724m,
0.83661260042599m,
0.449326784825407m,
0.0804226127994m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 16,
    Value = 
new System.Decimal[3]
{
0.835334204413992m,
0.573689310237258m,
0.177634611018336m,
},
    NullableValue = 
new System.Decimal[3]
{
0.939371262409337m,
0.680055242528557m,
0.130264047633273m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.339539675231109m,
0.865178723796579m,
0.3207397321051m,
0.779835743683345m,
},
},
            new DecimalnumericArray1M
{
    Id = 49,
    Value = 
new System.Decimal[3]
{
0.479840477833864m,
0.783324464628843m,
0.817033124845332m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.322714261168346m,
0.219236319308864m,
0.48702691537341m,
},
},
            new DecimalnumericArray1M
{
    Id = 52,
    Value = 
new System.Decimal[3]
{
0.934827335519466m,
0.727659991917723m,
0.658397928315432m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 24,
    Value = 
new System.Decimal[4]
{
0.990929326762384m,
0.244409716125492m,
0.328491379824892m,
0.152781098821731m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.254679589693698m,
0.721732137012628m,
0.527478915507923m,
},
},
            new DecimalnumericArray1M
{
    Id = 56,
    Value = 
new System.Decimal[4]
{
0.134501456177429m,
0.255318411092501m,
0.0568579242554437m,
0.278757775905608m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 65,
    Value = 
new System.Decimal[4]
{
0.474129306107175m,
0.164684190082053m,
0.17256244576655m,
0.396830968223771m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 25,
    Value = 
new System.Decimal[3]
{
0.0888524198710545m,
0.825174053355433m,
0.998283410024041m,
},
    NullableValue = 
new System.Decimal[3]
{
0.0038203037791259m,
0.182139708039834m,
0.212356387441881m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.716600659949287m,
0.335291512376579m,
0.969670808639367m,
0.38365397710714m,
},
},
            new DecimalnumericArray1M
{
    Id = 66,
    Value = 
new System.Decimal[4]
{
0.422779314957767m,
0.0743683924760727m,
0.484575252390859m,
0.710867371997851m,
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
0.221673035019983m,
0.550451517054714m,
0.018434384725638m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 31,
    Value = 
new System.Decimal[4]
{
0.268266025258654m,
0.949386367035019m,
0.0422902546783914m,
0.543203430085978m,
},
    NullableValue = 
new System.Decimal[4]
{
0.279064082390596m,
0.153487659825291m,
0.857086494902734m,
0.870613843926158m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.378543477601207m,
0.677037753578792m,
0.665083887991077m,
0.285496701244927m,
},
},
            new DecimalnumericArray1M
{
    Id = 76,
    Value = 
new System.Decimal[3]
{
0.97336911992486m,
0.0483268865231098m,
0.301484676921773m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.730561010949879m,
0.513651661505814m,
0.898276248556462m,
0.548171637027945m,
},
},
            new DecimalnumericArray1M
{
    Id = 85,
    Value = 
new System.Decimal[3]
{
0.729588449110231m,
0.991103814223696m,
0.701465204608291m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 38,
    Value = 
new System.Decimal[3]
{
0.935069103227176m,
0.255386664903216m,
0.724297598231123m,
},
    NullableValue = 
new System.Decimal[4]
{
0.775062256062999m,
0.434835262070583m,
0.710323207936738m,
0.169022744847716m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 93,
    Value = 
new System.Decimal[3]
{
0.200675136944954m,
0.972830927639266m,
0.511617669914653m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 99,
    Value = 
new System.Decimal[4]
{
0.60031016363142m,
0.569361890452172m,
0.539225086630413m,
0.180968309108965m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 44,
    Value = 
new System.Decimal[4]
{
0.0834009942699759m,
0.208848173161469m,
0.425823005814795m,
0.576533263262294m,
},
    NullableValue = 
new System.Decimal[4]
{
0.900654664202178m,
0.0522548376349998m,
0.426372344939032m,
0.721171974701759m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.75238180831474m,
0.117070487109416m,
0.750147219674571m,
},
},
            new DecimalnumericArray1M
{
    Id = 100,
    Value = 
new System.Decimal[3]
{
0.511677151816434m,
0.891681562695582m,
0.229902449468876m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.955666208888515m,
0.826115531768496m,
0.338807852292054m,
},
},
            new DecimalnumericArray1M
{
    Id = 108,
    Value = 
new System.Decimal[4]
{
0.0634932774576705m,
0.821664926033788m,
0.44115276128295m,
0.922512990919832m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 48,
    Value = 
new System.Decimal[4]
{
0.722818615682553m,
0.135847535894134m,
0.484788803951909m,
0.149657118803628m,
},
    NullableValue = 
new System.Decimal[3]
{
0.493570580521132m,
0.633385258529259m,
0.493396875264952m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 110,
    Value = 
new System.Decimal[3]
{
0.630576886847722m,
0.156395493287057m,
0.829769028783414m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.299478734019958m,
0.379004418295671m,
0.396955101154519m,
0.800024082238531m,
},
},
            new DecimalnumericArray1M
{
    Id = 112,
    Value = 
new System.Decimal[3]
{
0.521562312189812m,
0.526346397114416m,
0.00843062488211432m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 53,
    Value = 
new System.Decimal[3]
{
0.707707526370899m,
0.804065914896385m,
0.753302880192108m,
},
    NullableValue = 
new System.Decimal[3]
{
0.34787919025381m,
0.413894958035752m,
0.145213629153011m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 120,
    Value = 
new System.Decimal[3]
{
0.81299898294126m,
0.611376503765935m,
0.533531979032877m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.170665415069994m,
0.74355788919351m,
0.910290912041024m,
},
},
            new DecimalnumericArray1M
{
    Id = 122,
    Value = 
new System.Decimal[3]
{
0.422646524398922m,
0.950446292010884m,
0.101129495560723m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 59,
    Value = 
new System.Decimal[3]
{
0.204269416521585m,
0.959465150117984m,
0.0770108621285906m,
},
    NullableValue = 
new System.Decimal[3]
{
0.61533881134125m,
0.348738845999708m,
0.228120000437986m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 131,
    Value = 
new System.Decimal[3]
{
0.484967112579778m,
0.658856092219505m,
0.158896499111004m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.109699086543196m,
0.806280554081002m,
0.0395598346455687m,
0.73757878512109m,
},
},
            new DecimalnumericArray1M
{
    Id = 133,
    Value = 
new System.Decimal[4]
{
0.674207102088154m,
0.418459553630414m,
0.077174525595426m,
0.074130970687778m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 65,
    Value = 
new System.Decimal[3]
{
0.507142707476384m,
0.759872145243236m,
0.203342156021895m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.690471466139504m,
0.6447085612002m,
0.652469003623014m,
0.341537078083626m,
},
},
            new DecimalnumericArray1M
{
    Id = 139,
    Value = 
new System.Decimal[3]
{
0.721028811816358m,
0.803354867649683m,
0.0641392261165516m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 142,
    Value = 
new System.Decimal[3]
{
0.083065934062148m,
0.903133439662009m,
0.609766785573389m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 69,
    Value = 
new System.Decimal[4]
{
0.983122957008528m,
0.306657935321235m,
0.477673525930309m,
0.401433334249319m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 144,
    Value = 
new System.Decimal[4]
{
0.916047486853098m,
0.727397797436292m,
0.230733747309564m,
0.693572637717339m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.480326303382062m,
0.663404919846704m,
0.624919511716144m,
0.996149670353656m,
},
},
            new DecimalnumericArray1M
{
    Id = 148,
    Value = 
new System.Decimal[3]
{
0.286199461528157m,
0.493603657814223m,
0.485446471904559m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 74,
    Value = 
new System.Decimal[4]
{
0.658219296416156m,
0.919743126091942m,
0.576672691502453m,
0.683137644233173m,
},
    NullableValue = 
new System.Decimal[4]
{
0.635291339643412m,
0.496697314520912m,
0.923264257439316m,
0.614709161351717m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.51370593662459m,
0.64619616583153m,
0.461618092633717m,
0.499427136368886m,
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.339539675231109m,
0.865178723796579m,
0.3207397321051m,
0.779835743683345m,
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.322714261168346m,
0.219236319308864m,
0.48702691537341m,
}));
                nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.254679589693698m,
0.721732137012628m,
0.527478915507923m,
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
0.716600659949287m,
0.335291512376579m,
0.969670808639367m,
0.38365397710714m,
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[29], false);
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
                parametr1.Value = 66;
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[29], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[29], false);
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
                parametr2.Value = 49;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 17, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 28, query1, 85, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[29], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 17, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[29], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 52, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 36, query1, 110, query2))
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[29], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 49, query1, 108, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 99, query1, 112, query2))
                {
                    if(++resultIndex == 1)
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
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 131, query1, 112, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[29], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 93, 20))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[29], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 99, 5))
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[1], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[2], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[3], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[4], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[5], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[6], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[26],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[27],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[28],_testData[29], false);
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
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
DecimalnumericArray1M.AssertModel(models[0],_testData[15], false);DecimalnumericArray1M.AssertModel(models[1],_testData[16], false);DecimalnumericArray1M.AssertModel(models[2],_testData[17], false);DecimalnumericArray1M.AssertModel(models[3],_testData[18], false);DecimalnumericArray1M.AssertModel(models[4],_testData[19], false);DecimalnumericArray1M.AssertModel(models[5],_testData[20], false);DecimalnumericArray1M.AssertModel(models[6],_testData[21], false);DecimalnumericArray1M.AssertModel(models[7],_testData[22], false);DecimalnumericArray1M.AssertModel(models[8],_testData[23], false);DecimalnumericArray1M.AssertModel(models[9],_testData[24], false);DecimalnumericArray1M.AssertModel(models[10],_testData[25], false);DecimalnumericArray1M.AssertModel(models[11],_testData[26], false);DecimalnumericArray1M.AssertModel(models[12],_testData[27], false);DecimalnumericArray1M.AssertModel(models[13],_testData[28], false);DecimalnumericArray1M.AssertModel(models[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
DecimalnumericArray1M.AssertModel(models[0],_testData[21], false);DecimalnumericArray1M.AssertModel(models[1],_testData[22], false);DecimalnumericArray1M.AssertModel(models[2],_testData[23], false);DecimalnumericArray1M.AssertModel(models[3],_testData[24], false);DecimalnumericArray1M.AssertModel(models[4],_testData[25], false);DecimalnumericArray1M.AssertModel(models[5],_testData[26], false);DecimalnumericArray1M.AssertModel(models[6],_testData[27], false);DecimalnumericArray1M.AssertModel(models[7],_testData[28], false);DecimalnumericArray1M.AssertModel(models[8],_testData[29], false);
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

#endregion

    }
}

