

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
new System.Double[4]
{
0.8449086400170176d,
0.3794175655337495d,
0.5361673192417332d,
0.30109515334734005d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 9,
    Value = 
new System.Double[4]
{
0.27522279411886996d,
0.6054329776369636d,
0.3969228533919049d,
0.9048572526897624d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 4,
    Value = 
new System.Double[4]
{
0.01418340527203199d,
0.7766138048235944d,
0.6923587694029195d,
0.7356202647156803d,
},
    NullableValue = 
new System.Double[3]
{
0.6037211920982565d,
0.6840847911267596d,
0.9143317497711329d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 10,
    Value = 
new System.Double[4]
{
0.9032981867102464d,
0.050945653568725935d,
0.6315381719197881d,
0.7350354541263755d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.5763986674544377d,
0.44504236820158605d,
0.8127811019779454d,
0.8466114624183257d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 16,
    Value = 
new System.Double[4]
{
0.5724510154928125d,
0.7656403152640625d,
0.7169552797360377d,
0.43444305693116414d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 6,
    Value = 
new System.Double[4]
{
0.7252146945329376d,
0.9016384214315868d,
0.5501575257805232d,
0.23399376022919482d,
},
    NullableValue = 
new System.Double[4]
{
0.6861864921501228d,
0.09906468691660697d,
0.5396548252668838d,
0.5779431268827486d,
},
},
    NullableValue = 
new System.Double[4]
{
0.06445725442661687d,
0.4594168980123381d,
0.6454025861936382d,
0.10175910331087523d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 24,
    Value = 
new System.Double[4]
{
0.532064821241112d,
0.36417121041971323d,
0.1551776597432476d,
0.7791561158638733d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.8560042301738476d,
0.11729910820363143d,
0.33642926105605564d,
0.7073474928691407d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 25,
    Value = 
new System.Double[4]
{
0.9766338312280608d,
0.762245823794953d,
0.05424759066828244d,
0.0707752135108618d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 10,
    Value = 
new System.Double[4]
{
0.643485020018004d,
0.08471927337282936d,
0.01811842206621117d,
0.4354059618821351d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 28,
    Value = 
new System.Double[4]
{
0.5357375464157546d,
0.5328620803648335d,
0.13151361055494015d,
0.7723181682208123d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 35,
    Value = 
new System.Double[3]
{
0.8282518122703909d,
0.5683539818849098d,
0.7748186451985483d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 17,
    Value = 
new System.Double[3]
{
0.3674750691611566d,
0.3174012928634051d,
0.9165961861048778d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 44,
    Value = 
new System.Double[4]
{
0.8486476425783992d,
0.9088576825559809d,
0.2988319269341281d,
0.7243884535421429d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.23704653081487737d,
0.6027125926326554d,
0.8000296925980147d,
0.8392023810631147d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 46,
    Value = 
new System.Double[4]
{
0.26060042987755805d,
0.21574541991399898d,
0.6328589110288355d,
0.886838925163398d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 21,
    Value = 
new System.Double[4]
{
0.16975488193421762d,
0.3568974966982775d,
0.06535593160678632d,
0.4238266700752099d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.9302520410241119d,
0.9744477291624024d,
0.7257515868287588d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 47,
    Value = 
new System.Double[4]
{
0.8363409769113234d,
0.6583996661186841d,
0.08587439487795812d,
0.31168472355437404d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 53,
    Value = 
new System.Double[3]
{
0.3652303364842634d,
0.08008181313900897d,
0.25707458621952306d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 22,
    Value = 
new System.Double[4]
{
0.2918065238218628d,
0.9495514925259696d,
0.3284872909044293d,
0.8356016442573535d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.2524770091250098d,
0.5728185325214679d,
0.7573771456116992d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 57,
    Value = 
new System.Double[3]
{
0.46422024410162444d,
0.018507820070460368d,
0.4236271426207936d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.8899223448795432d,
0.276733531023341d,
0.43192362763771897d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 60,
    Value = 
new System.Double[4]
{
0.44220357255630893d,
0.16816156030530893d,
0.11332195222639974d,
0.8176408671157477d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 23,
    Value = 
new System.Double[4]
{
0.2505575898637509d,
0.5736624332164685d,
0.9464703548143748d,
0.7693502085311197d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 66,
    Value = 
new System.Double[4]
{
0.025975838776742033d,
0.17121821664102932d,
0.4973855039920828d,
0.8343338858688708d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 69,
    Value = 
new System.Double[3]
{
0.6051984186720102d,
0.7589692200856667d,
0.9424728116591711d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 31,
    Value = 
new System.Double[3]
{
0.03644130980473903d,
0.6378507445786334d,
0.41249519063217477d,
},
    NullableValue = 
new System.Double[4]
{
0.40854557800382396d,
0.07609704126147265d,
0.2195336206444991d,
0.2144398884223767d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 73,
    Value = 
new System.Double[4]
{
0.424249959720679d,
0.7715617560651372d,
0.3091667945115053d,
0.23229658814036025d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.17385677677778955d,
0.4236985913192287d,
0.9885893518331631d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 80,
    Value = 
new System.Double[4]
{
0.9948243499923031d,
0.09902204927124958d,
0.3719450482114087d,
0.24631165879900407d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 34,
    Value = 
new System.Double[4]
{
0.4059883794353356d,
0.5923141460852093d,
0.724882100618685d,
0.21715889365158347d,
},
    NullableValue = 
new System.Double[4]
{
0.3265621660981831d,
0.0695237613368348d,
0.04102597720500778d,
0.12942683096509966d,
},
},
    NullableValue = 
new System.Double[4]
{
0.8576315029554482d,
0.9191123645603546d,
0.699694445299809d,
0.0418412393492954d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 82,
    Value = 
new System.Double[3]
{
0.18491127786706452d,
0.6103027610668148d,
0.4863973904657197d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.28133715032317397d,
0.16994594329624169d,
0.5455498933617731d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 86,
    Value = 
new System.Double[4]
{
0.7582878469578633d,
0.22590855976991686d,
0.8079214994641567d,
0.4979753487576959d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 42,
    Value = 
new System.Double[4]
{
0.18452119013940937d,
0.8433252250788555d,
0.7229899994317418d,
0.49197073529077895d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 95,
    Value = 
new System.Double[3]
{
0.3760996384242168d,
0.9173009722386031d,
0.9828292403475745d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.31382434698982553d,
0.6514214501345901d,
0.14025375577184596d,
0.2735660887985566d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 103,
    Value = 
new System.Double[4]
{
0.847146810239623d,
0.392709806698715d,
0.4744121740249114d,
0.2402719935360732d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 51,
    Value = 
new System.Double[4]
{
0.4861509878432866d,
0.8645733604897977d,
0.1498309170137957d,
0.9500461685517317d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 107,
    Value = 
new System.Double[3]
{
0.04004199175297096d,
0.9409578435385001d,
0.6182646182334901d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.7852543644647254d,
0.49519281429797235d,
0.13002644801401453d,
0.18199324193069777d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 110,
    Value = 
new System.Double[4]
{
0.40798050910960826d,
0.8632506258759437d,
0.7171405987960934d,
0.9137736881086972d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 59,
    Value = 
new System.Double[4]
{
0.32154927499769803d,
0.027004104971078302d,
0.29705035997040075d,
0.17192477723722444d,
},
    NullableValue = 
new System.Double[4]
{
0.6858931302618733d,
0.2335597628509738d,
0.09513991611954908d,
0.04160866133136021d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 114,
    Value = 
new System.Double[4]
{
0.8535863279918331d,
0.16342759187168998d,
0.8105623219408382d,
0.6161361824837197d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 120,
    Value = 
new System.Double[3]
{
0.2943285738904404d,
0.6705099897533666d,
0.5868905288871131d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 64,
    Value = 
new System.Double[4]
{
0.03376757866456048d,
0.15148495024437003d,
0.8678079502591535d,
0.6930641724902752d,
},
    NullableValue = 
new System.Double[3]
{
0.2402180592669062d,
0.6698821072268154d,
0.7023338138458499d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 123,
    Value = 
new System.Double[4]
{
0.17753332027636315d,
0.38769074205600995d,
0.14648111447151213d,
0.921496702713426d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.48143873944243787d,
0.6710805980402935d,
0.05641575873439386d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 132,
    Value = 
new System.Double[3]
{
0.3492913931763736d,
0.3532380127199113d,
0.6449340196304617d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 72,
    Value = 
new System.Double[4]
{
0.9023404671625952d,
0.0492579732942221d,
0.5861031868930705d,
0.9614768420559572d,
},
    NullableValue = 
new System.Double[3]
{
0.8241128461994869d,
0.34902390145130735d,
0.9932795814749261d,
},
},
    NullableValue = 
new System.Double[3]
{
0.4718697730029602d,
0.8472955452583678d,
0.53664528757361d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 135,
    Value = 
new System.Double[3]
{
0.8946048241612815d,
0.5453470515672839d,
0.18072565200482404d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.5389465932812765d,
0.1634419929158618d,
0.3293960537187167d,
0.8014416527733559d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 138,
    Value = 
new System.Double[4]
{
0.44069384716371673d,
0.5283334632277246d,
0.29734810799908185d,
0.8409667266786681d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 80,
    Value = 
new System.Double[4]
{
0.48997778255568125d,
0.5417674260833327d,
0.8376536374850989d,
0.01664393225069949d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 141,
    Value = 
new System.Double[4]
{
0.7215724600618758d,
0.30567262011750906d,
0.3736783333487139d,
0.07095360182613752d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 143,
    Value = 
new System.Double[4]
{
0.39543523172891415d,
0.5086985474724031d,
0.4306688541685939d,
0.44781562251590823d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 82,
    Value = 
new System.Double[4]
{
0.5049324685994266d,
0.866915162564442d,
0.9478726844227404d,
0.6930949187137051d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 150,
    Value = 
new System.Double[4]
{
0.7874562295719114d,
0.26492214771358424d,
0.5862798665348726d,
0.7286871079324713d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.49824547902104077d,
0.08331293797375794d,
0.847303616030793d,
0.49501846562963037d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 159,
    Value = 
new System.Double[4]
{
0.12295616819314115d,
0.4152740991576894d,
0.7055513372918242d,
0.7931915069535118d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 89,
    Value = 
new System.Double[3]
{
0.4962852795419196d,
0.23679840315805134d,
0.6355105092943871d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 160,
    Value = 
new System.Double[3]
{
0.2441291817202904d,
0.10104614039043547d,
0.5865106311081295d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.853906299459587d,
0.7282782215499172d,
0.32010301868306223d,
0.5644802544374325d,
},
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

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleArraydouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
new System.Double[4]
{
0.8560042301738476d,
0.11729910820363143d,
0.33642926105605564d,
0.7073474928691407d,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.23704653081487737d,
0.6027125926326554d,
0.8000296925980147d,
0.8392023810631147d,
}));
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.9302520410241119d,
0.9744477291624024d,
0.7257515868287588d,
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
new System.Double[3]
{
0.2524770091250098d,
0.5728185325214679d,
0.7573771456116992d,
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
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleArraydouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((IDoubleArraydouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((IDoubleArraydouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[5], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[28],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M), typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                await((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 110, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 150, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray1M>();
                var models2 = new List<FlatDoubledouble_precisionArray1M>();
                ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 28, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 103, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 60, query1, 150, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 16, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 53, query1, 143, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[34], false);
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
FROM public.doubledouble_precisionarray1m m
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
FROM public.doubledouble_precisionarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray1M>();
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 73, query1, 107, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 132, 25))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 80, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[34], false);
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
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 86);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[29], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[30], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[31], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[32], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[33], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[8], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[9], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[10], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[11], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[21],_testData[29], false);Doubledouble_precisionArray1M.AssertModel(models[22],_testData[30], false);Doubledouble_precisionArray1M.AssertModel(models[23],_testData[31], false);Doubledouble_precisionArray1M.AssertModel(models[24],_testData[32], false);Doubledouble_precisionArray1M.AssertModel(models[25],_testData[33], false);Doubledouble_precisionArray1M.AssertModel(models[26],_testData[34], false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleArraydouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleArraydouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(Doubledouble_precisionArray1M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleArraydouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleArraydouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleArraydouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleArraydouble_precisionArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models = await ((IDoubleArraydouble_precisionArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray1mi
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
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI), typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models1 = new List<Doubledouble_precisionArray1MI>();
                var models2 = new List<Doubledouble_precisionArray1MI>();
                await ((IDoubleArraydouble_precisionArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MI>();
                var models2 = new List<Doubledouble_precisionArray1MI>();
                ((IDoubleArraydouble_precisionArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
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
                var models = await ((IDoubleArraydouble_precisionArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA), typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                await ((IDoubleArraydouble_precisionArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray1MIWA>();
                var models2 = new List<Doubledouble_precisionArray1MIWA>();
                ((IDoubleArraydouble_precisionArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleArraydouble_precisionArray))]
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
                var models = await ((IDoubleArraydouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleArraydouble_precisionArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

