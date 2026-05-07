

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
    internal partial interface INpgsqlLineSingleTypeline
    {
    }
    
    internal partial class NpgsqlLineSingleTypeline : INpgsqlLineSingleTypeline
    {


#region TestData

        private readonly NpgsqlLineline0M[] _testData = new NpgsqlLineline0M[]
        {
            new NpgsqlLineline0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.25289620024304427d, b: 0.5412297583175978d, c: 0.9352094016288186d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.0850553201118952d, b: 0.31486740022023885d, c: 0.9505674237204337d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6006643780222548d, b: 0.9328960252560242d, c: 0.6644469807782444d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.20361392519642485d, b: 0.19982280233855176d, c: 0.47439154697512076d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4762003572590354d, b: 0.9742273307560194d, c: 0.9067393616693141d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.11902072398837737d, b: 0.7431830810458128d, c: 0.7434531921487352d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8400603375115314d, b: 0.28686595137917537d, c: 0.7708452112704814d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4615682093583833d, b: 0.35052026206787323d, c: 0.3789004834108546d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6095071549294975d, b: 0.9179734385181998d, c: 0.6328573049639803d),
},
            new NpgsqlLineline0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.740083260091443d, b: 0.13842874894094848d, c: 0.9746664566420702d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.33934908536142383d, b: 0.32319372436095317d, c: 0.27733556088033207d),
},
            new NpgsqlLineline0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.44360239305018834d, b: 0.6446520595102045d, c: 0.069793004601864d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1033425485748104d, b: 0.7919193253984929d, c: 0.6550189343381998d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7744455624309416d, b: 0.24602845829022857d, c: 0.3797015035115463d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.18242022158986937d, b: 0.6131831810342259d, c: 0.9006945444358355d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4853511941879275d, b: 0.46542709898805945d, c: 0.37495391902428443d),
},
            new NpgsqlLineline0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5460492133245229d, b: 0.961920895857086d, c: 0.8152599926139061d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5314994744070267d, b: 0.8288510464853904d, c: 0.7539283210902729d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6209358638349803d, b: 0.16478461777691322d, c: 0.011868736207908182d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7847391422302157d, b: 0.6618120906567673d, c: 0.23821139633809507d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6880196369964924d, b: 0.5748555076705857d, c: 0.27411636939971473d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1878108561810432d, b: 0.008566352719368675d, c: 0.9484782370087882d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.5387287651414192d, b: 0.5657106552012308d, c: 0.8954568197940018d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6171334794523086d, b: 0.1608861954073365d, c: 0.21719472565520603d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.0745591860685978d, b: 0.8875930349406574d, c: 0.5373389724904158d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.711432653357581d, b: 0.6040910704801116d, c: 0.5485642688339446d),
},
            new NpgsqlLineline0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.266009399767841d, b: 0.5640630554665284d, c: 0.23206342683815673d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.19413957327399345d, b: 0.2945657649650191d, c: 0.27666529145008356d),
},
            new NpgsqlLineline0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3039183724823237d, b: 0.7387688337004792d, c: 0.609522479800577d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7432396271290146d, b: 0.9138173812898805d, c: 0.31763414136234225d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.5050227682173146d, b: 0.275016268075997d, c: 0.07321193021867067d),
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.12668966371736856d, b: 0.292900547242535d, c: 0.6089592618411368d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.44708532857229577d, b: 0.9720062044025501d, c: 0.9209006724211737d),
},
            new NpgsqlLineline0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.44197217495101604d, b: 0.19426368687760476d, c: 0.9124610951512347d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.19079046107745534d, b: 0.10107072097233083d, c: 0.4929204891181137d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.829215079771655d, b: 0.0774721867646001d, c: 0.4825394542524326d),
},
            new NpgsqlLineline0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.23457516743144202d, b: 0.5106388043235565d, c: 0.43314490013619633d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3614920069700458d, b: 0.2009377234645029d, c: 0.31719801781158163d),
},
            new NpgsqlLineline0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.10688678790841422d, b: 0.027403052109701842d, c: 0.523629845098796d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7213792568619652d, b: 0.5979490282065303d, c: 0.9422612556707727d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9324393420938057d, b: 0.0828283851086663d, c: 0.6602113366168892d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.27145665853885337d, b: 0.6910805255284522d, c: 0.046031036212038634d),
},
            new NpgsqlLineline0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7797243803526664d, b: 0.16641970488780067d, c: 0.05615981725462604d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4434250903919057d, b: 0.7706491611956937d, c: 0.890694387121779d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7571627537451394d, b: 0.0067929552501859725d, c: 0.06063509095120512d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1588947891735113d, b: 0.252994502309154d, c: 0.7281205132281954d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.0775408295109693d, b: 0.26203637562158544d, c: 0.5574516404139539d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8945906335596823d, b: 0.5822780016264607d, c: 0.34331901572389634d),
},
            new NpgsqlLineline0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.542586982051713d, b: 0.14867075983194722d, c: 0.16260709026861275d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7905080524681075d, b: 0.6999588908310511d, c: 0.35987348197933866d),
},
            new NpgsqlLineline0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7176021282922553d, b: 0.854855316336119d, c: 0.7390043339977708d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7131402822382878d, b: 0.8194094365061462d, c: 0.6660737764703534d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.24818635673110212d, b: 0.941596931329753d, c: 0.5608093123342696d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.25397410271410203d, b: 0.11558490226088658d, c: 0.7310298829071104d),
},
            new NpgsqlLineline0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.035140967977620674d, b: 0.48410254072878345d, c: 0.7709387334377846d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.572255666593331d, b: 0.018496006269827392d, c: 0.15152620095517555d),
},
            new NpgsqlLineline0M
{
    Id = 129,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.024456026159870414d, b: 0.413299705894168d, c: 0.2632806864562668d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9498918961840292d, b: 0.2821259404448926d, c: 0.025145859757612632d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7521853073630492d, b: 0.19240506877872599d, c: 0.1338702274392657d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.4546370002409842d, b: 0.6231388201683524d, c: 0.6231763411148605d),
},
            new NpgsqlLineline0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.09210471179910251d, b: 0.15613350053835506d, c: 0.7044315042707772d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.1697368655292918d, b: 0.519089612635884d, c: 0.90688348448267d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7169074888411233d, b: 0.005072370234888157d, c: 0.7323842725182083d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.16168208254010163d, b: 0.7949338873998705d, c: 0.4055083962865872d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.7805990398760166d, b: 0.6554284346536067d, c: 0.7061318329380171d),
},
            new NpgsqlLineline0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.7760057259714137d, b: 0.07575210491880169d, c: 0.04722304493532181d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.9401076849773609d, b: 0.8941308567774217d, c: 0.11810386119469374d),
},
            new NpgsqlLineline0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.4628052765753815d, b: 0.3770322373218742d, c: 0.595361083932735d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.28940341152566873d, b: 0.652342859356139d, c: 0.8005172293990623d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.2637686448929444d, b: 0.46289076181805844d, c: 0.22212741841481187d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9019790974635302d, b: 0.23925898781674892d, c: 0.3159112070444734d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.8707574692614644d, b: 0.09987757631623528d, c: 0.9994575053030721d),
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.09232449675731669d, b: 0.02188955801565584d, c: 0.9334412475443509d),
},
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.3074095070619022d, b: 0.9522169543340684d, c: 0.35731915863566344d),
},
            new NpgsqlLineline0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.9957723000999438d, b: 0.48221512730109695d, c: 0.3061132294871727d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.8293891689054781d, b: 0.13274355547554562d, c: 0.1975244230115314d),
},
            new NpgsqlLineline0M
{
    Id = 153,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.13766786633507566d, b: 0.036958879194046834d, c: 0.43699322769212756d),
    ModelInner = new NpgsqlLineline0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.3185500215779038d, b: 0.5636184953498055d, c: 0.6508994544577198d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLineline0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlLine(a: 0.6569304909750561d, b: 0.9652909521926948d, c: 0.8647208089251412d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlLine(a: 0.6816525285464069d, b: 0.5449234855456263d, c: 0.25123299807035915d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
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
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10))]
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

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineSingleTypeline)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
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
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineSingleTypeline)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineSingleTypeline)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.33934908536142383d, b: 0.32319372436095317d, c: 0.27733556088033207d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.4853511941879275d, b: 0.46542709898805945d, c: 0.37495391902428443d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(10);
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

                    nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
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
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(10)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllineline0mi_id", 
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
                NpgsqlTypes.NpgsqlLine? nullable = null;
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine? nullable = null;
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlLineSingleTypeline)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlLine(a: 0.711432653357581d, b: 0.6040910704801116d, c: 0.5485642688339446d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;

                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineSingleTypeline)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLineline0M> models = null;

                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineSingleTypeline)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLineline0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllineline0m(
	id,
    value,
    nullablevalue,
    npgsqllineline0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqllineline0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlLine), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqllineline0mi_id", 
                methodParametrName: "npgsqllineline0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineSingleTypeline)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await ((INpgsqlLineSingleTypeline)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineSingleTypeline)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 99;
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M), typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                await((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 129, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 146, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLineline0M>();
                var models2 = new List<FlatNpgsqlLineline0M>();
                ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLineline0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 57, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var firstItems2 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionMMDynQuerySelectModelBatch(connection, 124, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 117, query1, 99, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                await ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 146, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTDynQuerySelectModelBatch(connection, 107, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlLineline0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlLineline0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlLineline0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlLineline0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlLineline0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlLineline0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlLineline0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlLineline0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlLineline0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlLineline0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlLineline0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlLineline0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlLineline0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqllineline0m m
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
FROM public.npgsqllineline0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems1 = new List<FlatNpgsqlLineline0M>();
                var secondItems2 = new List<FlatNpgsqlLineline0M>();
                 ((INpgsqlLineSingleTypeline)this).DbConnectionDynQuerySelectModelBatch(connection, 78, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlLineline0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
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
                var models = await((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatchAsync(connection, 93, 57))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[34], false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLineline0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineSingleTypeline)this).DbConnectionSTSelectModelBatch(connection, 69, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLineline0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLineline0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLineline0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLineline0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLineline0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLineline0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLineline0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLineline0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLineline0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLineline0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLineline0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLineline0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLineline0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLineline0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLineline0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLineline0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLineline0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLineline0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLineline0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLineline0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLineline0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLineline0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLineline0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLineline0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLineline0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLineline0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLineline0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLineline0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLineline0M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlLineline0M.AssertModel(models[0],_testData[23], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[24], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[25], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[26], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[27], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[28], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[29], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[30], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[31], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[32], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[33], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineSingleTypeline)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineSingleTypeline)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models =  ((INpgsqlLineSingleTypeline)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLineline0M.AssertModel(models[0],_testData[20], false);
                NpgsqlLineline0M.AssertModel(models[1],_testData[21], false);
                NpgsqlLineline0M.AssertModel(models[2],_testData[22], false);
                NpgsqlLineline0M.AssertModel(models[3],_testData[23], false);
                NpgsqlLineline0M.AssertModel(models[4],_testData[24], false);
                NpgsqlLineline0M.AssertModel(models[5],_testData[25], false);
                NpgsqlLineline0M.AssertModel(models[6],_testData[26], false);
                NpgsqlLineline0M.AssertModel(models[7],_testData[27], false);
                NpgsqlLineline0M.AssertModel(models[8],_testData[28], false);
                NpgsqlLineline0M.AssertModel(models[9],_testData[29], false);
                NpgsqlLineline0M.AssertModel(models[10],_testData[30], false);
                NpgsqlLineline0M.AssertModel(models[11],_testData[31], false);
                NpgsqlLineline0M.AssertModel(models[12],_testData[32], false);
                NpgsqlLineline0M.AssertModel(models[13],_testData[33], false);
                NpgsqlLineline0M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqllineline0m m
LEFT JOIN public.npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25289620024304427d, b: 0.5412297583175978d, c: 0.9352094016288186d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0850553201118952d, b: 0.31486740022023885d, c: 0.9505674237204337d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6006643780222548d, b: 0.9328960252560242d, c: 0.6644469807782444d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20361392519642485d, b: 0.19982280233855176d, c: 0.47439154697512076d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4762003572590354d, b: 0.9742273307560194d, c: 0.9067393616693141d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.11902072398837737d, b: 0.7431830810458128d, c: 0.7434531921487352d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8400603375115314d, b: 0.28686595137917537d, c: 0.7708452112704814d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4615682093583833d, b: 0.35052026206787323d, c: 0.3789004834108546d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6095071549294975d, b: 0.9179734385181998d, c: 0.6328573049639803d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.740083260091443d, b: 0.13842874894094848d, c: 0.9746664566420702d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33934908536142383d, b: 0.32319372436095317d, c: 0.27733556088033207d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44360239305018834d, b: 0.6446520595102045d, c: 0.069793004601864d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1033425485748104d, b: 0.7919193253984929d, c: 0.6550189343381998d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7744455624309416d, b: 0.24602845829022857d, c: 0.3797015035115463d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18242022158986937d, b: 0.6131831810342259d, c: 0.9006945444358355d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4853511941879275d, b: 0.46542709898805945d, c: 0.37495391902428443d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5460492133245229d, b: 0.961920895857086d, c: 0.8152599926139061d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5314994744070267d, b: 0.8288510464853904d, c: 0.7539283210902729d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6209358638349803d, b: 0.16478461777691322d, c: 0.011868736207908182d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7847391422302157d, b: 0.6618120906567673d, c: 0.23821139633809507d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6880196369964924d, b: 0.5748555076705857d, c: 0.27411636939971473d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1878108561810432d, b: 0.008566352719368675d, c: 0.9484782370087882d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5387287651414192d, b: 0.5657106552012308d, c: 0.8954568197940018d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6171334794523086d, b: 0.1608861954073365d, c: 0.21719472565520603d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0745591860685978d, b: 0.8875930349406574d, c: 0.5373389724904158d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.711432653357581d, b: 0.6040910704801116d, c: 0.5485642688339446d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.266009399767841d, b: 0.5640630554665284d, c: 0.23206342683815673d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19413957327399345d, b: 0.2945657649650191d, c: 0.27666529145008356d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3039183724823237d, b: 0.7387688337004792d, c: 0.609522479800577d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7432396271290146d, b: 0.9138173812898805d, c: 0.31763414136234225d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5050227682173146d, b: 0.275016268075997d, c: 0.07321193021867067d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12668966371736856d, b: 0.292900547242535d, c: 0.6089592618411368d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44708532857229577d, b: 0.9720062044025501d, c: 0.9209006724211737d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44197217495101604d, b: 0.19426368687760476d, c: 0.9124610951512347d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19079046107745534d, b: 0.10107072097233083d, c: 0.4929204891181137d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.829215079771655d, b: 0.0774721867646001d, c: 0.4825394542524326d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23457516743144202d, b: 0.5106388043235565d, c: 0.43314490013619633d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3614920069700458d, b: 0.2009377234645029d, c: 0.31719801781158163d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10688678790841422d, b: 0.027403052109701842d, c: 0.523629845098796d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7213792568619652d, b: 0.5979490282065303d, c: 0.9422612556707727d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9324393420938057d, b: 0.0828283851086663d, c: 0.6602113366168892d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27145665853885337d, b: 0.6910805255284522d, c: 0.046031036212038634d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7797243803526664d, b: 0.16641970488780067d, c: 0.05615981725462604d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4434250903919057d, b: 0.7706491611956937d, c: 0.890694387121779d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7571627537451394d, b: 0.0067929552501859725d, c: 0.06063509095120512d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1588947891735113d, b: 0.252994502309154d, c: 0.7281205132281954d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0775408295109693d, b: 0.26203637562158544d, c: 0.5574516404139539d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8945906335596823d, b: 0.5822780016264607d, c: 0.34331901572389634d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.542586982051713d, b: 0.14867075983194722d, c: 0.16260709026861275d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7905080524681075d, b: 0.6999588908310511d, c: 0.35987348197933866d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7176021282922553d, b: 0.854855316336119d, c: 0.7390043339977708d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7131402822382878d, b: 0.8194094365061462d, c: 0.6660737764703534d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24818635673110212d, b: 0.941596931329753d, c: 0.5608093123342696d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25397410271410203d, b: 0.11558490226088658d, c: 0.7310298829071104d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.035140967977620674d, b: 0.48410254072878345d, c: 0.7709387334377846d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.572255666593331d, b: 0.018496006269827392d, c: 0.15152620095517555d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.024456026159870414d, b: 0.413299705894168d, c: 0.2632806864562668d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9498918961840292d, b: 0.2821259404448926d, c: 0.025145859757612632d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7521853073630492d, b: 0.19240506877872599d, c: 0.1338702274392657d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4546370002409842d, b: 0.6231388201683524d, c: 0.6231763411148605d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09210471179910251d, b: 0.15613350053835506d, c: 0.7044315042707772d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1697368655292918d, b: 0.519089612635884d, c: 0.90688348448267d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7169074888411233d, b: 0.005072370234888157d, c: 0.7323842725182083d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.16168208254010163d, b: 0.7949338873998705d, c: 0.4055083962865872d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7805990398760166d, b: 0.6554284346536067d, c: 0.7061318329380171d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7760057259714137d, b: 0.07575210491880169d, c: 0.04722304493532181d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9401076849773609d, b: 0.8941308567774217d, c: 0.11810386119469374d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4628052765753815d, b: 0.3770322373218742d, c: 0.595361083932735d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28940341152566873d, b: 0.652342859356139d, c: 0.8005172293990623d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2637686448929444d, b: 0.46289076181805844d, c: 0.22212741841481187d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9019790974635302d, b: 0.23925898781674892d, c: 0.3159112070444734d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8707574692614644d, b: 0.09987757631623528d, c: 0.9994575053030721d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09232449675731669d, b: 0.02188955801565584d, c: 0.9334412475443509d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3074095070619022d, b: 0.9522169543340684d, c: 0.35731915863566344d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9957723000999438d, b: 0.48221512730109695d, c: 0.3061132294871727d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8293891689054781d, b: 0.13274355547554562d, c: 0.1975244230115314d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13766786633507566d, b: 0.036958879194046834d, c: 0.43699322769212756d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3185500215779038d, b: 0.5636184953498055d, c: 0.6508994544577198d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6569304909750561d, b: 0.9652909521926948d, c: 0.8647208089251412d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6816525285464069d, b: 0.5449234855456263d, c: 0.25123299807035915d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineSingleTypeline)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25289620024304427d, b: 0.5412297583175978d, c: 0.9352094016288186d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0850553201118952d, b: 0.31486740022023885d, c: 0.9505674237204337d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6006643780222548d, b: 0.9328960252560242d, c: 0.6644469807782444d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.20361392519642485d, b: 0.19982280233855176d, c: 0.47439154697512076d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4762003572590354d, b: 0.9742273307560194d, c: 0.9067393616693141d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.11902072398837737d, b: 0.7431830810458128d, c: 0.7434531921487352d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((5)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8400603375115314d, b: 0.28686595137917537d, c: 0.7708452112704814d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4615682093583833d, b: 0.35052026206787323d, c: 0.3789004834108546d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6095071549294975d, b: 0.9179734385181998d, c: 0.6328573049639803d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.740083260091443d, b: 0.13842874894094848d, c: 0.9746664566420702d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.33934908536142383d, b: 0.32319372436095317d, c: 0.27733556088033207d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44360239305018834d, b: 0.6446520595102045d, c: 0.069793004601864d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((10)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1033425485748104d, b: 0.7919193253984929d, c: 0.6550189343381998d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7744455624309416d, b: 0.24602845829022857d, c: 0.3797015035115463d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.18242022158986937d, b: 0.6131831810342259d, c: 0.9006945444358355d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4853511941879275d, b: 0.46542709898805945d, c: 0.37495391902428443d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5460492133245229d, b: 0.961920895857086d, c: 0.8152599926139061d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5314994744070267d, b: 0.8288510464853904d, c: 0.7539283210902729d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6209358638349803d, b: 0.16478461777691322d, c: 0.011868736207908182d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7847391422302157d, b: 0.6618120906567673d, c: 0.23821139633809507d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6880196369964924d, b: 0.5748555076705857d, c: 0.27411636939971473d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1878108561810432d, b: 0.008566352719368675d, c: 0.9484782370087882d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5387287651414192d, b: 0.5657106552012308d, c: 0.8954568197940018d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6171334794523086d, b: 0.1608861954073365d, c: 0.21719472565520603d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0745591860685978d, b: 0.8875930349406574d, c: 0.5373389724904158d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.711432653357581d, b: 0.6040910704801116d, c: 0.5485642688339446d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.266009399767841d, b: 0.5640630554665284d, c: 0.23206342683815673d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19413957327399345d, b: 0.2945657649650191d, c: 0.27666529145008356d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3039183724823237d, b: 0.7387688337004792d, c: 0.609522479800577d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7432396271290146d, b: 0.9138173812898805d, c: 0.31763414136234225d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.5050227682173146d, b: 0.275016268075997d, c: 0.07321193021867067d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.12668966371736856d, b: 0.292900547242535d, c: 0.6089592618411368d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44708532857229577d, b: 0.9720062044025501d, c: 0.9209006724211737d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.44197217495101604d, b: 0.19426368687760476d, c: 0.9124610951512347d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.19079046107745534d, b: 0.10107072097233083d, c: 0.4929204891181137d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.829215079771655d, b: 0.0774721867646001d, c: 0.4825394542524326d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.23457516743144202d, b: 0.5106388043235565d, c: 0.43314490013619633d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3614920069700458d, b: 0.2009377234645029d, c: 0.31719801781158163d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.10688678790841422d, b: 0.027403052109701842d, c: 0.523629845098796d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7213792568619652d, b: 0.5979490282065303d, c: 0.9422612556707727d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9324393420938057d, b: 0.0828283851086663d, c: 0.6602113366168892d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.27145665853885337d, b: 0.6910805255284522d, c: 0.046031036212038634d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7797243803526664d, b: 0.16641970488780067d, c: 0.05615981725462604d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4434250903919057d, b: 0.7706491611956937d, c: 0.890694387121779d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7571627537451394d, b: 0.0067929552501859725d, c: 0.06063509095120512d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1588947891735113d, b: 0.252994502309154d, c: 0.7281205132281954d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.0775408295109693d, b: 0.26203637562158544d, c: 0.5574516404139539d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8945906335596823d, b: 0.5822780016264607d, c: 0.34331901572389634d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.542586982051713d, b: 0.14867075983194722d, c: 0.16260709026861275d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7905080524681075d, b: 0.6999588908310511d, c: 0.35987348197933866d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7176021282922553d, b: 0.854855316336119d, c: 0.7390043339977708d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((53)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7131402822382878d, b: 0.8194094365061462d, c: 0.6660737764703534d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.24818635673110212d, b: 0.941596931329753d, c: 0.5608093123342696d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.25397410271410203d, b: 0.11558490226088658d, c: 0.7310298829071104d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.035140967977620674d, b: 0.48410254072878345d, c: 0.7709387334377846d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.572255666593331d, b: 0.018496006269827392d, c: 0.15152620095517555d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((129)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.024456026159870414d, b: 0.413299705894168d, c: 0.2632806864562668d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9498918961840292d, b: 0.2821259404448926d, c: 0.025145859757612632d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7521853073630492d, b: 0.19240506877872599d, c: 0.1338702274392657d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4546370002409842d, b: 0.6231388201683524d, c: 0.6231763411148605d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09210471179910251d, b: 0.15613350053835506d, c: 0.7044315042707772d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.1697368655292918d, b: 0.519089612635884d, c: 0.90688348448267d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7169074888411233d, b: 0.005072370234888157d, c: 0.7323842725182083d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.16168208254010163d, b: 0.7949338873998705d, c: 0.4055083962865872d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7805990398760166d, b: 0.6554284346536067d, c: 0.7061318329380171d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.7760057259714137d, b: 0.07575210491880169d, c: 0.04722304493532181d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9401076849773609d, b: 0.8941308567774217d, c: 0.11810386119469374d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.4628052765753815d, b: 0.3770322373218742d, c: 0.595361083932735d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.28940341152566873d, b: 0.652342859356139d, c: 0.8005172293990623d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.2637686448929444d, b: 0.46289076181805844d, c: 0.22212741841481187d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9019790974635302d, b: 0.23925898781674892d, c: 0.3159112070444734d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8707574692614644d, b: 0.09987757631623528d, c: 0.9994575053030721d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.09232449675731669d, b: 0.02188955801565584d, c: 0.9334412475443509d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3074095070619022d, b: 0.9522169543340684d, c: 0.35731915863566344d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.9957723000999438d, b: 0.48221512730109695d, c: 0.3061132294871727d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.8293891689054781d, b: 0.13274355547554562d, c: 0.1975244230115314d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.13766786633507566d, b: 0.036958879194046834d, c: 0.43699322769212756d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.3185500215779038d, b: 0.5636184953498055d, c: 0.6508994544577198d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlLine)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6569304909750561d, b: 0.9652909521926948d, c: 0.8647208089251412d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlLine?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlLine(a: 0.6816525285464069d, b: 0.5449234855456263d, c: 0.25123299807035915d))));

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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineSingleTypeline)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineSingleTypeline)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineSingleTypeline)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineSingleTypeline)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllineline0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLineline0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineSingleTypeline)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLineline0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineSingleTypeline)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllineline0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllineline0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLineline0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
FROM public.binary_npgsqllineline0m m
LEFT JOIN public.binary_npgsqllineline0mi mi ON mi.id = m.npgsqllineline0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLineline0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineSingleTypeline)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineSingleTypeline)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLineline0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLineline0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineSingleTypeline)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineSingleTypeline)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLineline0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllineline0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLineline0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models =  ((INpgsqlLineSingleTypeline)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLineline0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA), typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA), typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models = await ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllineline0mi
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
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI), typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models1 = new List<NpgsqlLineline0MI>();
                var models2 = new List<NpgsqlLineline0MI>();
                await ((INpgsqlLineSingleTypeline)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MI>();
                var models2 = new List<NpgsqlLineline0MI>();
                ((INpgsqlLineSingleTypeline)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(10),
                (NpgsqlTypes.NpgsqlDbType)(10)
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
                var models = await ((INpgsqlLineSingleTypeline)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllineline0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA), typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                await ((INpgsqlLineSingleTypeline)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLineline0MIWA>();
                var models2 = new List<NpgsqlLineline0MIWA>();
                ((INpgsqlLineSingleTypeline)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllineline0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLineline0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineSingleTypeline))]
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
                var models = await ((INpgsqlLineSingleTypeline)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineSingleTypeline)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLineline0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

