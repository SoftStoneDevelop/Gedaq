

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
    internal partial interface IDecimalMArraynumericMMArrayD1
    {
    }
    
    internal partial class DecimalMArraynumericMMArrayD1 : IDecimalMArraynumericMMArrayD1
    {


#region TestData

        private readonly DecimalnumericMMArrayD1E1M[] _testData = new DecimalnumericMMArrayD1E1M[]
        {
            new DecimalnumericMMArrayD1E1M
{
    Id = 4,
    Value = 
new System.Decimal[3]
{
0.0357700356432838m,
0.0217625672817964m,
0.0531829857459692m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 7,
    Value = 
new System.Decimal[4]
{
0.682760024602286m,
0.815831093749308m,
0.0294624507133685m,
0.307534636131718m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Decimal[4]
{
0.917545627101883m,
0.523450336735088m,
0.864935751292159m,
0.395033175336487m,
},
    NullableValue = 
new System.Decimal[4]
{
0.639424499374148m,
0.710376255505393m,
0.672387770914357m,
0.636709881021043m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.212979154591543m,
0.195240494843574m,
0.694843849695503m,
0.963262971251199m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 10,
    Value = 
new System.Decimal[4]
{
0.670186213758566m,
0.797566160307757m,
0.89512649171146m,
0.862006499378757m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Decimal[3]
{
0.688624785314432m,
0.124771854566005m,
0.771969004228559m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Decimal[4]
{
0.680234467411772m,
0.156849678207377m,
0.571324702684736m,
0.230767073317534m,
},
    NullableValue = 
new System.Decimal[4]
{
0.139014363742379m,
0.277392022744401m,
0.316945050784641m,
0.287386979407851m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Decimal[3]
{
0.288853344876856m,
0.608635118005871m,
0.696401656127435m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Decimal[3]
{
0.451068722951951m,
0.28276684495364m,
0.0276229783548805m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.Decimal[4]
{
0.729910858094048m,
0.805367351756459m,
0.460960472530627m,
0.864375116127622m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.535145687946213m,
0.498453309106427m,
0.601149032684756m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Decimal[3]
{
0.576092522430753m,
0.168655999410377m,
0.332696947770609m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.504242159608115m,
0.383366429216491m,
0.484718789574256m,
0.783941180301578m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Decimal[4]
{
0.675743740382347m,
0.63036988220985m,
0.907961457294712m,
0.0669147850689251m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Decimal[3]
{
0.771480468842852m,
0.72606017069718m,
0.949785096034004m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 37,
    Value = 
new System.Decimal[3]
{
0.285715432498376m,
0.186023311404855m,
0.594790141778807m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Decimal[4]
{
0.266635884230332m,
0.651087057342255m,
0.231714148945683m,
0.907072335710968m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 28,
    Value = 
new System.Decimal[4]
{
0.0584011021173666m,
0.56127734501569m,
0.827271013654942m,
0.985266564248263m,
},
    NullableValue = 
new System.Decimal[4]
{
0.342508300939538m,
0.675648777850207m,
0.515369249073513m,
0.413367772889408m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.482300837705333m,
0.714298538898342m,
0.507068629575599m,
0.802134306075132m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Decimal[4]
{
0.0392387706834563m,
0.91422022031102m,
0.154369182157597m,
0.163844982010423m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.381058613847708m,
0.100925109520455m,
0.683264633239223m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 51,
    Value = 
new System.Decimal[4]
{
0.0533920906068042m,
0.147554936512686m,
0.509858844362119m,
0.571042043297192m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Decimal[4]
{
0.0289150940387483m,
0.14985389047432m,
0.526861359339803m,
0.931986204904176m,
},
    NullableValue = 
new System.Decimal[4]
{
0.262636534729745m,
0.305810383186068m,
0.951847025388982m,
0.221057940292628m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.770540485508898m,
0.851018412014389m,
0.424489341511314m,
0.448859268345369m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Decimal[3]
{
0.38277388012059m,
0.45058747698442m,
0.878326187868302m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 58,
    Value = 
new System.Decimal[4]
{
0.63888718685155m,
0.0394812213520938m,
0.159047218600115m,
0.0955282748908669m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Decimal[4]
{
0.477445267781994m,
0.717395399742344m,
0.503025999345652m,
0.739444412404835m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 63,
    Value = 
new System.Decimal[4]
{
0.853247339390595m,
0.19146014675929m,
0.357377873865884m,
0.18871354200399m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Decimal[3]
{
0.277743961249693m,
0.393538723190929m,
0.614207634368568m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.Decimal[3]
{
0.129872667266494m,
0.126842382574729m,
0.987680106628956m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Decimal[4]
{
0.632091358608259m,
0.949615118361827m,
0.552550274876627m,
0.418888426086258m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Decimal[4]
{
0.0395242016088164m,
0.426109339259742m,
0.909248780409308m,
0.902656377522551m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Decimal[4]
{
0.471623943414775m,
0.721101344323527m,
0.13915606023591m,
0.522941184157163m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Decimal[4]
{
0.457781479207402m,
0.5327135880515m,
0.724268256779843m,
0.0449061375274761m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.586099462039692m,
0.395421393905972m,
0.61061308148796m,
0.89771390139261m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 79,
    Value = 
new System.Decimal[3]
{
0.29448823020961m,
0.374196048678219m,
0.917523524269073m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Decimal[3]
{
0.236692754323436m,
0.636712016588918m,
0.487373439808461m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.127057645517699m,
0.260993388305475m,
0.318314057321759m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 84,
    Value = 
new System.Decimal[4]
{
0.775490496271329m,
0.626332224371355m,
0.853018365713004m,
0.600002554323397m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.554767530949466m,
0.185467414245425m,
0.469050188454718m,
0.151977109515449m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Decimal[3]
{
0.649829435356054m,
0.0972385431320415m,
0.65458123970005m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Decimal[3]
{
0.388999580025585m,
0.916269331462719m,
0.559262448104523m,
},
    NullableValue = 
new System.Decimal[3]
{
0.604355612118171m,
0.394694519547677m,
0.203634089245363m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 98,
    Value = 
new System.Decimal[4]
{
0.114391231259484m,
0.623295413678067m,
0.763063897805797m,
0.955867632783048m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.770861461996809m,
0.126686122300826m,
0.116500457434771m,
0.848533278835517m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 107,
    Value = 
new System.Decimal[4]
{
0.173856890553742m,
0.419573525985267m,
0.272083613659805m,
0.738726986288309m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.Decimal[3]
{
0.621273950520366m,
0.30960123931651m,
0.80935548125912m,
},
    NullableValue = 
new System.Decimal[4]
{
0.626485244357024m,
0.834560868551407m,
0.885552822819028m,
0.74078496556159m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.268172955019766m,
0.193543048495722m,
0.856719127800304m,
0.696411417065058m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Decimal[3]
{
0.793877559333032m,
0.82805385771717m,
0.732834960175603m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.904536327595352m,
0.971437205991752m,
0.397330912883208m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 114,
    Value = 
new System.Decimal[4]
{
0.0254478204826408m,
0.880668995883549m,
0.461409952695992m,
0.93514637921566m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 71,
    Value = 
new System.Decimal[4]
{
0.44059484724978m,
0.8805184372876m,
0.280698254168658m,
0.82609678316076m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Decimal[3]
{
0.70096931951232m,
0.272208137233603m,
0.544492589639344m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.331243700934607m,
0.597057369995942m,
0.995066611279367m,
0.196474453364179m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Decimal[3]
{
0.839088859516185m,
0.271989880938668m,
0.516855420397234m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Decimal[4]
{
0.861648096959996m,
0.649243519564873m,
0.347592231652431m,
0.660057607612197m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Decimal[4]
{
0.287453131630708m,
0.301218244294524m,
0.0835626910032426m,
0.11537825329937m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.720603112980904m,
0.558337102596146m,
0.304069947420232m,
0.671540737320831m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Decimal[3]
{
0.176160821582505m,
0.826920525568082m,
0.84948436465947m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Decimal[4]
{
0.486883868993054m,
0.188809253996563m,
0.422854048291902m,
0.430602041100913m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Decimal[3]
{
0.748862454950637m,
0.9006003977322m,
0.60369111534179m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Decimal[3]
{
0.920992150829016m,
0.0594485147278532m,
0.325749352087361m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Decimal[3]
{
0.397928469972941m,
0.347512488887795m,
0.746479725351135m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.611359036355897m,
0.264367287837051m,
0.490606170517383m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 147,
    Value = 
new System.Decimal[3]
{
0.120469604620472m,
0.787449235635005m,
0.080311642855161m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.0310294755822977m,
0.521338728816098m,
0.399140151579742m,
0.169049732902663m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 152,
    Value = 
new System.Decimal[4]
{
0.000598649017221287m,
0.479531420823913m,
0.850443130280718m,
0.520835399505316m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 91,
    Value = 
new System.Decimal[3]
{
0.276185303733553m,
0.750163233872166m,
0.646845229990458m,
},
    NullableValue = 
new System.Decimal[4]
{
0.955408293930063m,
0.666028686270995m,
0.464688903537539m,
0.172162579234542m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.523362339684848m,
0.0718555170203942m,
0.358459941493569m,
0.831752663423884m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Decimal[3]
{
0.649866394843765m,
0.352131141810209m,
0.673647626091937m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.850010988549464m,
0.23053465577785m,
0.840728351298362m,
0.702046457048063m,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1mi(
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
INSERT INTO public.decimalnumericmmarrayd1e1mi(
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
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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

                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)), 
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
                methodParametrName: "decimalnumericmmarrayd1e1mi_id", 
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
                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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

                    nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.535145687946213m,
0.498453309106427m,
0.601149032684756m,
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

                    nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.504242159608115m,
0.383366429216491m,
0.484718789574256m,
0.783941180301578m,
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

                    nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                methodParametrName: "decimalnumericmmarrayd1e1mi_id", 
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
                nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.482300837705333m,
0.714298538898342m,
0.507068629575599m,
0.802134306075132m,
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
                nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.381058613847708m,
0.100925109520455m,
0.683264633239223m,
}));
                nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.770540485508898m,
0.851018412014389m,
0.424489341511314m,
0.448859268345369m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD1E1M> models = null;

                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD1E1M> models = null;

                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 43;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 84, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 147, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 63, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 79, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 70, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 58, query1, 112, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 98, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 10, 63))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 84, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((IDecimalMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 17);
                var models =  ((IDecimalMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MI),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericMMArrayD1E1M),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
FROM public.binary_decimalnumericmmarrayd1e1m m
LEFT JOIN public.binary_decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models =  ((IDecimalMArraynumericMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI), typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models1 = new List<DecimalnumericMMArrayD1E1MI>();
                var models2 = new List<DecimalnumericMMArrayD1E1MI>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MI>();
                var models2 = new List<DecimalnumericMMArrayD1E1MI>();
                ((IDecimalMArraynumericMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

