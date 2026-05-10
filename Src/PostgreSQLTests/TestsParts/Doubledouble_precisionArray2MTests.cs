

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
    internal partial interface IDoubleListdouble_precisionArray
    {
    }
    
    internal partial class DoubleListdouble_precisionArray : IDoubleListdouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray2M[] _testData = new Doubledouble_precisionArray2M[]
        {
            new Doubledouble_precisionArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.45787106881169526d,

0.34729814655735336d,

0.6579329846105426d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.38791130326200873d,

0.030497643416436238d,

0.8904182723942662d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9025275144806563d,

0.27325672066578843d,

0.9097219206688553d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7720932038100108d,

0.3030768472435066d,

0.36779329480641354d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8139756240540255d,

0.693279835663597d,

0.6890833025622861d,

0.2545204028847552d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9628735305879027d,

0.826594084687351d,

0.11340587842873573d,

0.14042496700120843d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.22789039923582444d,

0.060187395019358436d,

0.06467431247025834d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47759914915075297d,

0.1545025375829664d,

0.7421343193206199d,

0.06499090672769592d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33907678832633237d,

0.5503403167796656d,

0.989924719152505d,

0.0773804690112897d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39370081935796786d,

0.005371310014866348d,

0.8373215901273874d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40981135677497516d,

0.720881345127574d,

0.6921187427311133d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.06789131012770133d,

0.8428863494493604d,

0.6858779120125511d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3032915793652421d,

0.8500659604701966d,

0.45788290632315054d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9794064628360918d,

0.32459180165744883d,

0.2410253803797252d,

0.05256507609006478d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8322547671028299d,

0.07182996463922664d,

0.7725236766883046d,

0.5149607854782522d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5778841938236382d,

0.9880232009585328d,

0.9514889204779473d,

0.9713606888618472d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2011049667099598d,

0.9075584511851096d,

0.21013519358705357d,

0.808623341760272d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.471167092680426d,

0.39856130716170646d,

0.7143588410761664d,

0.9464751413311765d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6371856033064195d,

0.3639207853889771d,

0.5257617837170465d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9712035491301294d,

0.27988353255432485d,

0.980980633960754d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.406765091008217d,

0.343507676677243d,

0.7431915103242205d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8913900955862869d,

0.3092376133912086d,

0.34374629073277974d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6241231839062379d,

0.77880511562058d,

0.5254478727871709d,

0.6444751210176034d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8493496517524035d,

0.8217822071142902d,

0.5693613847708802d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9140082975251717d,

0.34301694678444905d,

0.15963995918115992d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.10653583496240404d,

0.2641801607285418d,

0.04044085478490089d,

0.3863210855337237d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.21698678007148187d,

0.006495005380439678d,

0.06630418971634289d,

0.13340268243576725d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8627200121255075d,

0.9512583308222526d,

0.8445284662832159d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5122563588512739d,

0.8921127720514881d,

0.2592849462058405d,

0.8222640905790646d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07919953379219113d,

0.7064110619595826d,

0.35481438349406835d,

0.9261695517749082d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6454380394851751d,

0.4901914834328154d,

0.30817865849762227d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6274921165133486d,

0.5263133153414205d,

0.9410993514624668d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8578068311303317d,

0.8814156642821483d,

0.43614573511442667d,

0.6059022873707351d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6130536401763689d,

0.41674579455313887d,

0.08656200162949801d,

0.9427334311122794d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.45458782607965365d,

0.045065386042404065d,

0.40154037138309906d,

0.7223146739785982d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.11799288419390197d,

0.2811609622277794d,

0.8708438786625395d,

0.6530550671726589d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4528469757444329d,

0.46482628315255625d,

0.23903400690681087d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.49550910662877545d,

0.42709644515014433d,

0.8020821334725199d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6470694159969393d,

0.3138273870561268d,

0.3706289252181445d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6665796144226359d,

0.29162727523939436d,

0.43008579938019587d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9278977441782872d,

0.3316086724345293d,

0.3503992981914732d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.18297160016901337d,

0.08575110384481388d,

0.17609690152162905d,

0.05579436771244772d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.45877829577398876d,

0.25602484026240324d,

0.7291792934376891d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7433365430711415d,

0.3785237880767722d,

0.6045190590749239d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9423642953376622d,

0.03234547701357526d,

0.6110292018534335d,

0.6228706342463569d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7402534419857864d,

0.6374368130090913d,

0.6074875722198191d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.801533324252244d,

0.7876926279417176d,

0.6223598773880187d,

0.4810855327519479d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8546168986826095d,

0.38701044379167604d,

0.3002175413941842d,

0.7649005516681934d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12503644233564093d,

0.8516773428204588d,

0.0814077246583782d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.758576855968613d,

0.45214395825549303d,

0.28141716781934756d,

0.3214422744687573d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8700564699751547d,

0.19371278759475596d,

0.5957929564594039d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8439949167502087d,

0.9371804443894497d,

0.019805737304514515d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3112600430767374d,

0.1246295778271258d,

0.06696497525152045d,

0.4512688850461575d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7303704944330364d,

0.879734428616394d,

0.4502575284232052d,

0.9213458396633907d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3448069906629785d,

0.6175298895157665d,

0.9740430523738531d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5364886269427086d,

0.31241818868264737d,

0.060657049423349485d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8716637752851923d,

0.48852637447462444d,

0.7533349847388143d,

0.4496903592134356d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7293715568324783d,

0.7634470154877617d,

0.9344661729636057d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1925215358168586d,

0.7369571536117543d,

0.025645713429496952d,

0.8661973912472051d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2488677281216768d,

0.3295556111407396d,

0.4627628183614326d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6057696207450838d,

0.464968349892515d,

0.3198440554342784d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.42535740295889546d,

0.5904614794111062d,

0.18172951192936482d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8099295424750634d,

0.23101878112345942d,

0.29610771603658526d,

0.8835722651292168d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4475569712180367d,

0.5103387722718634d,

0.4462066933620228d,

0.3459513141596702d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6992979637952019d,

0.831116395333519d,

0.5428875969269844d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5256392975211563d,

0.6631870991453302d,

0.9881622773747574d,

0.07685327423000521d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8140800162407819d,

0.05092805199864503d,

0.7111998742973392d,

0.674303010182367d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4449804700743465d,

0.3259299106985124d,

0.7750327174311061d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4264621621161928d,

0.4011664900557439d,

0.8904634923684254d,

0.449536456664971d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8711412159568633d,

0.027785880321378298d,

0.5096888150797527d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8076863805287171d,

0.059350554954739954d,

0.5413945068445242d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8527611005791835d,

0.9338740174114142d,

0.5633896311788136d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.09740074500019202d,

0.5153248118503193d,

0.09438457633829889d,

0.4770869173199809d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31347512226522156d,

0.23141913940120262d,

0.2194609270757676d,

0.43990908016449826d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8172556484337127d,

0.5477726713120737d,

0.6262924656111024d,

0.1448704207203806d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 184,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3089202287796393d,

0.5128579395226807d,

0.8563040842624201d,

0.04225346005098152d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4783005754462829d,

0.3011477405281684d,

0.165362803051612d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.03534654385412428d,

0.7990843931446069d,

0.7946638795536208d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 193,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4245209143417853d,

0.49607775537022203d,

0.979088997378106d,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
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

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray2M> models = null;

                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray2M> models = null;

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleListdouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[34], false);
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
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 168;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 115, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 106, query1, 175, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 17, query1, 53, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 41, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 52, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[28],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[29],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[30],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[31],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 6, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 149, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 74, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 52, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 152, 25))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[29],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[30],_testData[34], false);
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
                await using var cmd = await ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[18], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[19], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[20], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[21], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[22], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[23], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[24], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[25], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[26], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[29], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[30], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[31], false);
                Doubledouble_precisionArray2M.AssertModel(models[15],_testData[32], false);
                Doubledouble_precisionArray2M.AssertModel(models[16],_testData[33], false);
                Doubledouble_precisionArray2M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 149);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[30], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[31], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[32], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[33], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[34], false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MI),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionArray2M),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2m m
LEFT JOIN public.binary_doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA), typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                ((IDoubleListdouble_precisionArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA), typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                ((IDoubleListdouble_precisionArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models = await ((IDoubleListdouble_precisionArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionarray2mi
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
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI), typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models1 = new List<Doubledouble_precisionArray2MI>();
                var models2 = new List<Doubledouble_precisionArray2MI>();
                await ((IDoubleListdouble_precisionArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MI>();
                var models2 = new List<Doubledouble_precisionArray2MI>();
                ((IDoubleListdouble_precisionArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA), typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                await ((IDoubleListdouble_precisionArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionArray2MIWA>();
                var models2 = new List<Doubledouble_precisionArray2MIWA>();
                ((IDoubleListdouble_precisionArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

