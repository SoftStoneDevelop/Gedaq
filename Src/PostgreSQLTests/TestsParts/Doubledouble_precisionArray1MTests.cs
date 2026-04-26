

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
    internal partial interface IDoubleArraydouble_precisionArray
    {
    }
    
    internal partial class DoubleArraydouble_precisionArray : IDoubleArraydouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray1M[] _testData = new Doubledouble_precisionArray1M[]
        {
            new Doubledouble_precisionArray1M
{
    Id = 7,
    Value = 
new System.Double[3]
{
0.2585268252298498d,
0.6892278070710673d,
0.22813725431428056d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 10,
    Value = 
new System.Double[4]
{
0.5433989313894415d,
0.1351610314500873d,
0.035876797199457355d,
0.474923576234313d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 3,
    Value = 
new System.Double[4]
{
0.9027714303693537d,
0.8321686112571858d,
0.9284068240953088d,
0.9984706959139014d,
},
    NullableValue = 
new System.Double[4]
{
0.4298277196546534d,
0.6989592845581207d,
0.4678781534655433d,
0.3036818955713394d,
},
},
    NullableValue = 
new System.Double[3]
{
0.9621095591944716d,
0.4707611442612786d,
0.5103432488799676d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 17,
    Value = 
new System.Double[4]
{
0.11110749276639009d,
0.11336514420605937d,
0.9034824887773957d,
0.6440120825369351d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.765831857459021d,
0.38270914441614745d,
0.8531174218227325d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 20,
    Value = 
new System.Double[4]
{
0.9735436821174046d,
0.9590858041787171d,
0.334521862713862d,
0.7533713035857957d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 5,
    Value = 
new System.Double[4]
{
0.470644395697845d,
0.576140062052686d,
0.3318855688602219d,
0.6072812074891145d,
},
    NullableValue = 
new System.Double[4]
{
0.1026891365835042d,
0.6791376836321956d,
0.576852132958487d,
0.06923336315043882d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 26,
    Value = 
new System.Double[4]
{
0.1845998382495483d,
0.17396698170370428d,
0.26941095571008244d,
0.06270568354555728d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.12040140944109345d,
0.928792233522576d,
0.6546428908854343d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 31,
    Value = 
new System.Double[4]
{
0.6739534782811887d,
0.9806427961898101d,
0.9355282466181021d,
0.8989323106079722d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 11,
    Value = 
new System.Double[4]
{
0.3961395751639101d,
0.9871460617725046d,
0.3187944179741369d,
0.43762931178386244d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 36,
    Value = 
new System.Double[4]
{
0.023216807128276007d,
0.5184157096968516d,
0.8151257910776741d,
0.009052387860170596d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 45,
    Value = 
new System.Double[3]
{
0.6432668516400116d,
0.8142507231880924d,
0.22149061113608126d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 16,
    Value = 
new System.Double[4]
{
0.25927021600856726d,
0.5660737575702025d,
0.12171665387223984d,
0.7335363384102818d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 52,
    Value = 
new System.Double[3]
{
0.7778666682073299d,
0.6597971455169569d,
0.8547098835377699d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 61,
    Value = 
new System.Double[3]
{
0.568644692873537d,
0.027369514882562562d,
0.3790513881846028d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 17,
    Value = 
new System.Double[3]
{
0.42750601946550715d,
0.35169679650587693d,
0.7547443723490694d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.9471437198646434d,
0.5963550795626036d,
0.863625438134432d,
0.5185714149233253d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 66,
    Value = 
new System.Double[3]
{
0.7900454345407081d,
0.629336656120119d,
0.029580220233148546d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 67,
    Value = 
new System.Double[4]
{
0.48796665855313304d,
0.7550362060350636d,
0.10641571099794966d,
0.16484582266641545d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 20,
    Value = 
new System.Double[4]
{
0.6284479386925765d,
0.3847516588631025d,
0.5579945016371332d,
0.8711436652299621d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.8278557296796262d,
0.3256294728764708d,
0.23879980356445074d,
0.2772195623172393d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 76,
    Value = 
new System.Double[3]
{
0.5567299645441232d,
0.558809241930765d,
0.6288209548728486d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 83,
    Value = 
new System.Double[4]
{
0.3108685374059724d,
0.1297276010748103d,
0.690755378910407d,
0.755074649910551d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 26,
    Value = 
new System.Double[4]
{
0.1956245092246276d,
0.13806156654295987d,
0.9200617615139057d,
0.038213517974658884d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.046905133768440854d,
0.906174498698003d,
0.873067930823961d,
0.5412733544601449d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 85,
    Value = 
new System.Double[4]
{
0.7347219020412321d,
0.37384335010393266d,
0.4213439745619959d,
0.11491519524357086d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 87,
    Value = 
new System.Double[4]
{
0.5882829780010109d,
0.7179242222816378d,
0.3940433112066636d,
0.91989927651925d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 33,
    Value = 
new System.Double[3]
{
0.20834315391653235d,
0.21776004994248188d,
0.7434209954433894d,
},
    NullableValue = 
new System.Double[4]
{
0.7460843511422275d,
0.3001685249147312d,
0.5355946607641769d,
0.0008640893844406028d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 91,
    Value = 
new System.Double[4]
{
0.015576766711963397d,
0.33507254257467756d,
0.8147954951603755d,
0.29228244790862024d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 93,
    Value = 
new System.Double[3]
{
0.001804040002251428d,
0.7489518309168016d,
0.14707859397371292d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 37,
    Value = 
new System.Double[3]
{
0.38640710318317306d,
0.4272153905100553d,
0.6730945356508411d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 99,
    Value = 
new System.Double[3]
{
0.7842106721175504d,
0.6281663496924161d,
0.5174391104730798d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.7249551951751384d,
0.9557659003175739d,
0.020225741091818406d,
0.31326874976232644d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 108,
    Value = 
new System.Double[3]
{
0.6549005314524932d,
0.9871059648394837d,
0.8655548395049659d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 43,
    Value = 
new System.Double[4]
{
0.663608712172892d,
0.2828922822893135d,
0.7892125365722914d,
0.38508153686008073d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.245962714465488d,
0.9885089384477523d,
0.8210913058126238d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 111,
    Value = 
new System.Double[3]
{
0.03923636992414559d,
0.9842548193706021d,
0.8333104033677827d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.8743640551504105d,
0.6577809501589388d,
0.9060462705445861d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 119,
    Value = 
new System.Double[4]
{
0.418347784594712d,
0.5764288889130391d,
0.2342055375900518d,
0.3211131669310545d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 49,
    Value = 
new System.Double[3]
{
0.10767064504479085d,
0.18421276653036267d,
0.6999108415673645d,
},
    NullableValue = 
new System.Double[4]
{
0.43636770012049897d,
0.4430844458596892d,
0.21252987386592115d,
0.09373712653460031d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 128,
    Value = 
new System.Double[4]
{
0.8451573371364688d,
0.008517618413360628d,
0.137420689036725d,
0.7305217693172881d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 132,
    Value = 
new System.Double[3]
{
0.8956556072678306d,
0.24003073072996817d,
0.0027850932979150977d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 55,
    Value = 
new System.Double[4]
{
0.7061672630805171d,
0.20713684157584156d,
0.13865714303385202d,
0.7157150734728404d,
},
    NullableValue = 
new System.Double[4]
{
0.3054073646136263d,
0.4093844735230371d,
0.5677335535081662d,
0.35708957756013093d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 134,
    Value = 
new System.Double[4]
{
0.010707377000730323d,
0.8983883870590998d,
0.15262159312533807d,
0.7466431377352635d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 142,
    Value = 
new System.Double[3]
{
0.21463386320247957d,
0.17327266772375705d,
0.554832211337324d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 58,
    Value = 
new System.Double[4]
{
0.45894740302623405d,
0.8867426691131556d,
0.9163658144007766d,
0.9909099460899315d,
},
    NullableValue = 
new System.Double[3]
{
0.4251888591579772d,
0.30403935297414675d,
0.7831728448582773d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 146,
    Value = 
new System.Double[4]
{
0.09691179173334996d,
0.9427714197204514d,
0.19280905475913013d,
0.25140283495191107d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 151,
    Value = 
new System.Double[4]
{
0.9262832241212774d,
0.014758198021103341d,
0.021303478874487358d,
0.551828734850748d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 63,
    Value = 
new System.Double[4]
{
0.1960184407595591d,
0.2311775080254288d,
0.3708123311517877d,
0.9841534571499829d,
},
    NullableValue = 
new System.Double[4]
{
0.7947625579785442d,
0.052896679591692086d,
0.8183217913296638d,
0.7564050620531614d,
},
},
    NullableValue = 
new System.Double[4]
{
0.49351664430084086d,
0.15995866781339263d,
0.12464770691709659d,
0.510819060719825d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 160,
    Value = 
new System.Double[3]
{
0.4453072611386464d,
0.3774566598058827d,
0.8913880744949749d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 161,
    Value = 
new System.Double[3]
{
0.01914471650891303d,
0.1823165010832839d,
0.4766362111452124d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 69,
    Value = 
new System.Double[4]
{
0.2604286788692437d,
0.2580545468448474d,
0.32055951980759423d,
0.7284131717883515d,
},
    NullableValue = 
new System.Double[4]
{
0.8136728195541474d,
0.6493065633400826d,
0.16284844515124486d,
0.6282659191749559d,
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1mi(
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
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

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray1mi_id", 
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
                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleArraydouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleArraydouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.12040140944109345d,
0.928792233522576d,
0.6546428908854343d,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray1mi_id
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
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray1mi_id", 
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
                System.Double[] nullable = null;
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.9471437198646434d,
0.5963550795626036d,
0.863625438134432d,
0.5185714149233253d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[] nullable = null;
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.8278557296796262d,
0.3256294728764708d,
0.23879980356445074d,
0.2772195623172393d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray1M> models = null;

                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleArraydouble_precisionArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray1M> models = null;

                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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

                var models = await ((IDoubleArraydouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((IDoubleArraydouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleArraydouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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

                var models = await ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[4], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[5], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[6], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[7], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[8], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[9], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[21],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[22],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[23],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[24],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[25],_testData[29], false);
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

                var models =  ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[1], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[2], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[3], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[4], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[5], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[6], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[7], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[8], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[9], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[21],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[22],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[23],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[24],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[25],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[26],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[27],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 151, query1, 85, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 31, query1, 108, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[20], false);FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[21], false);FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[22], false);FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[23], false);FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[24], false);FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[25], false);FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[26], false);FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[27], false);FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[28], false);FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[29], false);
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
FROM public.doubledouble_precisionarray1m m
LEFT JOIN public.doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
                var models = await ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelBatchAsync(connection, 111, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[7], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[8], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[9], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[21],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[22],_testData[29], false);
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
                var models =  ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelBatch(connection, 36, 83))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[7], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[8], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[9], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[21],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[29], false);
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
                await using var cmd = await ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDoubleArraydouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
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
                await ((IDoubleArraydouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray1m m
LEFT JOIN public.binary_doubledouble_precisionarray1mi mi ON mi.id = m.doubledouble_precisionarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray1M>(15);

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
                ((IDoubleArraydouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray1M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IDoubleArraydouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray1M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray1M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray1M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray1M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray1M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray1M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray1M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray1M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray1M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray1M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray1M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray1M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray1M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray1M.AssertModel(models[14],_testData[14], false);
                Doubledouble_precisionArray1M.AssertModel(models[15],_testData[15], false);
                Doubledouble_precisionArray1M.AssertModel(models[16],_testData[16], false);
                Doubledouble_precisionArray1M.AssertModel(models[17],_testData[17], false);
                Doubledouble_precisionArray1M.AssertModel(models[18],_testData[18], false);
                Doubledouble_precisionArray1M.AssertModel(models[19],_testData[19], false);
                Doubledouble_precisionArray1M.AssertModel(models[20],_testData[20], false);
                Doubledouble_precisionArray1M.AssertModel(models[21],_testData[21], false);
                Doubledouble_precisionArray1M.AssertModel(models[22],_testData[22], false);
                Doubledouble_precisionArray1M.AssertModel(models[23],_testData[23], false);
                Doubledouble_precisionArray1M.AssertModel(models[24],_testData[24], false);
                Doubledouble_precisionArray1M.AssertModel(models[25],_testData[25], false);
                Doubledouble_precisionArray1M.AssertModel(models[26],_testData[26], false);
                Doubledouble_precisionArray1M.AssertModel(models[27],_testData[27], false);
                Doubledouble_precisionArray1M.AssertModel(models[28],_testData[28], false);
                Doubledouble_precisionArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray1M)],
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleArraydouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleArraydouble_precisionArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

