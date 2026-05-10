

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
    Id = 8,
    Value = 
new System.Int64[3]
{
426941527410212096L,
984742461013893795L,
6824936997085254427L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1408599650026621037L,
4558494671008172077L,
3477871954829931962L,
5768967000174376605L,
},
},
            new Int64bigintArray1M
{
    Id = 17,
    Value = 
new System.Int64[4]
{
4622766909379119642L,
1593918734917421018L,
2639380180838642708L,
474001188877387128L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 1,
    Value = 
new System.Int64[3]
{
4962265218143944878L,
3793078625644757282L,
597649260165447777L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 18,
    Value = 
new System.Int64[4]
{
6183241572452116438L,
9188163888426309059L,
3307863454361009945L,
5219600131919485114L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 22,
    Value = 
new System.Int64[3]
{
6184865717282867365L,
1914688160103894875L,
1335387787547459316L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 5,
    Value = 
new System.Int64[3]
{
7781131248853395333L,
6351774477074618221L,
6770914765411656492L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 23,
    Value = 
new System.Int64[3]
{
9138188542595946083L,
3556938388163895683L,
5379851606221346685L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
7060763567058495845L,
8462653018289363676L,
8794720235766698169L,
5760458925865851911L,
},
},
            new Int64bigintArray1M
{
    Id = 29,
    Value = 
new System.Int64[3]
{
6504503376470182674L,
5254929695530542226L,
2374656520083986258L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 7,
    Value = 
new System.Int64[3]
{
3082440609535947081L,
47134715538016063L,
5636538214100228555L,
},
    NullableValue = 
new System.Int64[4]
{
1128765176079548658L,
6024668765421212815L,
2461790057695359298L,
2994906054876892453L,
},
},
    NullableValue = 
new System.Int64[4]
{
7371735684012260361L,
6564077024621741146L,
5782819442356993661L,
4049551184666674822L,
},
},
            new Int64bigintArray1M
{
    Id = 35,
    Value = 
new System.Int64[3]
{
1535369932972010440L,
3932202581077843851L,
7082615278578442329L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 43,
    Value = 
new System.Int64[3]
{
6538276090619651089L,
3956280980254414613L,
2283914322869207680L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 11,
    Value = 
new System.Int64[3]
{
1516013401208486980L,
8184339267419172895L,
4423175646546630735L,
},
    NullableValue = 
new System.Int64[4]
{
4957033117828003118L,
2410402614834965600L,
6543195890408658514L,
713456915867756042L,
},
},
    NullableValue = 
new System.Int64[3]
{
135268531546750699L,
1331631137219323105L,
7409133896450174155L,
},
},
            new Int64bigintArray1M
{
    Id = 51,
    Value = 
new System.Int64[3]
{
826315750028904551L,
1105714971268896227L,
4335095469799930879L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
114834088035153808L,
4613766456831643849L,
3751519246441171912L,
},
},
            new Int64bigintArray1M
{
    Id = 58,
    Value = 
new System.Int64[3]
{
1642963648823552146L,
4407642311020670768L,
2856061194353417872L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 13,
    Value = 
new System.Int64[3]
{
7059004112489372072L,
244435269855094161L,
7819776262647409345L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 67,
    Value = 
new System.Int64[4]
{
6556860591023326689L,
8930748981055785829L,
2721107982445997016L,
3319700450549453274L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 75,
    Value = 
new System.Int64[3]
{
7450009224728750215L,
5767014351826522687L,
3035773484885090803L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 22,
    Value = 
new System.Int64[3]
{
5234836629229964532L,
3689768145791985558L,
3234652514757171324L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 81,
    Value = 
new System.Int64[4]
{
4427049106391926527L,
3499238714478201840L,
4850468506062955495L,
5275217122196812962L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
5583388153880884369L,
3450979837867549733L,
6596716357795644158L,
1938570301638720302L,
},
},
            new Int64bigintArray1M
{
    Id = 85,
    Value = 
new System.Int64[3]
{
8676427656306868425L,
3454693298341705257L,
8443212172661524629L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 25,
    Value = 
new System.Int64[3]
{
5635586982899182640L,
5104864083226215769L,
6548856230554232857L,
},
    NullableValue = 
new System.Int64[3]
{
5952172969688531305L,
6570374622413615153L,
8295388834407538596L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 87,
    Value = 
new System.Int64[4]
{
7901924543216396077L,
4099865295993413193L,
2271347262563799439L,
7250902962523873165L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4831758473917344805L,
2782704446774670751L,
7775933908976367821L,
1377597223791447781L,
},
},
            new Int64bigintArray1M
{
    Id = 95,
    Value = 
new System.Int64[3]
{
4727361293962853127L,
42787359358426638L,
3161692762985422888L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 28,
    Value = 
new System.Int64[3]
{
4266574270040232423L,
2929589355849507701L,
6872819706856390834L,
},
    NullableValue = 
new System.Int64[3]
{
8907750121433877217L,
2437235987463888611L,
3585252635677836518L,
},
},
    NullableValue = 
new System.Int64[3]
{
7001489543895865937L,
5473366731985400321L,
4960764376750161747L,
},
},
            new Int64bigintArray1M
{
    Id = 97,
    Value = 
new System.Int64[4]
{
4249410830472815450L,
4185929675406631363L,
1658463219517085238L,
8954130826784397377L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 103,
    Value = 
new System.Int64[3]
{
8126563474025892704L,
1498572827944162674L,
281374146001933950L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 37,
    Value = 
new System.Int64[3]
{
184726318430725743L,
2729343818327283535L,
4786098300997550709L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
7908499402457881532L,
5028830275943038917L,
5492159106882979242L,
},
},
            new Int64bigintArray1M
{
    Id = 104,
    Value = 
new System.Int64[3]
{
9185176826518555826L,
1887535515852259290L,
6646734784580682669L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 108,
    Value = 
new System.Int64[3]
{
7435739984072779574L,
6379174781889372069L,
1759929578599019951L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 39,
    Value = 
new System.Int64[3]
{
5606952110231796001L,
8930374309021224797L,
2617141102498486393L,
},
    NullableValue = 
new System.Int64[4]
{
4871407416086321267L,
9135700446665103711L,
5057821581920591125L,
4320767560922349055L,
},
},
    NullableValue = 
new System.Int64[4]
{
5907867993973734801L,
2222922017417814017L,
4169978139015501436L,
2900053556013378751L,
},
},
            new Int64bigintArray1M
{
    Id = 109,
    Value = 
new System.Int64[4]
{
5158263837451889581L,
6126459653519325331L,
7846403300229235267L,
639688927723121899L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
1743367538473341473L,
1694616328105708004L,
838973235308685106L,
},
},
            new Int64bigintArray1M
{
    Id = 112,
    Value = 
new System.Int64[3]
{
4345683026254087036L,
6223380697806294265L,
8997581370832382168L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 43,
    Value = 
new System.Int64[3]
{
8422387959983802698L,
4686896357780999097L,
7255080113290884518L,
},
    NullableValue = 
new System.Int64[4]
{
2691128763177659513L,
4736922523511282838L,
4456032363053475547L,
4775272762578835016L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 116,
    Value = 
new System.Int64[4]
{
5383099537763154677L,
2410814959872795416L,
6642272131751315333L,
2195186939584763807L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
8495670058624779678L,
2595460253876318262L,
1333504049273529246L,
8722803466205118292L,
},
},
            new Int64bigintArray1M
{
    Id = 124,
    Value = 
new System.Int64[4]
{
1497881588506848548L,
8271805210907807047L,
8077994581705350869L,
7243906718064533684L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 47,
    Value = 
new System.Int64[3]
{
1980209285549684240L,
2049709621124435274L,
7403190864729182750L,
},
    NullableValue = 
new System.Int64[3]
{
5221597224528497909L,
4868964849899880323L,
2959885433628712318L,
},
},
    NullableValue = 
new System.Int64[3]
{
9172437722963308401L,
6063532653541287495L,
2860474079156085817L,
},
},
            new Int64bigintArray1M
{
    Id = 133,
    Value = 
new System.Int64[4]
{
8882562791910778321L,
4449386380566373832L,
5776980770747710362L,
3165972727145329201L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 135,
    Value = 
new System.Int64[3]
{
7003928042811847037L,
5135710661535146608L,
5115874881886358013L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 55,
    Value = 
new System.Int64[3]
{
818530511777801888L,
8087886814429274748L,
8080664091716777464L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
5370149157302821072L,
5388217369216910861L,
1720816341520698151L,
9120702188974240894L,
},
},
            new Int64bigintArray1M
{
    Id = 140,
    Value = 
new System.Int64[4]
{
6515923038144514169L,
9215550828724711035L,
3683494625025529979L,
534955734864165088L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
6057667986277344286L,
1018587978027271483L,
4554801954677758774L,
3912067034667102343L,
},
},
            new Int64bigintArray1M
{
    Id = 148,
    Value = 
new System.Int64[4]
{
2034735230281665237L,
7516824365042480808L,
8592130135987019731L,
5475818080544372266L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 58,
    Value = 
new System.Int64[4]
{
5649531199093304547L,
4229997541697880370L,
4420748136175615063L,
910255599685449976L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
2328695685548796130L,
2316128875840627105L,
4752181173570773515L,
9028138441864207225L,
},
},
            new Int64bigintArray1M
{
    Id = 152,
    Value = 
new System.Int64[3]
{
8987995827278179472L,
7335426247365215464L,
5377163491633039358L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4607438065449508313L,
7916945659232044080L,
4696501677038575521L,
6222469575267726993L,
},
},
            new Int64bigintArray1M
{
    Id = 157,
    Value = 
new System.Int64[3]
{
8756784080350792171L,
717579593444483109L,
6625857520892136791L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 60,
    Value = 
new System.Int64[3]
{
9040418351119803376L,
7170712654323322005L,
3401752900213856214L,
},
    NullableValue = 
new System.Int64[3]
{
5398141920258861476L,
3834728880850541127L,
6667630957572951009L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 166,
    Value = 
new System.Int64[4]
{
806561073838722622L,
1543985816962902275L,
2169128926721485110L,
361853481882999909L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
7715255296665409625L,
8795039976047449406L,
331758478591796227L,
},
},
            new Int64bigintArray1M
{
    Id = 170,
    Value = 
new System.Int64[3]
{
1929526506719778751L,
4311655484074571578L,
8889554874319583047L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 65,
    Value = 
new System.Int64[3]
{
3542179174937666846L,
3784808419669212810L,
3353938143865103946L,
},
    NullableValue = 
new System.Int64[4]
{
7475037548634122157L,
1401281884105618808L,
1878795777686521484L,
8222957004497947733L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 173,
    Value = 
new System.Int64[4]
{
3696309658168110709L,
2426325701948016313L,
1166672892457244039L,
3952904465110240058L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 174,
    Value = 
new System.Int64[3]
{
606420246660754635L,
5421505689543848696L,
5930802555090913172L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 70,
    Value = 
new System.Int64[4]
{
3159941681420204378L,
2334165481373358952L,
8440746085081937732L,
1273488739784349586L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
723425426639745023L,
7138412560256799328L,
6753517949269888154L,
},
},
            new Int64bigintArray1M
{
    Id = 176,
    Value = 
new System.Int64[4]
{
4950210923472247182L,
508080950930122110L,
7255786280990159882L,
1350616905833017996L,
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
new System.Int64[4]
{
7060763567058495845L,
8462653018289363676L,
8794720235766698169L,
5760458925865851911L,
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
7371735684012260361L,
6564077024621741146L,
5782819442356993661L,
4049551184666674822L,
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

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
135268531546750699L,
1331631137219323105L,
7409133896450174155L,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
114834088035153808L,
4613766456831643849L,
3751519246441171912L,
}));
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
                Assert.That(nullable, Is.Null);
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
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[34], false);
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
                parametr1.Value = 17;
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[34], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintArray1M.AssertModel(models[0],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 157, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 148, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[34], false);
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
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 18, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 8, query1, 170, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 75, query1, 67, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[34], false);
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
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 116, query1, 43, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 51, query1, 152, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[34], false);
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
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 104, query1, 29, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 17, 157))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Int64bigintArray1M.AssertModel(models[0],_testData[2], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[3], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[4], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[29],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[30],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[31],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintArray1M.AssertModel(models[0],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 18, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Int64bigintArray1M.AssertModel(models[0],_testData[3], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[4], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[29],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[30],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Int64bigintArray1M.AssertModel(models[0],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[34], false);
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
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                Int64bigintArray1M.AssertModel(models[0],_testData[4], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[5], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[6], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[7], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[8], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[9], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[10], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[11], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[12], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[13], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[14], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[15], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[16], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[17], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[18], false);
                Int64bigintArray1M.AssertModel(models[15],_testData[19], false);
                Int64bigintArray1M.AssertModel(models[16],_testData[20], false);
                Int64bigintArray1M.AssertModel(models[17],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[18],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[19],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[20],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[21],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[22],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[23],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[24],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[25],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[26],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[27],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[28],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[29],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                Int64bigintArray1M.AssertModel(models[0],_testData[10], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[11], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[12], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[13], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[14], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[15], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[16], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[17], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[18], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[19], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[20], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[15],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[16],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[17],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[18],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[19],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[20],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[21],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[22],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[23],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[24],_testData[34], false);
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

