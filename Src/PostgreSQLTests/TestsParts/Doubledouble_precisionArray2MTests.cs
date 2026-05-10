

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6591895028231888d,

0.9120828010353847d,

0.23932265298936328d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6493125756315465d,

0.44625373853430816d,

0.16782114436743278d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07764522869789658d,

0.38563929510341033d,

0.41571147842148903d,

0.4167981995482761d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6987176489630693d,

0.8769421262983578d,

0.08135037379214483d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6883299600396041d,

0.2492943944922802d,

0.8688114941160672d,

0.5514125465833675d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12147589103239864d,

0.6615939136753213d,

0.08182875200648798d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33197373427212584d,

0.7263222908171877d,

0.5150368986855725d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2940956703194191d,

0.16216547451829222d,

0.9644372954130933d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7292612949485319d,

0.16362492636094927d,

0.8014897686737884d,

0.4827112099239703d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.87086294198902d,

0.33587494396007167d,

0.35652419575081096d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16998473856630836d,

0.7862560190807715d,

0.35963206369788425d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4764764989095561d,

0.9343851417431275d,

0.07497610910885588d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7701886700819849d,

0.189540724871043d,

0.7598574837739397d,

0.3149870862006888d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.73390933879038d,

0.3081196965638143d,

0.8942180809385233d,

0.7827368086707547d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.37082966120042193d,

0.33708897351566103d,

0.11656042863355709d,

0.6328678242393011d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7265691666098455d,

0.6585122296122028d,

0.29286763429328333d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9532806225619428d,

0.9788149408697887d,

0.899138984997797d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6221023472845622d,

0.7984275321674763d,

0.33955050023708355d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.564553318398374d,

0.28255608582376424d,

0.6421033504078049d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.25754646009390514d,

0.016572211453928176d,

0.7337101223286372d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4597965923001661d,

0.27890395710755955d,

0.8663511165740462d,

0.6154990215293403d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29086346940685603d,

0.8421275952847822d,

0.9519601624986841d,

0.9800149284498022d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7408535932451488d,

0.8864120225841267d,

0.5219459672292228d,

0.4490852029898147d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.11654245799471175d,

0.5756495303163053d,

0.5158909820945066d,

0.14645766894064127d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.20806781848357814d,

0.9375914180270046d,

0.4630880333286287d,

0.8392511762494195d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4026923811060572d,

0.037215389184969805d,

0.47582548057727336d,

0.16185261404623075d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1014749856409719d,

0.9653916782499526d,

0.6777814212182692d,

0.5720788373503711d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.45417909898128284d,

0.38807169362416727d,

0.5623332002415825d,

0.40742035767975515d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9758376250918125d,

0.08254972267768834d,

0.29669824804525835d,

0.9769566290604075d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.859253788277271d,

0.912422603737826d,

0.2129363398981109d,

0.22544421930838976d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.26143891785023843d,

0.9960545801338613d,

0.7140603254346649d,

0.5605317077111085d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8470101019811046d,

0.1979679582052808d,

0.03278443447435431d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1653954678276769d,

0.36469377548553383d,

0.3597919091389574d,

0.3232564624901465d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4241500515717185d,

0.5941717873572544d,

0.28762148932512044d,

0.5470018044331035d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7223736909896653d,

0.030544337053007076d,

0.7103091637947015d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4164714449461441d,

0.4942839385715607d,

0.3693307810789417d,

0.4404626878024721d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.629727360775739d,

0.26162216008948835d,

0.18206919178905223d,

0.8425329874735771d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2861098909994291d,

0.9523224125560116d,

0.7862894864793734d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6002392126330279d,

0.04195461021402669d,

0.73424695766583d,

0.5069927561700086d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18810286382843155d,

0.3647326455935712d,

0.31695186681352083d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2061797823386592d,

0.18454493317408693d,

0.2839576567703245d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7480234109894355d,

0.5707939525618512d,

0.38874916083759337d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3669498528464682d,

0.7325840610180504d,

0.975043858614595d,

0.4682623539976444d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7502492486134047d,

0.010129619624258845d,

0.6577107496573315d,

0.14995069873029954d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.95309199622621d,

0.9153992661757688d,

0.20744387407928688d,

0.40934345216977497d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7008341792814806d,

0.519393995449747d,

0.5447558808145304d,

0.8171268082186244d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.0024122124099528186d,

0.7256723271421252d,

0.9896165131135646d,

0.5834596495205703d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8971986123021028d,

0.8149330203775038d,

0.9766969624718046d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.061775188451484d,

0.14530691367776816d,

0.05508494964449839d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5337586303184768d,

0.3528581067830434d,

0.01827039119778895d,

0.32544479688310046d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5817981893839025d,

0.8626274977887153d,

0.5007572562486681d,

0.6020403174657806d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7112069091388584d,

0.6808746793352043d,

0.9622721300866222d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8333562301326685d,

0.4235745170208999d,

0.6408410873810181d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6562584355422383d,

0.4286147304971569d,

0.05921661086623664d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6384398962998946d,

0.3420295935688288d,

0.6574767319244913d,

0.47004648002736904d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7638984031039702d,

0.2482303417819488d,

0.9829102115906031d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7016777264701112d,

0.22847195123529063d,

0.8264712899179533d,

0.7963917427641717d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9962279215113856d,

0.4440708533791572d,

0.7535686324554118d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.10400754396161993d,

0.0964839301101974d,

0.10772290169745569d,

0.6377080600167935d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8128948629285424d,

0.1413464442816823d,

0.5646557938038731d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8028817676055292d,

0.34936798186332496d,

0.7611625946901607d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.831147447288966d,

0.6229659895530112d,

0.20508432555571776d,

0.687369845161291d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8732133987095995d,

0.6773313374609543d,

0.7828122941772875d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.41039287103598854d,

0.8095220703428985d,

0.39134956443907143d,

0.8153898618726366d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3110456868389372d,

0.46387856405579286d,

0.5958927709927024d,

0.34164598414014935d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5897712310515472d,

0.4031912289718964d,

0.765403578417243d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8771400436431136d,

0.42076030954561516d,

0.907076634033628d,

0.9738340281113337d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.05983589168976222d,

0.863802450095284d,

0.5275250072509426d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.44872515420001113d,

0.07813717588510061d,

0.6387960958140789d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.13846178440183476d,

0.30011951970011463d,

0.9735185034730721d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9540640588451117d,

0.7664233722188412d,

0.21426077823080503d,

0.9803089946490409d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2766604271384766d,

0.24155113292537334d,

0.7663164030780559d,

0.4959374095518302d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.1293618173434119d,

0.22022329285801545d,

0.11147993747592677d,

0.040014252041920995d,

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
                parametr1.Value = 1;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[33],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[32],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 70;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 70, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 130, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 70, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 65, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 95, query1, 130, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 1, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 12, query1, 1, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[29],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[30],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[31],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[32],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[33],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 162, query1, 115, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 19, 50))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 149, 97))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[34], false);
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
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 86);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 1);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

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
                Doubledouble_precisionArray2M.AssertModel(models[29],_testData[30], false);
                Doubledouble_precisionArray2M.AssertModel(models[30],_testData[31], false);
                Doubledouble_precisionArray2M.AssertModel(models[31],_testData[32], false);
                Doubledouble_precisionArray2M.AssertModel(models[32],_testData[33], false);
                Doubledouble_precisionArray2M.AssertModel(models[33],_testData[34], false);
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

