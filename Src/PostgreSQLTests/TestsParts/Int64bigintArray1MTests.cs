

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
    internal partial interface IInt64ArraybigintArray
    {
    }
    
    internal partial class Int64ArraybigintArray : IInt64ArraybigintArray
    {


#region TestData

        private readonly Int64bigintArray1M[] _testData = new Int64bigintArray1M[]
        {
            new Int64bigintArray1M
{
    Id = 1,
    Value = 
new System.Int64[4]
{
7530375427853382271L,
765257097927944657L,
7112534250642300902L,
354207279814696092L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 6,
    Value = 
new System.Int64[4]
{
5687022706509050064L,
6819856809474360747L,
4066344954003650319L,
6730363766230179500L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 4,
    Value = 
new System.Int64[3]
{
3736200192755646626L,
539595269183679291L,
785455070856635662L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 14,
    Value = 
new System.Int64[3]
{
2897994502182057250L,
5930344894324261724L,
3725073660529195712L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
8350674758262438976L,
1456638059474900260L,
1108153678352052358L,
},
},
            new Int64bigintArray1M
{
    Id = 19,
    Value = 
new System.Int64[4]
{
7362122260174629618L,
7014075226712732752L,
6382044230802792588L,
8122466956344494535L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 10,
    Value = 
new System.Int64[4]
{
1089869578966881333L,
4524868465787204385L,
3427511050581839506L,
6232236856280922384L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
413364318937311727L,
1257473112571420358L,
2756919070081818706L,
8141640910924174537L,
},
},
            new Int64bigintArray1M
{
    Id = 24,
    Value = 
new System.Int64[4]
{
8139205301549331552L,
8432866569901541634L,
6589636310592139863L,
2931419398679874063L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
143186446040158406L,
1374053371509294482L,
6225029624459350048L,
},
},
            new Int64bigintArray1M
{
    Id = 32,
    Value = 
new System.Int64[4]
{
2403650819100513818L,
5780287659516908869L,
1856116094995682205L,
8242730331065697551L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 14,
    Value = 
new System.Int64[4]
{
3511642595221621035L,
813496897380276836L,
4713008522539708732L,
7620703383927797557L,
},
    NullableValue = 
new System.Int64[3]
{
3793679920170593076L,
7671505416815091206L,
806986291510496935L,
},
},
    NullableValue = 
new System.Int64[4]
{
3912950671968633119L,
8143858314008614431L,
8003512208110691873L,
2195160838157363242L,
},
},
            new Int64bigintArray1M
{
    Id = 40,
    Value = 
new System.Int64[3]
{
5718195096933988728L,
3170568457303844424L,
7872462628899749931L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
517104435312075094L,
5248560008047181093L,
6491383528448206222L,
},
},
            new Int64bigintArray1M
{
    Id = 45,
    Value = 
new System.Int64[4]
{
6354057945302398143L,
2480536295413803305L,
7697392005734591181L,
203556629043016250L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 15,
    Value = 
new System.Int64[3]
{
8713998102303756117L,
6927445811098373096L,
7816819139826069547L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
320765790649747331L,
7888723945888396934L,
262721802382048208L,
},
},
            new Int64bigintArray1M
{
    Id = 49,
    Value = 
new System.Int64[4]
{
1234463299291016705L,
6908310839326352985L,
2805048678841783345L,
2999895494624880307L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 56,
    Value = 
new System.Int64[4]
{
3779027621346245813L,
1326618519349530718L,
5790123743579637834L,
2449477687876008842L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 21,
    Value = 
new System.Int64[4]
{
8630212639199255814L,
6045538161693987922L,
3654340571464653970L,
5729646281321805887L,
},
    NullableValue = 
new System.Int64[3]
{
399882626137368599L,
1298595023755099413L,
9164406969580996073L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 62,
    Value = 
new System.Int64[3]
{
1123700003766308811L,
1553184789417945910L,
8830117147436791629L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3262195554240781847L,
595778485363866545L,
6371192996619108021L,
8699419032109697389L,
},
},
            new Int64bigintArray1M
{
    Id = 69,
    Value = 
new System.Int64[3]
{
1371328969432445682L,
1373504611811405810L,
3817965231408035942L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 22,
    Value = 
new System.Int64[3]
{
2470838222464879483L,
4158776643605070545L,
2327857569599004822L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 77,
    Value = 
new System.Int64[3]
{
4883049441799366126L,
8453753131917656795L,
1830114179906631123L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 83,
    Value = 
new System.Int64[4]
{
5184016944803151065L,
2204825548929498079L,
4165977142451727670L,
6399558278624515583L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 26,
    Value = 
new System.Int64[4]
{
2442482654358646926L,
584761142179573986L,
937874290908521920L,
1804586750905267850L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
8305318886994450343L,
5409167863276348013L,
4950885245291230355L,
6147322823632335639L,
},
},
            new Int64bigintArray1M
{
    Id = 92,
    Value = 
new System.Int64[4]
{
1133696239894818462L,
6188341431564131042L,
5028381471644368619L,
2739682584443411926L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
2450473117335844964L,
8483810438208850356L,
1936136518089772160L,
},
},
            new Int64bigintArray1M
{
    Id = 101,
    Value = 
new System.Int64[3]
{
9157416888009157761L,
8241113500779960510L,
264854446540334401L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 27,
    Value = 
new System.Int64[3]
{
8092405559067344917L,
9213556686807178745L,
3463384616563110957L,
},
    NullableValue = 
new System.Int64[3]
{
8513887102889937116L,
60107453317035400L,
1466201437795957225L,
},
},
    NullableValue = 
new System.Int64[4]
{
7206045127743902118L,
5061126149370435805L,
6949496148698343429L,
4518756291232835485L,
},
},
            new Int64bigintArray1M
{
    Id = 107,
    Value = 
new System.Int64[3]
{
7167203701630289048L,
4629927655354851430L,
5503083417414366241L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 109,
    Value = 
new System.Int64[3]
{
5611757225721430834L,
8974052474438926749L,
3094834532044586477L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 33,
    Value = 
new System.Int64[3]
{
860019803836983191L,
992833019144071823L,
1142183453635887514L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
1609952793991919424L,
1003030878980964288L,
1229197004422404759L,
},
},
            new Int64bigintArray1M
{
    Id = 115,
    Value = 
new System.Int64[4]
{
1448575482744734714L,
4227958617122922264L,
8736412790829025888L,
7236093997472119654L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 124,
    Value = 
new System.Int64[3]
{
5000687950474185991L,
2098972767265901410L,
8672077514769230967L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 36,
    Value = 
new System.Int64[4]
{
2984612597963464084L,
8980084001563363015L,
5813462044311566925L,
6608247606025664661L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 131,
    Value = 
new System.Int64[3]
{
262564306960145831L,
4243955243248341446L,
1405314481063328135L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 133,
    Value = 
new System.Int64[4]
{
7725084933220013806L,
272880723818389527L,
5361693248102977127L,
2246562915833678450L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 37,
    Value = 
new System.Int64[3]
{
7584619804652377761L,
4884442132412795601L,
3344223494889860857L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 135,
    Value = 
new System.Int64[3]
{
489690245035347870L,
6241074309450063270L,
7243638900894104153L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 140,
    Value = 
new System.Int64[4]
{
1420208392254184070L,
3018898358231474835L,
3970037063904075305L,
1034890318939404791L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 46,
    Value = 
new System.Int64[3]
{
3280219974603694837L,
9072463470931716016L,
3476536610274013127L,
},
    NullableValue = 
new System.Int64[3]
{
3494786559592428633L,
3641134899064744079L,
7700146965724623571L,
},
},
    NullableValue = 
new System.Int64[3]
{
8012469146320540449L,
7331116210894717731L,
1871406389055663462L,
},
},
            new Int64bigintArray1M
{
    Id = 146,
    Value = 
new System.Int64[3]
{
4705713663193249378L,
9046272903193623890L,
8573828447827324081L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
726557384675003217L,
958952911224563182L,
4980736142946657455L,
},
},
            new Int64bigintArray1M
{
    Id = 152,
    Value = 
new System.Int64[4]
{
7284658888565866429L,
9104397375102397249L,
6191929430698515757L,
5966184329638462173L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 50,
    Value = 
new System.Int64[4]
{
4001324923746138562L,
3238412455506788625L,
9034366928013534018L,
9055289344771046560L,
},
    NullableValue = 
new System.Int64[4]
{
3058594845845698421L,
8755734670292404036L,
4440144667111118165L,
6827028625505334478L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 160,
    Value = 
new System.Int64[4]
{
4231954885776010593L,
5394155036683180410L,
5100429526812180264L,
5997931450663711898L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4806499868818470390L,
7138246432578515475L,
7563296764027405105L,
8255278515307603033L,
},
},
            new Int64bigintArray1M
{
    Id = 163,
    Value = 
new System.Int64[4]
{
6681257845004649873L,
8905601309516498048L,
5952397528654982013L,
1271589054553081085L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 55,
    Value = 
new System.Int64[3]
{
8711431889473096907L,
6957706424292007115L,
8158503758185861550L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
3853767830127887077L,
1529323547687816680L,
248362815362097874L,
1841064158016789237L,
},
},
            new Int64bigintArray1M
{
    Id = 172,
    Value = 
new System.Int64[4]
{
1921026251196670518L,
946677113066959723L,
3499540472609645881L,
2500585362328889193L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4055129956192889420L,
5779149948691735744L,
3899431738290733240L,
1223861707019043981L,
},
},
            new Int64bigintArray1M
{
    Id = 177,
    Value = 
new System.Int64[3]
{
4751577054184827075L,
707053390881122213L,
8892712355076869715L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 56,
    Value = 
new System.Int64[3]
{
7518125072977270666L,
4205682181441437591L,
5792260946513490450L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
7296903933625296571L,
1267765117574192205L,
1550674375069642723L,
},
},
            new Int64bigintArray1M
{
    Id = 185,
    Value = 
new System.Int64[3]
{
1316411573583824308L,
592512549617331983L,
1456540607294105354L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1697382760245353427L,
5153026032661281498L,
3105838806129962945L,
6210098012685761719L,
},
},
            new Int64bigintArray1M
{
    Id = 186,
    Value = 
new System.Int64[4]
{
8953722506518176739L,
2161924225586236800L,
4808601134561544378L,
7351304957367673298L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 63,
    Value = 
new System.Int64[4]
{
3883533875196631380L,
3110006350887782014L,
2176846890962771009L,
2733590318972824804L,
},
    NullableValue = 
new System.Int64[3]
{
7395544043438103705L,
755131564290367898L,
3713211901208403979L,
},
},
    NullableValue = 
new System.Int64[4]
{
978509125304156737L,
2003194026863611271L,
7761982952663529849L,
7173811471274289511L,
},
},
            new Int64bigintArray1M
{
    Id = 194,
    Value = 
new System.Int64[3]
{
8409016670311838296L,
1478015887467955503L,
8644626161265071823L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 203,
    Value = 
new System.Int64[3]
{
1873028317204030870L,
1445083645789970744L,
1071269805858902645L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 65,
    Value = 
new System.Int64[4]
{
3795066628961795299L,
1291645300203316560L,
5582056523823456926L,
7635104471244456904L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
4991167835054383152L,
4324106247550084205L,
8742170480973897404L,
8835675360918276811L,
},
},
            new Int64bigintArray1M
{
    Id = 206,
    Value = 
new System.Int64[4]
{
6416154456642890913L,
7751386482654615243L,
8468468001244084151L,
9038819683996470208L,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
INSERT INTO public.int64bigintarray1mi(
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
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
            asPartInterface: typeof(IInt64ArraybigintArray)), 
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
                methodParametrName: "int64bigintarray1mi_id", 
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
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
143186446040158406L,
1374053371509294482L,
6225029624459350048L,
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

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
3912950671968633119L,
8143858314008614431L,
8003512208110691873L,
2195160838157363242L,
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

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
517104435312075094L,
5248560008047181093L,
6491383528448206222L,
}));
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

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
320765790649747331L,
7888723945888396934L,
262721802382048208L,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                methodParametrName: "int64bigintarray1mi_id", 
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
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
3262195554240781847L,
595778485363866545L,
6371192996619108021L,
8699419032109697389L,
}));
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ArraybigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ArraybigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 62;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 185;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 77;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 177;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int64bigintArray1M.AssertModel(models[0],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintArray1M.AssertModel(models[0],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[34], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigintArray1M.AssertModel(models[0],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Int64bigintArray1M.AssertModel(models[0],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 49, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 124, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 107, query1, 177, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 77, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 19, query1, 49, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 124, query1, 124, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 14, query1, 185, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 185, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 160, 146))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintArray1M.AssertModel(models[0],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Int64bigintArray1M.AssertModel(models[0],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[34], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 1, 185))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int64bigintArray1M.AssertModel(models[0],_testData[1], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[2], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[3], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[4], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[29],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[30],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[31],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[32],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Int64bigintArray1M.AssertModel(models[0],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[34], false);
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
                await using var cmd = await ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 101);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                Int64bigintArray1M.AssertModel(models[0],_testData[16], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[17], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[18], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[19], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[20], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[15],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[16],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[17],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 131);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                Int64bigintArray1M.AssertModel(models[0],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[34], false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ArraybigintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ArraybigintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintArray1MI),
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ArraybigintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ArraybigintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray1M),
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
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
FROM public.binary_int64bigintarray1m m
LEFT JOIN public.binary_int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64ArraybigintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64ArraybigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models =  ((IInt64ArraybigintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models = await ((IInt64ArraybigintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI), typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models1 = new List<Int64bigintArray1MI>();
                var models2 = new List<Int64bigintArray1MI>();
                await ((IInt64ArraybigintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MI>();
                var models2 = new List<Int64bigintArray1MI>();
                ((IInt64ArraybigintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models = await ((IInt64ArraybigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

