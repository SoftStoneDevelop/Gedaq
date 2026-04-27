

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
    Id = 9,
    Value = 
new System.Double[4]
{
0.05872522013561732d,
0.07277997270575165d,
0.1731970799911391d,
0.7518246885386919d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 13,
    Value = 
new System.Double[3]
{
0.03501995061328189d,
0.8912027699823122d,
0.297095450987244d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 6,
    Value = 
new System.Double[4]
{
0.5682419349802754d,
0.5623910755218339d,
0.566375580543587d,
0.7927806757752985d,
},
    NullableValue = 
new System.Double[4]
{
0.7141723140025068d,
0.6749454349099255d,
0.3416086848216774d,
0.9759172263217438d,
},
},
    NullableValue = 
new System.Double[3]
{
0.27099578403202207d,
0.3434225401162606d,
0.7281619895078999d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 15,
    Value = 
new System.Double[3]
{
0.38257027459952575d,
0.37019469160935825d,
0.6009146341860955d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.19445901909627694d,
0.4553376325351667d,
0.1927129180980811d,
0.641438750396453d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 21,
    Value = 
new System.Double[3]
{
0.2509451387822724d,
0.3741103843344953d,
0.42551123072822294d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 9,
    Value = 
new System.Double[3]
{
0.008498231452347182d,
0.8574550939896716d,
0.14235159571890887d,
},
    NullableValue = 
new System.Double[3]
{
0.19205794456125247d,
0.030294754407049318d,
0.5594569223590727d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 24,
    Value = 
new System.Double[4]
{
0.7561506636704213d,
0.7760946104129008d,
0.6847737363326765d,
0.4007990714385913d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.31097266930691947d,
0.12331275909233452d,
0.7830681000582278d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 31,
    Value = 
new System.Double[3]
{
0.7741482804175548d,
0.007043290539764824d,
0.8592190674871881d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 11,
    Value = 
new System.Double[4]
{
0.8986035061994514d,
0.3040241417527325d,
0.8039266472957598d,
0.24029417783015128d,
},
    NullableValue = 
new System.Double[3]
{
0.08395958120669911d,
0.11372734612618385d,
0.290289887912083d,
},
},
    NullableValue = 
new System.Double[4]
{
0.10022012304906047d,
0.7823030116791992d,
0.2872646319241975d,
0.056828570939152834d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 40,
    Value = 
new System.Double[3]
{
0.31684876299371967d,
0.5983347157139464d,
0.5527617647037721d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.9334948118816182d,
0.753873027551728d,
0.22212193264190683d,
0.7504198413246135d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 46,
    Value = 
new System.Double[3]
{
0.27672817412989925d,
0.014706610735555015d,
0.9316547023118225d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 20,
    Value = 
new System.Double[4]
{
0.6871537377973341d,
0.32856300454084686d,
0.20848262321920152d,
0.9355243954375421d,
},
    NullableValue = 
new System.Double[4]
{
0.4785834881652804d,
0.39720970800052746d,
0.022682044662478473d,
0.3579504297738927d,
},
},
    NullableValue = 
new System.Double[4]
{
0.59575822792529d,
0.3787186163721965d,
0.3967997204688518d,
0.3039097224736169d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 52,
    Value = 
new System.Double[3]
{
0.23282465342856073d,
0.010486194842540764d,
0.9407075151289518d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 56,
    Value = 
new System.Double[3]
{
0.37643751545776405d,
0.11126720633433729d,
0.0690309652884823d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 28,
    Value = 
new System.Double[4]
{
0.5709221182523625d,
0.9104639214966257d,
0.9731678390101642d,
0.1800714846683905d,
},
    NullableValue = 
new System.Double[4]
{
0.01483808049799673d,
0.6520188642026543d,
0.2516614698600189d,
0.01575316711333774d,
},
},
    NullableValue = 
new System.Double[3]
{
0.8025930345289343d,
0.01713454309890461d,
0.21293003398516153d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 58,
    Value = 
new System.Double[4]
{
0.42777552220930326d,
0.4758900555401787d,
0.1289358997116351d,
0.6893023834550008d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.04947113327463015d,
0.8934012506296801d,
0.5141115546857294d,
0.24383910801026476d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 60,
    Value = 
new System.Double[4]
{
0.002119623434990725d,
0.7405604893336191d,
0.1625298077474896d,
0.9228416632053759d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 31,
    Value = 
new System.Double[4]
{
0.46951621863271975d,
0.900430014994538d,
0.8675122968066098d,
0.9920178945801608d,
},
    NullableValue = 
new System.Double[3]
{
0.155595442697828d,
0.9725961594471525d,
0.34306693860062243d,
},
},
    NullableValue = 
new System.Double[4]
{
0.7532339048418213d,
0.7014735269869317d,
0.15156442719496177d,
0.2646594108346445d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 65,
    Value = 
new System.Double[4]
{
0.554597729436666d,
0.6441887901021062d,
0.7533596414109778d,
0.46575440993072503d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.3070619417752857d,
0.9605259443492592d,
0.9002783832931699d,
0.388510432176675d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 69,
    Value = 
new System.Double[4]
{
0.2699299595769319d,
0.04344503092563823d,
0.6825845960119933d,
0.5935494913872346d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 32,
    Value = 
new System.Double[3]
{
0.8496710232188676d,
0.16448023514730292d,
0.31741397003866056d,
},
    NullableValue = 
new System.Double[4]
{
0.6826249717937134d,
0.018953223436575684d,
0.6544815990799183d,
0.9409620514579524d,
},
},
    NullableValue = 
new System.Double[4]
{
0.9241757363256913d,
0.8503391734480091d,
0.4887387354079341d,
0.03333686960659854d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 70,
    Value = 
new System.Double[4]
{
0.6969221411524805d,
0.3185951111541516d,
0.9364757426691747d,
0.5384962336951183d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.19800257013138556d,
0.3254268565777042d,
0.7528602651492815d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 78,
    Value = 
new System.Double[4]
{
0.17610223130527258d,
0.24978257650571212d,
0.6382612453773563d,
0.7170737992948972d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 35,
    Value = 
new System.Double[3]
{
0.7250079692232084d,
0.9403184553387315d,
0.19077682381104177d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.3154302353720866d,
0.9488635860198972d,
0.3712028565456763d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 81,
    Value = 
new System.Double[3]
{
0.4898472770842872d,
0.8220629358865958d,
0.7576050070108664d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.37627787332078944d,
0.887333430465938d,
0.44260903613938407d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 83,
    Value = 
new System.Double[3]
{
0.7934490367185981d,
0.09091240802845024d,
0.9228932262200533d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 37,
    Value = 
new System.Double[4]
{
0.07063443454129315d,
0.23020886260494755d,
0.32157654988914797d,
0.8419003867575885d,
},
    NullableValue = 
new System.Double[4]
{
0.2916457470120223d,
0.42638860482644103d,
0.4316390227535033d,
0.4615754818934381d,
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
0.12865863496675833d,
0.2429574041168966d,
0.4439322333132597d,
0.1565543442032742d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 97,
    Value = 
new System.Double[4]
{
0.7839969015242954d,
0.05034149628032403d,
0.8989123007391926d,
0.8258550884652983d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 39,
    Value = 
new System.Double[4]
{
0.5705104682246993d,
0.03459258337264215d,
0.40527393053711636d,
0.07639612126813766d,
},
    NullableValue = 
new System.Double[3]
{
0.866733058382822d,
0.4467762577185742d,
0.7247485516897108d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 105,
    Value = 
new System.Double[4]
{
0.2660651554614123d,
0.6839671847711102d,
0.6907154082539936d,
0.9733840902504893d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 108,
    Value = 
new System.Double[4]
{
0.5985131675568086d,
0.42831145304243834d,
0.4805131554141069d,
0.5258635808241131d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 48,
    Value = 
new System.Double[4]
{
0.28058628698248367d,
0.2953379464157584d,
0.9231973669614105d,
0.611837268033727d,
},
    NullableValue = 
new System.Double[4]
{
0.38056154590194d,
0.01775305664989646d,
0.38100580450247556d,
0.8412567154869117d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 110,
    Value = 
new System.Double[4]
{
0.09014719730437415d,
0.9156781330452091d,
0.5586241082795389d,
0.394924422541721d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 115,
    Value = 
new System.Double[3]
{
0.034703662875474994d,
0.4751656385780819d,
0.1355056690443407d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 49,
    Value = 
new System.Double[4]
{
0.4084302433124214d,
0.9689500936719361d,
0.6489250508239167d,
0.1400681774888124d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 122,
    Value = 
new System.Double[4]
{
0.023495596268712116d,
0.7272042558321258d,
0.7143072282999129d,
0.5506764201196527d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 123,
    Value = 
new System.Double[3]
{
0.041222418538532035d,
0.998328559558495d,
0.5100711336147837d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 57,
    Value = 
new System.Double[4]
{
0.762355013000005d,
0.743344750298907d,
0.9685559141051173d,
0.6791042723639443d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.04434659381388739d,
0.6857044566624338d,
0.7100427972106306d,
0.4833040901263941d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 124,
    Value = 
new System.Double[4]
{
0.5771770113334246d,
0.8480518793362646d,
0.3968908279033335d,
0.4769323782492064d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 126,
    Value = 
new System.Double[4]
{
0.6525433369696512d,
0.13463193704524834d,
0.347682970032144d,
0.27975898830497714d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 64,
    Value = 
new System.Double[4]
{
0.43281892741818095d,
0.5016750640789693d,
0.15518467248719892d,
0.6913923919579984d,
},
    NullableValue = 
new System.Double[3]
{
0.24735603507480552d,
0.8420913762485291d,
0.7717905907316301d,
},
},
    NullableValue = 
new System.Double[3]
{
0.30570311288315877d,
0.31449467144086907d,
0.8535834551618035d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 135,
    Value = 
new System.Double[3]
{
0.6896679826899689d,
0.937776897741703d,
0.9320725677912826d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 143,
    Value = 
new System.Double[3]
{
0.7142324563463952d,
0.33949838471642757d,
0.9106090832768149d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 70,
    Value = 
new System.Double[4]
{
0.14859319420618633d,
0.9768187824835318d,
0.07623394145737428d,
0.1389518528522199d,
},
    NullableValue = 
new System.Double[3]
{
0.8018069817596687d,
0.33576916564170667d,
0.26778747125607005d,
},
},
    NullableValue = 
new System.Double[4]
{
0.2966568308590686d,
0.7185381923713393d,
0.9630688748356018d,
0.5133129519026605d,
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
0.31097266930691947d,
0.12331275909233452d,
0.7830681000582278d,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.10022012304906047d,
0.7823030116791992d,
0.2872646319241975d,
0.056828570939152834d,
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.9334948118816182d,
0.753873027551728d,
0.22212193264190683d,
0.7504198413246135d,
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.59575822792529d,
0.3787186163721965d,
0.3967997204688518d,
0.3039097224736169d,
}));
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
new System.Double[3]
{
0.8025930345289343d,
0.01713454309890461d,
0.21293003398516153d,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.04947113327463015d,
0.8934012506296801d,
0.5141115546857294d,
0.24383910801026476d,
}));
                nullable = await ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.7532339048418213d,
0.7014735269869317d,
0.15156442719496177d,
0.2646594108346445d,
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var models = ((IDoubleArraydouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleArraydouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models = ((IDoubleArraydouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
                        Assert.That(models, Has.Count.EqualTo(16));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[29], false);
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[4], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[5], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 9, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 122, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 115, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
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
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 108, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 65, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 31, query1, 65, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 31, query1, 56, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[29], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 122, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 83, 126))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 69, 122))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[29], false);
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
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[29], false);
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

