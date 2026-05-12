

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
    internal partial interface IInt64MArraybigintMMArrayD1
    {
    }
    
    internal partial class Int64MArraybigintMMArrayD1 : IInt64MArraybigintMMArrayD1
    {


#region TestData

        private readonly Int64bigintMMArrayD1E1M[] _testData = new Int64bigintMMArrayD1E1M[]
        {
            new Int64bigintMMArrayD1E1M
{
    Id = 7,
    Value = 
new System.Int64[3]
{
2433124996616991819L,
4477694609274307263L,
1066917136383343912L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
6293021722300790282L,
1261364557671782278L,
6289588306841284719L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Int64[3]
{
1436782296446966528L,
4085662044572732396L,
4537044785751189664L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Int64[3]
{
7603958084455935524L,
995500650806343714L,
1583400553359969286L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
3472090515394886413L,
790940877101112681L,
4635448587630594852L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Int64[4]
{
7609938428543928681L,
898375338981628738L,
4386930157907567555L,
5944873078686876502L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Int64[4]
{
2955976490979770661L,
892965924478187107L,
5648729171743664996L,
5208564855315512306L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Int64[3]
{
2033792946602737973L,
6201964021318324643L,
4536298327247259906L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
6232561265683930119L,
7030891185250303776L,
6899265690032757129L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 20,
    Value = 
new System.Int64[4]
{
3241103344717778126L,
4454660052100226682L,
8212575845745311684L,
5796709838199522011L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
6369873307746104822L,
1553781172083317409L,
6290705259274284606L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Int64[3]
{
1257101812962328529L,
4989585860790699664L,
207590784541399028L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Int64[4]
{
7439331412894147707L,
9151385445640895663L,
7294495568590442005L,
2001795772713519408L,
},
    NullableValue = 
new System.Int64[3]
{
7297107614980044879L,
3545702338222835808L,
6298836587711163385L,
},
},
    NullableValue = 
new System.Int64[4]
{
4918487242861835324L,
4046808653102172639L,
3525402307312638014L,
5820035949218647480L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Int64[4]
{
2603557302873684843L,
1524298380506646843L,
5660708158503137637L,
1741050595019188332L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Int64[3]
{
973378667877887689L,
5884210299347303609L,
8442480976265442036L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Int64[4]
{
8225674686829596112L,
1205811768540993811L,
1817416717364665615L,
882681417631056147L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
7062412714041119142L,
7775571342067583144L,
7757563730952107205L,
8620458431710235950L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Int64[4]
{
9058428771466493469L,
8597291914061611114L,
5434283063987872266L,
6378180213687171734L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
6128537284230121187L,
914205599481073064L,
1201047117872400864L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Int64[3]
{
5697879028091297488L,
3397886214228469630L,
5134526207067051072L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Int64[4]
{
7935405860616435995L,
5187561604212327844L,
1064486645619324562L,
5614669709776631079L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 51,
    Value = 
new System.Int64[3]
{
2945415368688491113L,
6859382953080182872L,
1003129081249739457L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Int64[3]
{
3677471519048454695L,
8849955397461004813L,
8288848298097662308L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Int64[4]
{
4977767492411063723L,
5471798235542310442L,
6643268273719407955L,
1596635791028180389L,
},
    NullableValue = 
new System.Int64[3]
{
3303822021309702164L,
7896703796968906796L,
4820333261868366486L,
},
},
    NullableValue = 
new System.Int64[4]
{
767877435830605955L,
5241746497942857735L,
3455357875267517248L,
2544879776301810366L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 58,
    Value = 
new System.Int64[4]
{
3012180954707101763L,
765376919432690519L,
2302461010914682587L,
3704970528111453085L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
6699579435024141586L,
4430223061976455424L,
5955025409892787841L,
3607401551379234657L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Int64[4]
{
5976368375998489183L,
774738719183267520L,
1811515946117513335L,
3696833195674127149L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.Int64[4]
{
5489516866372209253L,
6272644615492476218L,
1196344828766313800L,
5738384745427011706L,
},
    NullableValue = 
new System.Int64[4]
{
6263350145157582823L,
3697887375232113538L,
3878108959976957176L,
2183540153574019293L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Int64[3]
{
7636675674819942929L,
2854311461451701670L,
2428555059449103881L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
7554508806407188119L,
2915527964106699859L,
7968102851479558156L,
1360079932150655663L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Int64[4]
{
4192464118506592786L,
8907718463760982983L,
6723821244876657392L,
5910844242438033604L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Int64[3]
{
3156467326496663804L,
4273548271304652770L,
3833767949615879574L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 81,
    Value = 
new System.Int64[4]
{
4033182028614148338L,
6819731488113684958L,
4763424381723505397L,
6306274946783865988L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Int64[3]
{
5036841777069062209L,
4962303197528317299L,
2204584348996402562L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Int64[3]
{
1956199478201841775L,
1256656809641371097L,
310191950713376717L,
},
    NullableValue = 
new System.Int64[4]
{
7230293062359873799L,
6749267596215743513L,
2157705691826686458L,
1608695735989924860L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Int64[3]
{
1096467491607510441L,
2414893197466091361L,
2802876580083068827L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
461347995818770289L,
5203854847023334045L,
723240429583368918L,
8332173578697936143L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 101,
    Value = 
new System.Int64[4]
{
7681994007043645166L,
1346616228289975677L,
7496961158811011693L,
1948004179220766847L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.Int64[4]
{
2023894069506355211L,
8577287769506376195L,
861779048457478824L,
9113012299929252478L,
},
    NullableValue = 
new System.Int64[3]
{
2959829490312690290L,
8839345337539580621L,
3632446386682972792L,
},
},
    NullableValue = 
new System.Int64[3]
{
362123510284897049L,
4771191051226005498L,
1341515797299525717L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Int64[3]
{
734110070574844578L,
3283261693529391762L,
3656901001291669037L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4940959588453965321L,
2710605173498306923L,
5059343764634951148L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 118,
    Value = 
new System.Int64[3]
{
1038634011416045866L,
1409448531688179655L,
1976978666055509302L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Int64[3]
{
7341142408936286497L,
29719885116295692L,
319474352645264718L,
},
    NullableValue = 
new System.Int64[3]
{
5246752562435407517L,
7192885959778345236L,
1631370848265171592L,
},
},
    NullableValue = 
new System.Int64[4]
{
2625010694969075632L,
3718212336172719921L,
5524267972446801431L,
474124413150656706L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Int64[4]
{
8286532575043088383L,
2869354515722709250L,
1314779889445339276L,
2848455589582387937L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Int64[4]
{
7061280416714891320L,
5523788678760463554L,
4947580572533364649L,
1768602997160742237L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Int64[4]
{
5260173926036354079L,
4804489470270397299L,
8591243485088737022L,
5933929156748312925L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Int64[4]
{
7360892462564608761L,
3955139122723790606L,
1198021966996972709L,
3457272002588373009L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
3752832419198214601L,
5736678746864533196L,
1466167987329801699L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Int64[4]
{
3338128955600631320L,
3524428339634859536L,
3726788933692131620L,
6734416124826023642L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Int64[3]
{
4987169823535225431L,
7808960910917874642L,
5188797664759805823L,
},
    NullableValue = 
new System.Int64[4]
{
73758759001716203L,
2999052079712587694L,
806814238459841642L,
272072660194845673L,
},
},
    NullableValue = 
new System.Int64[3]
{
7718966866772504708L,
7989726061680467254L,
4293821984492161458L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Int64[4]
{
4915136063602614253L,
4059925764894069766L,
5866576295795168069L,
1388047362376679910L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Int64[3]
{
8600610228390950832L,
7868120865694829713L,
3599180179136550494L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Int64[4]
{
5785004737887102026L,
5089031354545389945L,
5405299903988442031L,
2926843338975759582L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Int64[4]
{
4947885879278995558L,
420240169240846769L,
1538238769887865029L,
6245421048326083033L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Int64[3]
{
661044160716889186L,
9208708449305592473L,
4949845882983174636L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Int64[4]
{
7569064984577989102L,
4799135346781308413L,
6822465493379787705L,
6980847477160574001L,
},
    NullableValue = 
new System.Int64[3]
{
7716649658612609444L,
6041984652585106980L,
7908715344738326287L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 173,
    Value = 
new System.Int64[3]
{
7825912625737258941L,
7418598069563228302L,
1988736385756723924L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 177,
    Value = 
new System.Int64[4]
{
7708015413728967575L,
8957929539783380636L,
620507408373127271L,
4184706976398118809L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Int64[3]
{
7640399456564076942L,
8475999379825972765L,
3085429271365480139L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
5640900763641748160L,
6075426613321380551L,
1335043868331471886L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 179,
    Value = 
new System.Int64[3]
{
1551360059134049932L,
6409569705808923970L,
3997230282450015581L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 188,
    Value = 
new System.Int64[3]
{
603551592667622717L,
5034222967815180625L,
7089916886123638391L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 88,
    Value = 
new System.Int64[3]
{
3387515714204878086L,
489888008355029669L,
5996910309713660102L,
},
    NullableValue = 
new System.Int64[3]
{
8765142092298945505L,
1418155417651924839L,
2991213326907474618L,
},
},
    NullableValue = 
new System.Int64[3]
{
964265452906515257L,
921749318624901924L,
3199603018077696911L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 196,
    Value = 
new System.Int64[3]
{
3197179652310898161L,
7820199995338630424L,
3974577100497954372L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4647250147656947901L,
7730059136152701881L,
6719170608345984583L,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1mi(
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1mi(
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
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
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

                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd1e1mi_id
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd1e1mi_id", 
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
                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd1e1mi_id
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
    int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
6369873307746104822L,
1553781172083317409L,
6290705259274284606L,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
4918487242861835324L,
4046808653102172639L,
3525402307312638014L,
5820035949218647480L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
7062412714041119142L,
7775571342067583144L,
7757563730952107205L,
8620458431710235950L,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd1e1mi_id
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
    int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintmmarrayd1e1mi_id", 
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
                System.Int64[] nullable = null;
                nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
6128537284230121187L,
914205599481073064L,
1201047117872400864L,
}));
                nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
767877435830605955L,
5241746497942857735L,
3455357875267517248L,
2544879776301810366L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD1E1M> models = null;

                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD1E1M> models = null;

                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 179;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 92, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 51, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 15, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 39, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 31, query1, 146, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 80, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 58, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 7, query1, 58, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 32, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 39, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                await using var cmd = await ((IInt64MArraybigintMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 154);
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 154);
                var models =  ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MI),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintMMArrayD1E1M),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
FROM public.binary_int64bigintmmarrayd1e1m m
LEFT JOIN public.binary_int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models =  ((IInt64MArraybigintMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA), typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA), typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI), typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models1 = new List<Int64bigintMMArrayD1E1MI>();
                var models2 = new List<Int64bigintMMArrayD1E1MI>();
                await ((IInt64MArraybigintMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MI>();
                var models2 = new List<Int64bigintMMArrayD1E1MI>();
                ((IInt64MArraybigintMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA), typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                await ((IInt64MArraybigintMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                ((IInt64MArraybigintMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

