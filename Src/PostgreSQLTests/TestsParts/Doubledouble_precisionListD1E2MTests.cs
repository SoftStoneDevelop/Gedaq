

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
    internal partial interface IDoubleListdouble_precisionListD1
    {
    }
    
    internal partial class DoubleListdouble_precisionListD1 : IDoubleListdouble_precisionListD1
    {


#region TestData

        private readonly Doubledouble_precisionListD1E2M[] _testData = new Doubledouble_precisionListD1E2M[]
        {
            new Doubledouble_precisionListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19841586229491737d,

0.7622096594169161d,

0.4551713343666356d,

0.9609331694936684d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.07919626499420385d,

0.45418641463410037d,

0.7916297799694685d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.15638190404723107d,

0.3996159310860201d,

0.5368962455995258d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8104272669416304d,

0.6418960759777268d,

0.7017506448888312d,

0.8356698979027306d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6051275734643415d,

0.5663300611247555d,

0.8710552862352846d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7431800334020667d,

0.020905631172973616d,

0.1227073717003414d,

0.04869783219447166d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.42696299168202523d,

0.04125411509499055d,

0.17687215282406177d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7587618644619459d,

0.7953653838467006d,

0.23423809842968346d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0650481137738973d,

0.736732982772668d,

0.44725174638647214d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.20643752104135626d,

0.006082609695426067d,

0.2925926291257547d,

0.0015642884374584831d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7092026661963791d,

0.07652823903606798d,

0.7185989385919749d,

0.6460124162755178d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.09593607403728577d,

0.5248292035359521d,

0.37991512388239856d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4112380289142472d,

0.7157688300127486d,

0.19794338176754178d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2589264418522068d,

0.2647884890365827d,

0.03786320407234367d,

0.5258565391244132d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.17685527767477927d,

0.4441561870961439d,

0.5711648624855283d,

0.9187072237215054d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.22595036784450895d,

0.2502488350374861d,

0.6036762852334825d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8303570194452583d,

0.6326367348461874d,

0.9010038171118411d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5302085836801099d,

0.5251800007600432d,

0.3107010076200609d,

0.054525086295876934d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6688872777140293d,

0.6436365215175086d,

0.19776070941356905d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.21467485134975395d,

0.14054590323399707d,

0.24757462556796883d,

0.9394626317594876d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.18284441217476843d,

0.37892048521721644d,

0.0748673953313681d,

0.5850112350544885d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.20886622321800252d,

0.777651047142414d,

0.05602947291631177d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1382485165568298d,

0.44101390080397185d,

0.3719331142902478d,

0.909631943603152d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7503695061231921d,

0.715570234235366d,

0.05613203963130875d,

0.4530405867535633d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7023690003995662d,

0.8375884802152912d,

0.004971043991326529d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5231490549813996d,

0.6786120471949411d,

0.8625040196464194d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.16742426652558728d,

0.0775243187437511d,

0.4429396230452721d,

0.2894481096779409d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9328511519694519d,

0.7741684939821674d,

0.434797265585231d,

0.6479627250362294d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9242694939036179d,

0.3914646410941466d,

0.8174112106582185d,

0.09386846906125268d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1621583029428999d,

0.9686645231682381d,

0.5579307680531559d,

0.1392902816360605d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6893145285379849d,

0.2921577416937532d,

0.2657876403336522d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.326063650170786d,

0.8008544003956546d,

0.7412376349423867d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.655958725558814d,

0.6920833097836667d,

0.9178627328454251d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.26305817441390533d,

0.016172218014635198d,

0.2714340235103925d,

0.6611231541812277d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.17900356641400483d,

0.6626294512446957d,

0.7435658359676232d,

0.9860105120913953d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3686572276337887d,

0.314725150812842d,

0.7027808182681714d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6300222553882728d,

0.4264791843278465d,

0.2713862317803949d,

0.8120344332603618d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5838510832147205d,

0.38517331480897765d,

0.5325853547552246d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5517291280400627d,

0.4790838469653007d,

0.41940355518270833d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.963493979486813d,

0.8415405477347339d,

0.7864889321709005d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3544299516832575d,

0.040421361806387d,

0.16198075508448417d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8391309208024027d,

0.24702786672455557d,

0.2174572554080244d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2261907978136749d,

0.8477598012380734d,

0.46067128432792115d,

0.8059725964580061d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3992782137290297d,

0.35382875366718736d,

0.5241960000649939d,

0.6957763070499309d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1088640112536512d,

0.3317657490811088d,

0.12264366743132316d,

0.3963711856077604d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.653854931578511d,

0.06843632966424762d,

0.7286803252758384d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7409142399118711d,

0.22423860385376493d,

0.07667900871811584d,

0.6828458305091587d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7986970005206238d,

0.37655503942245017d,

0.9969361875652951d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1628761978284119d,

0.00925611180895336d,

0.5770610270874383d,

0.8477000571252475d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.816322667764172d,

0.893408092943597d,

0.5351126617347222d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.15633990092899508d,

0.28340767401567446d,

0.8034748521211011d,

0.9811068374118257d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.542750214217559d,

0.6213717664387125d,

0.9056692074975694d,

0.3690563352176728d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36592469934813443d,

0.8451451593158062d,

0.7247545162936105d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4388864096139826d,

0.061382688810110886d,

0.01026749567975116d,

0.0846124553042229d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.589155500154919d,

0.787487160604208d,

0.7768329127768437d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7644775255947114d,

0.8785521019387473d,

0.9264938185225261d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.02919436110034579d,

0.955676628455005d,

0.5338045973581808d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.30413698131392497d,

0.04960512323194588d,

0.06399096386628556d,

0.9382146490530924d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7466310592265986d,

0.18050907341440503d,

0.5627394192552432d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809627407371627d,

0.015705743072148337d,

0.16564349964088654d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48779804787381875d,

0.8464320690169639d,

0.277218293271403d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19782211550663464d,

0.37462453441584365d,

0.33480209390702975d,

0.5663622594099577d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.859800434789725d,

0.8162841427955969d,

0.4269589533144569d,

0.0946341129411098d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2804498502660153d,

0.7045238359535793d,

0.17954675416641697d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6885082224812955d,

0.27770986082577076d,

0.8074805929395643d,

0.013872414532531407d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8537772684505255d,

0.2650428536564672d,

0.7908911855275632d,

0.5155798445997551d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2415148514564337d,

0.044796464154001736d,

0.6644938119672885d,

0.5883528466876753d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.49373102409523906d,

0.5859479440154988d,

0.9463316329663817d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5633755830243744d,

0.8742468991592688d,

0.7912077837931396d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8975624305551884d,

0.38987901506890843d,

0.3960148343530373d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6514310725166068d,

0.9067151111349416d,

0.23655208922798598d,

0.6813484376343774d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5282986059183058d,

0.5072993464745598d,

0.23844002352214566d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6854928478895203d,

0.12102870883787709d,

0.8834168125194013d,

0.8696984523851711d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.23263586907213252d,

0.3007723309789616d,

0.38335913163335245d,

},
    ModelInner = new Doubledouble_precisionListD12MI
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9510611754776545d,

0.708693130728827d,

0.006134456322874016d,

0.45682749354882113d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7110579051062248d,

0.9291028842595636d,

0.7265463234182832d,

0.22150732553210528d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.80631691084707d,

0.902517993512229d,

0.45827555776260165d,

0.9189092561407666d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5823146748799782d,

0.28438388216098087d,

0.8514999836625851d,

0.787094524249178d,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd12mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
INSERT INTO public.doubledouble_precisionlistd12mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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

                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd12mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)), 
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
                methodParametrName: "doubledouble_precisionlistd12mi_id", 
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
                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd12mi_id
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
    doubledouble_precisionlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd12mi_id
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
    doubledouble_precisionlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                methodParametrName: "doubledouble_precisionlistd12mi_id", 
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
                List<Doubledouble_precisionListD1E2M> models = null;

                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionListD1E2M> models = null;

                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd12mi mi ON mi.id = m.doubledouble_precisionlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd12mi mi ON mi.id = m.doubledouble_precisionlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleListdouble_precisionListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd12mi mi ON mi.id = m.doubledouble_precisionlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 18, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 168, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 86, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 40, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 105, query1, 40, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 70, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 47, query1, 132, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
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
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 40, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd12mi mi ON mi.id = m.doubledouble_precisionlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 86, 159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[34], false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatch(connection, 155, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[29],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[30],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[31],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[32],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((IDoubleListdouble_precisionListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 159);
                var models = await ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[30], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[31], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[32], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[33], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 138);
                var models =  ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[26], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[27], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[28], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[29], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[30], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[31], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[32], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[33], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[34], false);
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
FROM public.binary_doubledouble_precisionlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD12MIWA),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD12MI),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD12MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD12MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionlistd12mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionListD1E2M),
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
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
FROM public.binary_doubledouble_precisionlistd1e2m m
LEFT JOIN public.binary_doubledouble_precisionlistd12mi mi ON mi.id = m.doubledouble_precisionlistd12mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionListD1)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionlistd12mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models =  ((IDoubleListdouble_precisionListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD12MIWA), typeof(Doubledouble_precisionListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models1 = new List<Doubledouble_precisionListD12MIWA>();
                var models2 = new List<Doubledouble_precisionListD12MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD12MIWA>();
                var models2 = new List<Doubledouble_precisionListD12MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionlistd12mi
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
                    Doubledouble_precisionListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionlistd12mi
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
                    Doubledouble_precisionListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD12MIWA), typeof(Doubledouble_precisionListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models1 = new List<Doubledouble_precisionListD12MIWA>();
                var models2 = new List<Doubledouble_precisionListD12MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD12MIWA>();
                var models2 = new List<Doubledouble_precisionListD12MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionlistd12mi
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
                    Doubledouble_precisionListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionlistd12mi
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
                    Doubledouble_precisionListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD12MI), typeof(Doubledouble_precisionListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models1 = new List<Doubledouble_precisionListD12MI>();
                var models2 = new List<Doubledouble_precisionListD12MI>();
                await ((IDoubleListdouble_precisionListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD12MI>();
                var models2 = new List<Doubledouble_precisionListD12MI>();
                ((IDoubleListdouble_precisionListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
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
                var models = await ((IDoubleListdouble_precisionListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD12MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD12MIWA), typeof(Doubledouble_precisionListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models1 = new List<Doubledouble_precisionListD12MIWA>();
                var models2 = new List<Doubledouble_precisionListD12MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionListD12MIWA>();
                var models2 = new List<Doubledouble_precisionListD12MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
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
                var models = await ((IDoubleListdouble_precisionListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleListdouble_precisionListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

