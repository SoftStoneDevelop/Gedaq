

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
    internal partial interface IInt64ListbigintArray
    {
    }
    
    internal partial class Int64ListbigintArray : IInt64ListbigintArray
    {


#region TestData

        private readonly Int64bigintArray2M[] _testData = new Int64bigintArray2M[]
        {
            new Int64bigintArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4080421715234061703L,

8541289331928917585L,

4464274764550214034L,

3435234389078233142L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3429515470829784697L,

7417788316875784792L,

6812725770418259509L,

6377744550403547704L,

},
},
            new Int64bigintArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9213382201258451902L,

6226249827883806588L,

2863840348464160068L,

4264639801377540978L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1646921384220778210L,

8061581329345894451L,

8112328539983279600L,

4947610622484869169L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4653906142732774175L,

7511090834043472344L,

2618899966140458850L,

119593045508536377L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6513217906415096770L,

3589636608962371082L,

3317127191950892218L,

},
},
            new Int64bigintArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7110088692093899553L,

5100574010761735203L,

6623717945299101278L,

7140326111345653704L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9081477016967617861L,

2466739010744041331L,

8164656255777778932L,

4642857624836124738L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2794655178049133029L,

8511963304930427978L,

6043066084029274012L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6965304889121419302L,

5919258936701462194L,

7837190181053158336L,

4064237958485562698L,

},
},
            new Int64bigintArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2300999253505903689L,

4787414489414384071L,

4984898600171512401L,

2655726656089244850L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8666188582213400291L,

7046410073586914316L,

6489859950149914431L,

},
},
            new Int64bigintArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1385132881967518638L,

5105079183686755409L,

8721454872072756861L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1359654623931679101L,

1645869344492042274L,

6439215332914338818L,

6975521631284180328L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6334537399063823036L,

4908068208237649506L,

414517688575296357L,

8638272277793186992L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4528521847716914743L,

9049164060347006188L,

6344045905492347023L,

},
},
            new Int64bigintArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8531679296441893039L,

2262320435339943420L,

885134407891821226L,

3747048319134972244L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5346199245091491589L,

403651187360908416L,

2299065018728183060L,

7335268574860756936L,

},
},
            new Int64bigintArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8023508954625776433L,

353729718948622979L,

8758134227130144478L,

8442729792447560507L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7457855115442310882L,

150180963744700583L,

1393292025864929552L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5562572679445486768L,

2443664207112743777L,

1869209162614542952L,

5451005962388936456L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3024653779777490877L,

113594596511136455L,

427603818504713783L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3534513696603974524L,

609232028961380178L,

6662233346575560154L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3995339220728120904L,

939181493285765079L,

6714813231476323838L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1068824030758808697L,

2584137184404085242L,

6875624179978442595L,

5503872119694423881L,

},
},
            new Int64bigintArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5593931106905149624L,

1631793630660497191L,

8325051886076158557L,

2883390511442454833L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8114139838884921516L,

4714526017499270145L,

6555617357813350203L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1349619916764371870L,

6588938327036784216L,

1729462948425422729L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8793147878366415575L,

9217284967128092309L,

4550836651824278215L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5686967929702486443L,

2433192122346321507L,

6193675469689266819L,

3735537702886720342L,

},
},
            new Int64bigintArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5540190036211089937L,

2008256344246492667L,

8649540398139482002L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3944442991034441337L,

411124960947528403L,

3572583332938474658L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2463462581933191540L,

1293759872577665786L,

8557792642364013864L,

8652498005703204574L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4756582682323507900L,

3181102524623404052L,

6332479496772768111L,

7164387411095129913L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6274819977832480632L,

15135000339477626L,

7674592173901402323L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3325920476731491909L,

1015917842215039362L,

5243449155365654262L,

},
},
            new Int64bigintArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1217126111690499792L,

7322078019963511947L,

291423224978513917L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5069244178521733040L,

7578704419565602009L,

2264371293876425376L,

4263140452350802558L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
270615283620880195L,

4188863027666956452L,

4267614020860227802L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8656581675454691361L,

6551529000171878938L,

727038563039663462L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7072176043721321795L,

2430242338167526926L,

9067659387700088591L,

3202006363533617005L,

},
},
            new Int64bigintArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
896958824153237761L,

1932821049280867489L,

6755048968870487167L,

882267184996038533L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4755023554197019453L,

6283060192722478563L,

2233501119396004665L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
189556250021909696L,

4637770280237272863L,

2923333429147242519L,

1415076512580404770L,

},
},
            new Int64bigintArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
7031507010743765385L,

8904650060970706063L,

8106388353910284291L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1365596316460979663L,

5738297963003883160L,

792524182202307183L,

267782308352310887L,

},
},
            new Int64bigintArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5388924510478098120L,

23142958935990250L,

8996942696520016312L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7682639910917928069L,

9084550999005595194L,

5244706542186829767L,

2952745642559615318L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6781873222739630991L,

8710252769218415123L,

4992945213044531382L,

8358011086990373012L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8416295958882097959L,

8930112115454855345L,

4946504171966431245L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
139245767783677867L,

215258268217083214L,

768933741915491646L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
97419799702640080L,

6376203016724761451L,

5006170449579921274L,

},
},
            new Int64bigintArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8748428014771265128L,

1590567056347721070L,

2018120494420362211L,

1592175672029303146L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8858689128022488535L,

140742302351646586L,

6198221334022164101L,

4947114203577701140L,

},
},
            new Int64bigintArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7833809905631990741L,

659831720670000687L,

8610777806446045815L,

2015133671271472677L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5267372247422053622L,

4486631291405107153L,

1050491408794234094L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3342162628460306817L,

7266497609253939452L,

5383809098961186675L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4578463721397735204L,

3431038278936163559L,

1621666120336033411L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8173623099802248288L,

1937346689952469060L,

7911551510590123126L,

971556393369172686L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1333099521268248717L,

8460717623421364862L,

313590144596100288L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2865269192681974469L,

4836152678100317773L,

9157870075570731925L,

},
},
            new Int64bigintArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3181302803907437628L,

836227027236092350L,

2460518756168099638L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1343113053585791667L,

874710938797819403L,

8171725974020573899L,

},
},
            new Int64bigintArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6624102178409070017L,

6175053029270345652L,

1108924679474832488L,

7849144543012465374L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8373379972882527159L,

3254244393955815600L,

6642140177856407386L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7252124093668619677L,

5678891354932908936L,

3356659188839298837L,

8889198362816949073L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3749335338583080588L,

3728905133920250920L,

7338925780844125169L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6546706106690779460L,

6327071474698461320L,

6100572749193631338L,

5932391996774559823L,

},
},
            new Int64bigintArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
286439488863787982L,

4299298923379700861L,

286518397373801477L,

2988020825903143815L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
354651083712192268L,

5892590076762877702L,

4101329077722896602L,

5426906312203480607L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1361151217066636543L,

6472068787745793282L,

4416553677157979878L,

4446608611317515931L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8712280574171988783L,

8333821182133568010L,

857026591679954574L,

},
},
            new Int64bigintArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5297084536473119060L,

6598883671768352779L,

788163446774125120L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6022970736321201665L,

5526552742644271566L,

9110177876349932717L,

8487792634810493698L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1309958983891186285L,

6197013110816005878L,

1242332896167081049L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6317460950704866773L,

4869741176475459630L,

3606991414088526830L,

},
},
            new Int64bigintArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4935312872949832153L,

6549465201345977951L,

3944442794326287826L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7574739273758797449L,

3784631699367587087L,

7683837778507324764L,

3431930385565444718L,

},
},
            new Int64bigintArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6425028514758067146L,

8795224454397056951L,

4009442038937957501L,

409246791558814939L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4865130323640887689L,

7522283698483182208L,

897889339192223423L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6597727873126769961L,

3148031541056581857L,

7792207052934265182L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1941923062785220830L,

502459240497579494L,

5830408388721523402L,

4857209312148390355L,

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2mi(
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
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2mi(
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
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
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

                changedRows =  ((IInt64ListbigintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ListbigintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ListbigintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ListbigintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ListbigintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ListbigintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
            asPartInterface: typeof(IInt64ListbigintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray2mi_id", 
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
                changedRows =  ((IInt64ListbigintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ListbigintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ListbigintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ListbigintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray2mi_id", 
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
                List<Int64bigintArray2M> models = null;

                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray2M> models = null;

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ListbigintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ListbigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ListbigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ListbigintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await ((IInt64ListbigintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ListbigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 141;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
                parametr2.Value = 41;
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 158;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await((IInt64ListbigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintArray2M.AssertModel(models[0],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintArray2M.AssertModel(models[0],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IInt64ListbigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintArray2M.AssertModel(models[0],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintArray2M.AssertModel(models[0],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M), typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                await((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 48, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 82, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray2M>();
                var models2 = new List<FlatInt64bigintArray2M>();
                ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 31, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var firstItems2 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 25, query1, 91, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 122, query1, 133, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[34], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 149, query1, 133, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 15, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[26],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[27],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[28],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[29],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[30],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[34], false);
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
FROM public.int64bigintarray2m m
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
FROM public.int64bigintarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems1 = new List<FlatInt64bigintArray2M>();
                var secondItems2 = new List<FlatInt64bigintArray2M>();
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 21, query1, 133, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
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
            asPartInterface: typeof(IInt64ListbigintArray)),
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
                var models = await((IInt64ListbigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 72, 141))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintArray2M.AssertModel(models[0],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintArray2M.AssertModel(models[0],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IInt64ListbigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatch(connection, 10, 149))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int64bigintArray2M.AssertModel(models[0],_testData[2], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[3], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[4], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[5], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[28],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[29],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[30],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[31],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintArray2M.AssertModel(models[0],_testData[29], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[30], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[31], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[32], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[33], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[34], false);
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
                await using var cmd = await ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                Int64bigintArray2M.AssertModel(models[0],_testData[18], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[19], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[20], false);
                Int64bigintArray2M.AssertModel(models[3],_testData[21], false);
                Int64bigintArray2M.AssertModel(models[4],_testData[22], false);
                Int64bigintArray2M.AssertModel(models[5],_testData[23], false);
                Int64bigintArray2M.AssertModel(models[6],_testData[24], false);
                Int64bigintArray2M.AssertModel(models[7],_testData[25], false);
                Int64bigintArray2M.AssertModel(models[8],_testData[26], false);
                Int64bigintArray2M.AssertModel(models[9],_testData[27], false);
                Int64bigintArray2M.AssertModel(models[10],_testData[28], false);
                Int64bigintArray2M.AssertModel(models[11],_testData[29], false);
                Int64bigintArray2M.AssertModel(models[12],_testData[30], false);
                Int64bigintArray2M.AssertModel(models[13],_testData[31], false);
                Int64bigintArray2M.AssertModel(models[14],_testData[32], false);
                Int64bigintArray2M.AssertModel(models[15],_testData[33], false);
                Int64bigintArray2M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                Int64bigintArray2M.AssertModel(models[0],_testData[27], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[28], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[29], false);
                Int64bigintArray2M.AssertModel(models[3],_testData[30], false);
                Int64bigintArray2M.AssertModel(models[4],_testData[31], false);
                Int64bigintArray2M.AssertModel(models[5],_testData[32], false);
                Int64bigintArray2M.AssertModel(models[6],_testData[33], false);
                Int64bigintArray2M.AssertModel(models[7],_testData[34], false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ListbigintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ListbigintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ListbigintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ListbigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ListbigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
FROM public.binary_int64bigintarray2m m
LEFT JOIN public.binary_int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64ListbigintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64ListbigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64ListbigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models =  ((IInt64ListbigintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ListbigintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA), typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                await ((IInt64ListbigintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                ((IInt64ListbigintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64ListbigintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA), typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                await ((IInt64ListbigintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                ((IInt64ListbigintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models = await ((IInt64ListbigintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintarray2mi
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
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI), typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintArray2MI>();
                var models2 = new List<Int64bigintArray2MI>();
                await ((IInt64ListbigintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MI>();
                var models2 = new List<Int64bigintArray2MI>();
                ((IInt64ListbigintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64ListbigintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA), typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                await ((IInt64ListbigintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray2MIWA>();
                var models2 = new List<Int64bigintArray2MIWA>();
                ((IInt64ListbigintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
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
                var models = await ((IInt64ListbigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ListbigintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

