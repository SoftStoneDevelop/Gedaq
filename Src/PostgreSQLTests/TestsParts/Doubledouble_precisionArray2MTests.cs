

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
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9118095173227458d,

0.8631592819013358d,

0.8403518566611372d,

0.9213416100070727d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4255029379241314d,

0.10028052064146953d,

0.49902117647764643d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9896566991020966d,

0.8638467451531184d,

0.9910154576590708d,

0.5857757940118271d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5418321652608429d,

0.911801113203963d,

0.1052132618074616d,

0.8675738521522782d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3910269531880253d,

0.8758164604419416d,

0.9381263912877894d,

0.5474809802706274d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5353509763478456d,

0.610764092896059d,

0.8325952662420162d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.08885078440124705d,

0.9280962194581835d,

0.992811447476196d,

0.7475134063116396d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.28179004087381365d,

0.8407007793188154d,

0.2850569200941263d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.09210150197973799d,

0.14519614322773688d,

0.007861148371593352d,

0.8850052979973766d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6453051097349637d,

0.3487939341694243d,

0.7678583023815299d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2550172210257706d,

0.6011730813149313d,

0.7471430644038294d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.46404824978984827d,

0.5770841862558324d,

0.7962257022970342d,

0.8975423854903861d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9129276301474855d,

0.6717466668389296d,

0.5025494630837068d,

0.9490212243440463d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5329824539621609d,

0.677565326357953d,

0.8474768431526372d,

0.7522124644912381d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7262668306393916d,

0.3115604282791552d,

0.1220345768437806d,

0.8638154771670187d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.795309415067283d,

0.9455947192669d,

0.9263983089751091d,

0.9484249299328781d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7633475001701908d,

0.7559580570803254d,

0.2570903572953023d,

0.10467301596517653d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4135576291922607d,

0.32710352725255387d,

0.9669311850455145d,

0.05074094765988013d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8307429307686924d,

0.8716491807661121d,

0.1326217640595434d,

0.6789351042728043d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6779260601281006d,

0.45834432414343296d,

0.6959760026901153d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9551719063013938d,

0.5071963750288103d,

0.9783358558073486d,

0.6444876552688975d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.06919238731469479d,

0.7686789652190854d,

0.2977892971602253d,

0.7034453804481193d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2690284509837333d,

0.5777617253102524d,

0.6965962239215214d,

0.13704886924563164d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1085484334578054d,

0.08905063109983147d,

0.15238946767448214d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.10098762443560327d,

0.05035342865521153d,

0.04438849044384141d,

0.9129388527941136d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9067956580474302d,

0.9820242393571575d,

0.0028855643885341564d,

0.624692363446521d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.20763135192715576d,

0.52189811119005d,

0.7725149032809321d,

0.404531285583854d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5980904612468482d,

0.4761053452847793d,

0.17292045051881566d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.28750526565866286d,

0.26202766256383403d,

0.6101782386783181d,

0.6340948472722363d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8726012227416827d,

0.17521422750777094d,

0.14653504944990725d,

0.2753800149738551d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9957810712229114d,

0.6373821196198518d,

0.01152720674275165d,

0.6310015840447492d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7881810365924284d,

0.44994254748276064d,

0.5861479905234513d,

0.767934256133542d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9737726295287864d,

0.9058791264321691d,

0.6160126185344608d,

0.05830235834610953d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.840745038118158d,

0.5348144810114716d,

0.629745936842809d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.12511395988194063d,

0.9469625112472008d,

0.8070793778131347d,

0.26680407770712233d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29249514488403483d,

0.2421428849474584d,

0.513395677702531d,

0.8780181914230026d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8433720801451801d,

0.0679852073319327d,

0.38171737558982677d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.981557055964959d,

0.8991454089196896d,

0.06149243570200513d,

0.38941336305466856d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4002149932374255d,

0.4812172461934793d,

0.1439717881464151d,

0.4954994270655282d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3015644439269277d,

0.6795234224047669d,

0.40222268665346217d,

0.11499515849625797d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.06457589597802049d,

0.6637540208456884d,

0.663138036259868d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7604751041534634d,

0.08010766764782684d,

0.7448948401753066d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.41285748841687486d,

0.9010782646510443d,

0.3654007668440561d,

0.4753291719603787d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.878884909210665d,

0.7934773193653025d,

0.676536533832788d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9741707021056663d,

0.09268145837075525d,

0.10650669617861519d,

0.00755762523373682d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7004079995640151d,

0.5348810122629347d,

0.654588537284125d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5747307050247255d,

0.9927775340015623d,

0.6557403423773975d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2101131346022782d,

0.834181303236062d,

0.2757218305229453d,

0.18960283399199696d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0737697006996223d,

0.007103786704774517d,

0.00018425609323591274d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7653631711496215d,

0.38596263539857145d,

0.3970896741606744d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.20156490143436523d,

0.6874402435918506d,

0.9615497162909145d,

0.8486522509985527d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.44434820181478163d,

0.546171221868056d,

0.0014908822070590633d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9810640038026011d,

0.4108411513980421d,

0.28670218143383175d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.38871187900836757d,

0.19073608584993407d,

0.43705419546126856d,

0.23669963202937294d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.21928854002619913d,

0.7403274242550241d,

0.28286500316849295d,

0.7447386538191613d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.44940339691770437d,

0.6785915411697362d,

0.7158747717775695d,

0.8706487489051346d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.16741352701647627d,

0.19013378995674723d,

0.17936556787358238d,

0.1014132856646135d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6717964448841994d,

0.29455406558734d,

0.54396898958784d,

0.49388160051703445d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.19320259656503325d,

0.8968771806626319d,

0.7037541992504665d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.13181415490136772d,

0.9166917202330309d,

0.7669594443427753d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5560015581898172d,

0.6422716285783926d,

0.5018424584461593d,

0.6784892706734057d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.23320711007219208d,

0.8471249213096697d,

0.31748676245079943d,

0.15644180806582353d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7839998186723133d,

0.36037395508427605d,

0.5073902002436314d,

0.5506810921599071d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9504513480663465d,

0.14551747882815425d,

0.18324522779582664d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7640952463598886d,

0.7161912477971308d,

0.19734246168599268d,

0.6477693663053007d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8607689017395597d,

0.12391430137484016d,

0.5139123329805769d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5422174793381016d,

0.6516299041568746d,

0.6499633590843765d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4025166554518932d,

0.5890476711272447d,

0.4553122952463653d,

0.9884916778877186d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6885892444143916d,

0.15090652490934964d,

0.821908603532171d,

0.6759258788831067d,

},
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 9, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 132, query1, 87, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 152, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 80, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 56, query1, 112, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 9, query1, 56, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 24, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 69, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 92, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 160, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[29], false);
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
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 160);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[8], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[21],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[22],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDoubleListdouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
                await ((IDoubleListdouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray2M>(15);

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
                ((IDoubleListdouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IDoubleListdouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[14], false);
                Doubledouble_precisionArray2M.AssertModel(models[15],_testData[15], false);
                Doubledouble_precisionArray2M.AssertModel(models[16],_testData[16], false);
                Doubledouble_precisionArray2M.AssertModel(models[17],_testData[17], false);
                Doubledouble_precisionArray2M.AssertModel(models[18],_testData[18], false);
                Doubledouble_precisionArray2M.AssertModel(models[19],_testData[19], false);
                Doubledouble_precisionArray2M.AssertModel(models[20],_testData[20], false);
                Doubledouble_precisionArray2M.AssertModel(models[21],_testData[21], false);
                Doubledouble_precisionArray2M.AssertModel(models[22],_testData[22], false);
                Doubledouble_precisionArray2M.AssertModel(models[23],_testData[23], false);
                Doubledouble_precisionArray2M.AssertModel(models[24],_testData[24], false);
                Doubledouble_precisionArray2M.AssertModel(models[25],_testData[25], false);
                Doubledouble_precisionArray2M.AssertModel(models[26],_testData[26], false);
                Doubledouble_precisionArray2M.AssertModel(models[27],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[28],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

