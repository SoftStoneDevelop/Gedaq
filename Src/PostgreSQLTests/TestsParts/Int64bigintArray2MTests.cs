

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5581225773119201978L,

4664017074996313472L,

8306621479802568537L,

7224898796792367029L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5967894738036657451L,

5105916321542308152L,

929559522868547856L,

2532351068914530540L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1422464526316085966L,

1216422220901077127L,

4350183590476860216L,

1262642205946799788L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1644218566402891874L,

3515274688372936620L,

1215062133244428541L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8697744620611993228L,

6070194934669143043L,

394251032191505966L,

6294875642236164149L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1389759835194132666L,

2341403335298886571L,

7112916035265538005L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6229268896082806684L,

4303456705019676737L,

4980897341939071621L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
312729278252415843L,

970319236558633240L,

8041406048005517970L,

},
},
            new Int64bigintArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6598276500228682632L,

4933548508741476080L,

7382118687338120671L,

3423034037781988086L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5124941680643889501L,

8626344212921854717L,

6821516329512454427L,

1973594507133807183L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3990896530704719453L,

8464031457287397131L,

8314678752853650066L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7888426984644834249L,

3500553741475468894L,

5907299863508055745L,

55296624806347853L,

},
},
            new Int64bigintArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5991070903557440460L,

5127352966932917331L,

2747606657913722084L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2752316493555021911L,

6910462369094053791L,

4507173251203660797L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3849846868869318160L,

3322158751607803957L,

9000293952228772072L,

9156841769433025878L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7608200867875254811L,

600424812115013274L,

3792082615994432204L,

9069093290801007819L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5856423173306383399L,

3245755538081946215L,

921181313011879074L,

5782753015766319612L,

},
},
            new Int64bigintArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
392254526303913049L,

5672910984543152444L,

3174126092787343053L,

5471185549982155903L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
907114047722322411L,

1927484166146557773L,

6565284702105066866L,

1131402698087323008L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3547539745368364887L,

7985482159599355334L,

8685802531731033612L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3359031096998722830L,

5840183798313833852L,

4904094758073277618L,

},
},
            new Int64bigintArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2415328789917862929L,

1914100528529856256L,

1066487002285218143L,

6543019054153218974L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6087642639818528509L,

4126404406980706387L,

2964104513632457905L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5676678271528636691L,

4893903892665820618L,

5902397682614787790L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8939888599159745499L,

8955983993469235357L,

1265092316515670133L,

3061508419102343960L,

},
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4979119103264509826L,

7444568843699521721L,

4030699627897721134L,

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
2150624700071699762L,

1842231303195043428L,

6848238688386268060L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2664478761817425375L,

5301454372471689497L,

5594652099502774479L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9207428984736612296L,

7517093856422679462L,

3193206028607528213L,

7639986500224877532L,

},
},
            new Int64bigintArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2610631233984348737L,

6560809202151285406L,

8386083923137988657L,

1107631769339527264L,

},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
1790994881692496811L,

9026127976700809472L,

2007678353612949754L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3810106014496824747L,

4207780250448875064L,

7155716069941262184L,

9169342837917333525L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6296680611754363941L,

8911109586687571776L,

8391782157072627274L,

6793018210981233691L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4313257238764673801L,

2669123350741442885L,

7264955635149316599L,

},
},
            new Int64bigintArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4045638478719107187L,

9005900794724122641L,

2534108353768727744L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
986263760220762213L,

3750410100848776720L,

3766649195302898148L,

5315582870868887949L,

},
},
            new Int64bigintArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5801163370650950237L,

5365227758358486946L,

3198972663924348365L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4200547468917139820L,

6032474418088727809L,

9136259445491493897L,

1865475991259654898L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6650742130633626377L,

7752561149939055710L,

1842675073054776535L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7556532916126488164L,

2709337271357855682L,

6019498769207380625L,

},
},
            new Int64bigintArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2199056827474941662L,

1599518680926813160L,

7736117901933508118L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2778195870897271461L,

6960772152823934781L,

8784720864768819218L,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2748742824627700141L,

1620937101722572439L,

1803937990306357494L,

1555926377574886192L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
7335879166882268717L,

2286930321194266944L,

8647357391301310258L,

},
},
            new Int64bigintArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
682358499896944959L,

2916461287390280246L,

921322486945182048L,

858117962025175043L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4253050927783275315L,

2261330855241728527L,

8391996879863198537L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4514942806282516585L,

4125747776278188906L,

6537289962982306293L,

},
},
            new Int64bigintArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2638548913690412416L,

5613177546130222455L,

3898191608170400003L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1665860651406066753L,

3824862956865105115L,

614083428358443270L,

},
},
            new Int64bigintArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7588641587687591240L,

4620830298971507456L,

411984250834088440L,

3705246755537812030L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5713145586313992355L,

7260506814258958063L,

962410892206110835L,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4929006308769503332L,

211695135680312434L,

8117690034860726372L,

},
},
            new Int64bigintArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
2892246650912558629L,

7621378453380782006L,

5939519771271224589L,

5835199480595078763L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2973788520854437010L,

2085772696853136681L,

5943205261656388047L,

},
},
            new Int64bigintArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8694396516097898425L,

2733735393839960941L,

4158394657820819323L,

7795615568601069534L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5091368120558571814L,

8562799516734706830L,

5148589585371121054L,

3928795978562964133L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7864981256641219401L,

8098128760542866680L,

6178507235270067409L,

8909200099549623361L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8988014042317566982L,

7088644965694570291L,

3318477357966314608L,

4110919295435676087L,

},
},
            new Int64bigintArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
816970031043545778L,

6104512963035332208L,

2884996029816311497L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1701112559124490821L,

5108252293423731108L,

7100698383137527607L,

},
},
            new Int64bigintArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4974950430993893148L,

6472400892077348512L,

5864312965953000867L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3123622024307123096L,

4006228506725696712L,

3205894034253472414L,

1039731547892997996L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3431504138544218649L,

608319439156897564L,

8845037233389626737L,

9066989030093489232L,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2285137400452014271L,

5773502368959878342L,

7624632463552423915L,

},
},
            new Int64bigintArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
157007789337272225L,

172965362444848430L,

6187322074821855455L,

2594954784524029756L,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2715642211897275149L,

8770278593196291407L,

7901921431329601167L,

1580149751447259643L,

},
},
            new Int64bigintArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
8255226508853158109L,

5913369012792353202L,

8446238608357637546L,

3291031596018603469L,

},
    ModelInner = new Int64bigintArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
1830879609003917558L,

5431197112165970247L,

4951233962078623280L,

1647255520230442681L,

},
    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2661985817051187420L,

1744486653651742432L,

1566578687772155682L,

},
},
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 129;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintArray2M.AssertModel(models[0],_testData[1], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[2], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[3], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[4], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[5], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[27],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintArray2M.AssertModel(models[0],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int64bigintArray2M.AssertModel(models[0],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 27, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[29], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 49, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatInt64bigintArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((IInt64ListbigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 95, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 112, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 54, query1, 138, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[29], false);
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
                await ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 16, query1, 34, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintArray2M.AssertModel(secondItems2[23],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 95, query1, 44, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigintArray2M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintArray2M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintArray2M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintArray2M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintArray2M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintArray2M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintArray2M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintArray2M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintArray2M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintArray2M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintArray2M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintArray2M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintArray2M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(models[21],_testData[29], false);
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
                 ((IInt64ListbigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 101, query1, 4, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatInt64bigintArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintArray2M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 16, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int64bigintArray2M.AssertModel(models[0],_testData[3], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[4], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[5], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[25],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigintArray2M.AssertModel(models[0],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IInt64ListbigintArray)this).DbConnectionSTSelectModelBatch(connection, 41, 27))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Int64bigintArray2M.AssertModel(models[0],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Int64bigintArray2M.AssertModel(models[0],_testData[5], false);
                        Int64bigintArray2M.AssertModel(models[1],_testData[6], false);
                        Int64bigintArray2M.AssertModel(models[2],_testData[7], false);
                        Int64bigintArray2M.AssertModel(models[3],_testData[8], false);
                        Int64bigintArray2M.AssertModel(models[4],_testData[9], false);
                        Int64bigintArray2M.AssertModel(models[5],_testData[10], false);
                        Int64bigintArray2M.AssertModel(models[6],_testData[11], false);
                        Int64bigintArray2M.AssertModel(models[7],_testData[12], false);
                        Int64bigintArray2M.AssertModel(models[8],_testData[13], false);
                        Int64bigintArray2M.AssertModel(models[9],_testData[14], false);
                        Int64bigintArray2M.AssertModel(models[10],_testData[15], false);
                        Int64bigintArray2M.AssertModel(models[11],_testData[16], false);
                        Int64bigintArray2M.AssertModel(models[12],_testData[17], false);
                        Int64bigintArray2M.AssertModel(models[13],_testData[18], false);
                        Int64bigintArray2M.AssertModel(models[14],_testData[19], false);
                        Int64bigintArray2M.AssertModel(models[15],_testData[20], false);
                        Int64bigintArray2M.AssertModel(models[16],_testData[21], false);
                        Int64bigintArray2M.AssertModel(models[17],_testData[22], false);
                        Int64bigintArray2M.AssertModel(models[18],_testData[23], false);
                        Int64bigintArray2M.AssertModel(models[19],_testData[24], false);
                        Int64bigintArray2M.AssertModel(models[20],_testData[25], false);
                        Int64bigintArray2M.AssertModel(models[21],_testData[26], false);
                        Int64bigintArray2M.AssertModel(models[22],_testData[27], false);
                        Int64bigintArray2M.AssertModel(models[23],_testData[28], false);
                        Int64bigintArray2M.AssertModel(models[24],_testData[29], false);
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
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 72);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
Int64bigintArray2M.AssertModel(models[0],_testData[15], false);Int64bigintArray2M.AssertModel(models[1],_testData[16], false);Int64bigintArray2M.AssertModel(models[2],_testData[17], false);Int64bigintArray2M.AssertModel(models[3],_testData[18], false);Int64bigintArray2M.AssertModel(models[4],_testData[19], false);Int64bigintArray2M.AssertModel(models[5],_testData[20], false);Int64bigintArray2M.AssertModel(models[6],_testData[21], false);Int64bigintArray2M.AssertModel(models[7],_testData[22], false);Int64bigintArray2M.AssertModel(models[8],_testData[23], false);Int64bigintArray2M.AssertModel(models[9],_testData[24], false);Int64bigintArray2M.AssertModel(models[10],_testData[25], false);Int64bigintArray2M.AssertModel(models[11],_testData[26], false);Int64bigintArray2M.AssertModel(models[12],_testData[27], false);Int64bigintArray2M.AssertModel(models[13],_testData[28], false);Int64bigintArray2M.AssertModel(models[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
Int64bigintArray2M.AssertModel(models[0],_testData[1], false);Int64bigintArray2M.AssertModel(models[1],_testData[2], false);Int64bigintArray2M.AssertModel(models[2],_testData[3], false);Int64bigintArray2M.AssertModel(models[3],_testData[4], false);Int64bigintArray2M.AssertModel(models[4],_testData[5], false);Int64bigintArray2M.AssertModel(models[5],_testData[6], false);Int64bigintArray2M.AssertModel(models[6],_testData[7], false);Int64bigintArray2M.AssertModel(models[7],_testData[8], false);Int64bigintArray2M.AssertModel(models[8],_testData[9], false);Int64bigintArray2M.AssertModel(models[9],_testData[10], false);Int64bigintArray2M.AssertModel(models[10],_testData[11], false);Int64bigintArray2M.AssertModel(models[11],_testData[12], false);Int64bigintArray2M.AssertModel(models[12],_testData[13], false);Int64bigintArray2M.AssertModel(models[13],_testData[14], false);Int64bigintArray2M.AssertModel(models[14],_testData[15], false);Int64bigintArray2M.AssertModel(models[15],_testData[16], false);Int64bigintArray2M.AssertModel(models[16],_testData[17], false);Int64bigintArray2M.AssertModel(models[17],_testData[18], false);Int64bigintArray2M.AssertModel(models[18],_testData[19], false);Int64bigintArray2M.AssertModel(models[19],_testData[20], false);Int64bigintArray2M.AssertModel(models[20],_testData[21], false);Int64bigintArray2M.AssertModel(models[21],_testData[22], false);Int64bigintArray2M.AssertModel(models[22],_testData[23], false);Int64bigintArray2M.AssertModel(models[23],_testData[24], false);Int64bigintArray2M.AssertModel(models[24],_testData[25], false);Int64bigintArray2M.AssertModel(models[25],_testData[26], false);Int64bigintArray2M.AssertModel(models[26],_testData[27], false);Int64bigintArray2M.AssertModel(models[27],_testData[28], false);Int64bigintArray2M.AssertModel(models[28],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigintArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IInt64ListbigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
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
                await ((IInt64ListbigintArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IInt64ListbigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Int64bigintArray2M>(15);

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
                ((IInt64ListbigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ListbigintArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Int64bigintArray2M.AssertModel(models[0],_testData[0], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[1], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[2], false);
                Int64bigintArray2M.AssertModel(models[3],_testData[3], false);
                Int64bigintArray2M.AssertModel(models[4],_testData[4], false);
                Int64bigintArray2M.AssertModel(models[5],_testData[5], false);
                Int64bigintArray2M.AssertModel(models[6],_testData[6], false);
                Int64bigintArray2M.AssertModel(models[7],_testData[7], false);
                Int64bigintArray2M.AssertModel(models[8],_testData[8], false);
                Int64bigintArray2M.AssertModel(models[9],_testData[9], false);
                Int64bigintArray2M.AssertModel(models[10],_testData[10], false);
                Int64bigintArray2M.AssertModel(models[11],_testData[11], false);
                Int64bigintArray2M.AssertModel(models[12],_testData[12], false);
                Int64bigintArray2M.AssertModel(models[13],_testData[13], false);
                Int64bigintArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IInt64ListbigintArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IInt64ListbigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Int64bigintArray2M.AssertModel(models[0],_testData[0], false);
                Int64bigintArray2M.AssertModel(models[1],_testData[1], false);
                Int64bigintArray2M.AssertModel(models[2],_testData[2], false);
                Int64bigintArray2M.AssertModel(models[3],_testData[3], false);
                Int64bigintArray2M.AssertModel(models[4],_testData[4], false);
                Int64bigintArray2M.AssertModel(models[5],_testData[5], false);
                Int64bigintArray2M.AssertModel(models[6],_testData[6], false);
                Int64bigintArray2M.AssertModel(models[7],_testData[7], false);
                Int64bigintArray2M.AssertModel(models[8],_testData[8], false);
                Int64bigintArray2M.AssertModel(models[9],_testData[9], false);
                Int64bigintArray2M.AssertModel(models[10],_testData[10], false);
                Int64bigintArray2M.AssertModel(models[11],_testData[11], false);
                Int64bigintArray2M.AssertModel(models[12],_testData[12], false);
                Int64bigintArray2M.AssertModel(models[13],_testData[13], false);
                Int64bigintArray2M.AssertModel(models[14],_testData[14], false);
                Int64bigintArray2M.AssertModel(models[15],_testData[15], false);
                Int64bigintArray2M.AssertModel(models[16],_testData[16], false);
                Int64bigintArray2M.AssertModel(models[17],_testData[17], false);
                Int64bigintArray2M.AssertModel(models[18],_testData[18], false);
                Int64bigintArray2M.AssertModel(models[19],_testData[19], false);
                Int64bigintArray2M.AssertModel(models[20],_testData[20], false);
                Int64bigintArray2M.AssertModel(models[21],_testData[21], false);
                Int64bigintArray2M.AssertModel(models[22],_testData[22], false);
                Int64bigintArray2M.AssertModel(models[23],_testData[23], false);
                Int64bigintArray2M.AssertModel(models[24],_testData[24], false);
                Int64bigintArray2M.AssertModel(models[25],_testData[25], false);
                Int64bigintArray2M.AssertModel(models[26],_testData[26], false);
                Int64bigintArray2M.AssertModel(models[27],_testData[27], false);
                Int64bigintArray2M.AssertModel(models[28],_testData[28], false);
                Int64bigintArray2M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_int64bigintarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IInt64ListbigintArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ListbigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

