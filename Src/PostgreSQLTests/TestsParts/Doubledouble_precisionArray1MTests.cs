

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
    Id = 6,
    Value = 
new System.Double[3]
{
0.15910347555682602d,
0.9949953740170805d,
0.7177909841096849d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.8529239229791451d,
0.8999770884950062d,
0.8695372041770296d,
0.16111159719050616d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 14,
    Value = 
new System.Double[3]
{
0.02337197410163394d,
0.9291225509841208d,
0.43634701243442875d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 4,
    Value = 
new System.Double[4]
{
0.09226549793018946d,
0.3770034582832825d,
0.1928808102083509d,
0.6603685101673066d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 15,
    Value = 
new System.Double[4]
{
0.3647951203493702d,
0.3815060314376504d,
0.8882613050186878d,
0.08986442931838756d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.1972987660244253d,
0.3796210324643521d,
0.2977334908114788d,
0.11982092274813261d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 18,
    Value = 
new System.Double[4]
{
0.6953533249680786d,
0.1020272235027857d,
0.25622957015260384d,
0.6495326422355698d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 9,
    Value = 
new System.Double[4]
{
0.8566175366201549d,
0.21751446390253182d,
0.5440759595824198d,
0.3003237515821672d,
},
    NullableValue = 
new System.Double[3]
{
0.4451947570159319d,
0.9769544719757817d,
0.5853307198626216d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 25,
    Value = 
new System.Double[3]
{
0.5317549343074399d,
0.7364904014611775d,
0.7710517894914337d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 31,
    Value = 
new System.Double[4]
{
0.8418118060671178d,
0.26804897425787755d,
0.8596366548016394d,
0.4666640832028335d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 18,
    Value = 
new System.Double[3]
{
0.034085909835329886d,
0.04432689230897213d,
0.3370644896811421d,
},
    NullableValue = 
new System.Double[4]
{
0.1645168512229177d,
0.6199834811054343d,
0.473301521081289d,
0.12236456900449788d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 37,
    Value = 
new System.Double[3]
{
0.5655561586133029d,
0.44125798679360173d,
0.11081855231066484d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.6326761921699652d,
0.02517869062021505d,
0.6985905788164621d,
0.25257839136724647d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 46,
    Value = 
new System.Double[3]
{
0.5417140225818794d,
0.35535919081553446d,
0.4400088150325181d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 22,
    Value = 
new System.Double[4]
{
0.5085135556522336d,
0.9207433819597564d,
0.7340625090067752d,
0.15663453494078605d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 54,
    Value = 
new System.Double[4]
{
0.3558743538518655d,
0.9915902401890969d,
0.7786734634492609d,
0.5791657575939428d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 63,
    Value = 
new System.Double[3]
{
0.6377996365974444d,
0.5099385045750561d,
0.07236705073064909d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 27,
    Value = 
new System.Double[3]
{
0.27659718326958516d,
0.8111807247485588d,
0.2018602965584183d,
},
    NullableValue = 
new System.Double[4]
{
0.29145388184575893d,
0.45903132278295355d,
0.6753061143692839d,
0.9870675205847647d,
},
},
    NullableValue = 
new System.Double[3]
{
0.5868585716671548d,
0.7608413643854979d,
0.49040400663078276d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 72,
    Value = 
new System.Double[3]
{
0.6258822580461794d,
0.3689043987063889d,
0.9819450667627085d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 78,
    Value = 
new System.Double[4]
{
0.10267575222531855d,
0.8396065512379746d,
0.18693673945445888d,
0.6639640295464455d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 32,
    Value = 
new System.Double[4]
{
0.9985911852016436d,
0.8488822228427779d,
0.4743620977818215d,
0.5874914937258612d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 80,
    Value = 
new System.Double[4]
{
0.7447373209077933d,
0.8524763174793367d,
0.5116174258684293d,
0.025271079118424078d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.8976653659770958d,
0.052770333511090284d,
0.9289861847391363d,
0.0805993702704918d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 82,
    Value = 
new System.Double[3]
{
0.9999929334425999d,
0.891764184882836d,
0.6802570485965173d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 38,
    Value = 
new System.Double[4]
{
0.9850287354703462d,
0.7305385467687224d,
0.9306108442584957d,
0.7664863476084308d,
},
    NullableValue = 
new System.Double[3]
{
0.6000471714989519d,
0.3055754187241132d,
0.41214138544199364d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 89,
    Value = 
new System.Double[4]
{
0.8840212731668056d,
0.7534158454915941d,
0.6931732877052923d,
0.17793162450185807d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 90,
    Value = 
new System.Double[3]
{
0.16957204275229398d,
0.5225482854839192d,
0.047165341651487114d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 44,
    Value = 
new System.Double[4]
{
0.15143111774422113d,
0.2537663678494244d,
0.8667180033225379d,
0.5207961182555501d,
},
    NullableValue = 
new System.Double[3]
{
0.5254914614384342d,
0.04989801662772808d,
0.09686800338107071d,
},
},
    NullableValue = 
new System.Double[3]
{
0.16675887662439504d,
0.20539586554849898d,
0.3886350488377034d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 94,
    Value = 
new System.Double[3]
{
0.5156321856301528d,
0.5799195019449794d,
0.14934702039061565d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 101,
    Value = 
new System.Double[4]
{
0.005312397070296404d,
0.22883499862467283d,
0.20162515321689123d,
0.6649845772745198d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 46,
    Value = 
new System.Double[4]
{
0.6950243995857098d,
0.5422977127002765d,
0.4332537602552433d,
0.017997829166551793d,
},
    NullableValue = 
new System.Double[4]
{
0.7379614721410981d,
0.6740463403353517d,
0.9748540840852667d,
0.5088808919292624d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 102,
    Value = 
new System.Double[3]
{
0.5566243766437373d,
0.6093260375819184d,
0.1752462927478896d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.36903430590983655d,
0.16267530837847732d,
0.8867936550231948d,
0.8685208408841544d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 104,
    Value = 
new System.Double[4]
{
0.19394204843044072d,
0.4989369780308901d,
0.655471346479098d,
0.7301495955770421d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 47,
    Value = 
new System.Double[4]
{
0.5377876890344577d,
0.0280968540672778d,
0.378389099119385d,
0.37400212855368964d,
},
    NullableValue = 
new System.Double[3]
{
0.6393189609365d,
0.34460827445897557d,
0.47673031480009287d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 111,
    Value = 
new System.Double[3]
{
0.10190134935087314d,
0.027079576846194664d,
0.04121849751826445d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.9924034618427896d,
0.1443708890173816d,
0.3871709513610134d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 117,
    Value = 
new System.Double[3]
{
0.08237518118101417d,
0.37019928585665474d,
0.17378276266386328d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 48,
    Value = 
new System.Double[4]
{
0.8758157275104169d,
0.5096096128036184d,
0.9439547916254682d,
0.4599899222753736d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 123,
    Value = 
new System.Double[3]
{
0.8060457538317681d,
0.08973591828069993d,
0.7570642107889365d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.8179163904003021d,
0.17743712777195553d,
0.8048456409921849d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 125,
    Value = 
new System.Double[4]
{
0.44797058905848475d,
0.5065390134455217d,
0.2166295018347375d,
0.7336253286465171d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 52,
    Value = 
new System.Double[3]
{
0.4959925035332913d,
0.6892707225713852d,
0.7208684379732754d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 131,
    Value = 
new System.Double[4]
{
0.5518528344950382d,
0.05040277057029441d,
0.04337541429617364d,
0.36701599304099597d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.40962561075735815d,
0.20975352671435366d,
0.10935518879817085d,
0.3366985076364667d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 137,
    Value = 
new System.Double[4]
{
0.20249586685129173d,
0.8283102289140549d,
0.3832130866042027d,
0.27663703373946613d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 53,
    Value = 
new System.Double[3]
{
0.9007923373790659d,
0.8797619450777655d,
0.177649590948466d,
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
0.031132891588500966d,
0.5334730397665485d,
0.156635484052016d,
0.8245350360459386d,
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
0.7264258951571158d,
0.12673509939337724d,
0.7019161454877778d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 58,
    Value = 
new System.Double[3]
{
0.5623656473311075d,
0.3123228858529503d,
0.5681757841529008d,
},
    NullableValue = 
new System.Double[3]
{
0.41044766000739563d,
0.8409641706472845d,
0.27782086764356917d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 147,
    Value = 
new System.Double[3]
{
0.7008025392818434d,
0.2475391091755016d,
0.3679639989695054d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.19883361458110538d,
0.013677544190539237d,
0.18131733901412228d,
0.5218706620942937d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 149,
    Value = 
new System.Double[3]
{
0.6938344744436862d,
0.7138502439510923d,
0.7903980845540102d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 60,
    Value = 
new System.Double[3]
{
0.7750705469092756d,
0.965745500616809d,
0.02780426222910448d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 152,
    Value = 
new System.Double[4]
{
0.661546305528076d,
0.9759628676088806d,
0.2379556487284069d,
0.5859639145979917d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.8353291596502661d,
0.5729635478898996d,
0.7763198365607547d,
0.1432271955532426d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 158,
    Value = 
new System.Double[4]
{
0.6958438651174038d,
0.1226811904391939d,
0.9196401314425097d,
0.5291816374010219d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 62,
    Value = 
new System.Double[3]
{
0.5169181386525398d,
0.956377909596731d,
0.1314809096276922d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 160,
    Value = 
new System.Double[4]
{
0.0420639503103708d,
0.35531687855209493d,
0.5500638863618553d,
0.4895856057310861d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 168,
    Value = 
new System.Double[3]
{
0.9611753909671306d,
0.4760833956036321d,
0.9260553205453605d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 68,
    Value = 
new System.Double[3]
{
0.46771059893631084d,
0.4576210336129727d,
0.8769993800568036d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 170,
    Value = 
new System.Double[4]
{
0.9762078305310361d,
0.9148225954147261d,
0.9021368369965277d,
0.560007473885153d,
},
    ModelInner = null,
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.6326761921699652d,
0.02517869062021505d,
0.6985905788164621d,
0.25257839136724647d,
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
new System.Double[3]
{
0.5868585716671548d,
0.7608413643854979d,
0.49040400663078276d,
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
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
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
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[34], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[34], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 63, query1, 37, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 78, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[34], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 137, query1, 89, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[34], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 80, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
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
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 160, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[34], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 63, query1, 78, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 37, query1, 152, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[34], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 142, query1, 14, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 104, 131))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 131, 158))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[34], false);
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
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 149);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[30], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[31], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[32], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[33], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[29], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[30], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[31], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[32], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[33], false);Doubledouble_precisionArray1M.AssertModel(models[21],_testData[34], false);
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
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
            dbTypes: null,
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
            dbTypes: null,
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
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
            dbTypes: null,
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
            dbTypes: null,
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

