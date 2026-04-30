

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
    Id = 8,
    Value = 
new System.Double[4]
{
0.48444528681547316d,
0.6317213828839434d,
0.1722447789142445d,
0.7203016422566775d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.18794740922674935d,
0.888494008662496d,
0.017914954596334187d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 9,
    Value = 
new System.Double[4]
{
0.1604375022340061d,
0.09423303704558383d,
0.4331131949880438d,
0.4485335629118037d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 9,
    Value = 
new System.Double[4]
{
0.8474483825893379d,
0.6888931171954954d,
0.7213441978259816d,
0.8561806118546111d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 13,
    Value = 
new System.Double[4]
{
0.3993711045673194d,
0.12141857462799643d,
0.9209488941916376d,
0.7991718671605347d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.3826285073746779d,
0.39306526159061395d,
0.7930319316490914d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 15,
    Value = 
new System.Double[4]
{
0.8275318656988847d,
0.551159703772822d,
0.22778496579411145d,
0.8423591257884034d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 16,
    Value = 
new System.Double[4]
{
0.3218793654302009d,
0.15231084317842136d,
0.6573624054145578d,
0.24356260179581524d,
},
    NullableValue = 
new System.Double[3]
{
0.8247827546817129d,
0.6056641232762884d,
0.014431972241670699d,
},
},
    NullableValue = 
new System.Double[3]
{
0.8524103237056815d,
0.04606357938729988d,
0.21506000287709148d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 24,
    Value = 
new System.Double[4]
{
0.03070897883114887d,
0.7110323785267356d,
0.9245095477544126d,
0.1551973997530689d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 33,
    Value = 
new System.Double[4]
{
0.21419845986843367d,
0.5802185138549295d,
0.24042018708163126d,
0.5155444832542189d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 17,
    Value = 
new System.Double[3]
{
0.3510778342127915d,
0.839046437279314d,
0.015006711121970273d,
},
    NullableValue = 
new System.Double[4]
{
0.34649943846584774d,
0.8791576901488836d,
0.6302479065628462d,
0.7545807898276929d,
},
},
    NullableValue = 
new System.Double[4]
{
0.9343071176078273d,
0.7282506527593957d,
0.18648228443461756d,
0.07172798962224125d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 36,
    Value = 
new System.Double[4]
{
0.8459220649335928d,
0.07135140525484751d,
0.3684990144246142d,
0.7361856152293763d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 39,
    Value = 
new System.Double[3]
{
0.2723402530200215d,
0.22297253283081953d,
0.9211230394726349d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 24,
    Value = 
new System.Double[3]
{
0.6720249412968035d,
0.20255012278358553d,
0.8066887990848151d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.4903278840106319d,
0.020099131744744536d,
0.06478028356440202d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 47,
    Value = 
new System.Double[4]
{
0.9725855439281292d,
0.7988548585417045d,
0.8628948278647779d,
0.9373133393641839d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.2918199056528993d,
0.006585704245096968d,
0.8880203394286801d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 56,
    Value = 
new System.Double[4]
{
0.18715633879654292d,
0.796996533359809d,
0.5487368114844503d,
0.7725933620571581d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 33,
    Value = 
new System.Double[3]
{
0.8366490551654767d,
0.9006343324488061d,
0.8596992519966936d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.15878004562165415d,
0.5909315381994937d,
0.6493968939857414d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 59,
    Value = 
new System.Double[3]
{
0.6390894749024086d,
0.28579677869388775d,
0.6150879764824154d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 63,
    Value = 
new System.Double[4]
{
0.3130445207073893d,
0.7751735230063534d,
0.4735780105553552d,
0.9373042916671755d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 36,
    Value = 
new System.Double[4]
{
0.6316068684438392d,
0.42326799533826487d,
0.05946897922908423d,
0.40587864501061066d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.09231139883293504d,
0.7113978787935288d,
0.8390203575050188d,
0.4463235203564241d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 64,
    Value = 
new System.Double[4]
{
0.04306806664820639d,
0.7577803478162153d,
0.49387910296496385d,
0.7129873962289169d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 67,
    Value = 
new System.Double[4]
{
0.17117939280538097d,
0.5472081185182875d,
0.8761342965890542d,
0.8864520626646619d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 37,
    Value = 
new System.Double[3]
{
0.8599949594741275d,
0.5925389795773555d,
0.8565043284915761d,
},
    NullableValue = 
new System.Double[3]
{
0.6654258895806168d,
0.8056574681486732d,
0.5338505430859868d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 73,
    Value = 
new System.Double[3]
{
0.5869651571339931d,
0.08020904468435941d,
0.2208569357702732d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 82,
    Value = 
new System.Double[3]
{
0.03434734370114145d,
0.7193180875166857d,
0.20888562427691415d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 39,
    Value = 
new System.Double[3]
{
0.4367778480943484d,
0.040677825635429876d,
0.7252224516526361d,
},
    NullableValue = 
new System.Double[3]
{
0.07805660730323649d,
0.7148719321594414d,
0.8090120811022207d,
},
},
    NullableValue = 
new System.Double[4]
{
0.6184047069038664d,
0.5089417006045673d,
0.5770313260453335d,
0.27576307761028374d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 86,
    Value = 
new System.Double[3]
{
0.7022691083310018d,
0.0070875829342854635d,
0.23583869354329667d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 88,
    Value = 
new System.Double[3]
{
0.6292311440598056d,
0.4044155995372417d,
0.7322756541411702d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 45,
    Value = 
new System.Double[3]
{
0.3042728253672625d,
0.3084446134876385d,
0.4510272268162251d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.615066826464125d,
0.8281566304006338d,
0.3468935230499287d,
0.9704935419070366d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 93,
    Value = 
new System.Double[4]
{
0.19769101287662216d,
0.8152837573902728d,
0.3709257178683705d,
0.1948954223572552d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 95,
    Value = 
new System.Double[4]
{
0.13406995278713107d,
0.30300101467969964d,
0.8773098038902828d,
0.8314440682411262d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 49,
    Value = 
new System.Double[3]
{
0.7148608729298661d,
0.9052485101120539d,
0.968700616134512d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 98,
    Value = 
new System.Double[4]
{
0.9472523502329919d,
0.45031711755507065d,
0.11504563243905486d,
0.3660876254944644d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.9199357137614977d,
0.8612670590827894d,
0.9125946016606903d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 107,
    Value = 
new System.Double[3]
{
0.7956748175299351d,
0.9115470248666601d,
0.7626659375157682d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 55,
    Value = 
new System.Double[3]
{
0.774942104156291d,
0.939883861979036d,
0.8936101974533239d,
},
    NullableValue = 
new System.Double[4]
{
0.1508012423919013d,
0.9481995528491454d,
0.3540783829339672d,
0.7909038163713441d,
},
},
    NullableValue = 
new System.Double[4]
{
0.135337168013409d,
0.013545368079962539d,
0.8235367367021765d,
0.7877820999429797d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 111,
    Value = 
new System.Double[4]
{
0.6927194167376899d,
0.1946723135019396d,
0.5252413358881515d,
0.016232817050629955d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.41762253804670746d,
0.4666465961388736d,
0.4298400060729429d,
0.34165120100114177d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 116,
    Value = 
new System.Double[3]
{
0.9704050472428192d,
0.955048469527932d,
0.1494758953483295d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 64,
    Value = 
new System.Double[3]
{
0.3821603493798561d,
0.01934975054104693d,
0.6549479939889274d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 118,
    Value = 
new System.Double[3]
{
0.8878326032401317d,
0.40367106332432723d,
0.39451857701257786d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 121,
    Value = 
new System.Double[3]
{
0.4631245169640482d,
0.0887508550386209d,
0.5934750301813951d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 70,
    Value = 
new System.Double[3]
{
0.017560884928372267d,
0.9160676566451756d,
0.4057015068035208d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 123,
    Value = 
new System.Double[4]
{
0.6753933621041931d,
0.18555262562223707d,
0.41223701022164727d,
0.3261845323645267d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.506160673491651d,
0.8586904760376841d,
0.6260605397602941d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 127,
    Value = 
new System.Double[4]
{
0.1099393871107821d,
0.15654735384891583d,
0.07510053753951784d,
0.7134220320597504d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 74,
    Value = 
new System.Double[3]
{
0.25038547226282726d,
0.5073548590769942d,
0.44262746255201635d,
},
    NullableValue = 
new System.Double[4]
{
0.43042995202152556d,
0.9487432383294521d,
0.6986772143887023d,
0.222892314515739d,
},
},
    NullableValue = 
new System.Double[3]
{
0.29947685452798833d,
0.012578523143643716d,
0.14835749985718205d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 134,
    Value = 
new System.Double[3]
{
0.2474360127583416d,
0.9838263244917306d,
0.43423944533428993d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.9271673811335465d,
0.4582613445702992d,
0.23749720211048841d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 135,
    Value = 
new System.Double[3]
{
0.6102895432090267d,
0.5556376829686457d,
0.4985565752501223d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 80,
    Value = 
new System.Double[4]
{
0.8925167893878423d,
0.6193238160847587d,
0.044567938362004456d,
0.5844317964048689d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.12167842508662596d,
0.2290229308670858d,
0.16664695110367433d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 137,
    Value = 
new System.Double[3]
{
0.3758598265494687d,
0.9181575420569769d,
0.3532180733500414d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 145,
    Value = 
new System.Double[3]
{
0.8507812495521755d,
0.2927691871743321d,
0.23929326462295186d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 84,
    Value = 
new System.Double[3]
{
0.46915140896855556d,
0.4398110606847838d,
0.7118425849284259d,
},
    NullableValue = 
new System.Double[3]
{
0.11790663266200052d,
0.5457864712667307d,
0.21839806065297152d,
},
},
    NullableValue = 
new System.Double[3]
{
0.10954621938544207d,
0.05327257077444081d,
0.46952868492954436d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 152,
    Value = 
new System.Double[4]
{
0.2713414250434405d,
0.6427056580879666d,
0.7975073000355518d,
0.052513823751425215d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.0976681735967877d,
0.17042585640489827d,
0.5915620845014836d,
0.5398641878659786d,
},
},
            new Doubledouble_precisionArray1M
{
    Id = 156,
    Value = 
new System.Double[3]
{
0.6999932083391813d,
0.7455267127518181d,
0.3010282003221325d,
},
    ModelInner = new Doubledouble_precisionArray1MI
{
    Id = 85,
    Value = 
new System.Double[4]
{
0.7292048138699744d,
0.3975709021261412d,
0.7178359133111507d,
0.4211684074426062d,
},
    NullableValue = 
new System.Double[4]
{
0.4058399883385243d,
0.6889329021306178d,
0.24028449634655247d,
0.08189082279338256d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray1M
{
    Id = 158,
    Value = 
new System.Double[3]
{
0.026586470670252882d,
0.8783660915226199d,
0.7516559437909922d,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.9343071176078273d,
0.7282506527593957d,
0.18648228443461756d,
0.07172798962224125d,
}));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.4903278840106319d,
0.020099131744744536d,
0.06478028356440202d,
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.2918199056528993d,
0.006585704245096968d,
0.8880203394286801d,
}));
                nullable =  ((IDoubleArraydouble_precisionArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.15878004562165415d,
0.5909315381994937d,
0.6493968939857414d,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.09231139883293504d,
0.7113978787935288d,
0.8390203575050188d,
0.4463235203564241d,
}));
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[34], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[34], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[3], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[4], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[5], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[28],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[29],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[30],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[2], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[3], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[4], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[5], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[6], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[7], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[8], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[9], false);
                        Doubledouble_precisionArray1M.AssertModel(models[8],_testData[10], false);
                        Doubledouble_precisionArray1M.AssertModel(models[9],_testData[11], false);
                        Doubledouble_precisionArray1M.AssertModel(models[10],_testData[12], false);
                        Doubledouble_precisionArray1M.AssertModel(models[11],_testData[13], false);
                        Doubledouble_precisionArray1M.AssertModel(models[12],_testData[14], false);
                        Doubledouble_precisionArray1M.AssertModel(models[13],_testData[15], false);
                        Doubledouble_precisionArray1M.AssertModel(models[14],_testData[16], false);
                        Doubledouble_precisionArray1M.AssertModel(models[15],_testData[17], false);
                        Doubledouble_precisionArray1M.AssertModel(models[16],_testData[18], false);
                        Doubledouble_precisionArray1M.AssertModel(models[17],_testData[19], false);
                        Doubledouble_precisionArray1M.AssertModel(models[18],_testData[20], false);
                        Doubledouble_precisionArray1M.AssertModel(models[19],_testData[21], false);
                        Doubledouble_precisionArray1M.AssertModel(models[20],_testData[22], false);
                        Doubledouble_precisionArray1M.AssertModel(models[21],_testData[23], false);
                        Doubledouble_precisionArray1M.AssertModel(models[22],_testData[24], false);
                        Doubledouble_precisionArray1M.AssertModel(models[23],_testData[25], false);
                        Doubledouble_precisionArray1M.AssertModel(models[24],_testData[26], false);
                        Doubledouble_precisionArray1M.AssertModel(models[25],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[26],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[27],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[28],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[29],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[30],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[31],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[32],_testData[34], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 123, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 15, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[34], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 118, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[34], false);
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 24, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 127, query1, 33, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[22],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[23],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[24],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[25],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[26],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[27],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[28],_testData[34], false);
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
                await ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 8, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 64, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDoubledouble_precisionArray1M.AssertModel(models[0],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[1],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[2],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[3],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[4],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[5],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[6],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[7],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[8],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[9],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[10],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[11],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[12],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[13],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[14],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[15],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[16],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[17],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[18],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[19],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[20],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IDoubleArraydouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 93, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 123, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[29], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[5],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[6],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble_precisionArray1M.AssertModel(models[0],_testData[30], false);
                        Doubledouble_precisionArray1M.AssertModel(models[1],_testData[31], false);
                        Doubledouble_precisionArray1M.AssertModel(models[2],_testData[32], false);
                        Doubledouble_precisionArray1M.AssertModel(models[3],_testData[33], false);
                        Doubledouble_precisionArray1M.AssertModel(models[4],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleArraydouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 95, 95))
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
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 152);
                var models = await ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[33], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleArraydouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleArraydouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models =  ((IDoubleArraydouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
Doubledouble_precisionArray1M.AssertModel(models[0],_testData[12], false);Doubledouble_precisionArray1M.AssertModel(models[1],_testData[13], false);Doubledouble_precisionArray1M.AssertModel(models[2],_testData[14], false);Doubledouble_precisionArray1M.AssertModel(models[3],_testData[15], false);Doubledouble_precisionArray1M.AssertModel(models[4],_testData[16], false);Doubledouble_precisionArray1M.AssertModel(models[5],_testData[17], false);Doubledouble_precisionArray1M.AssertModel(models[6],_testData[18], false);Doubledouble_precisionArray1M.AssertModel(models[7],_testData[19], false);Doubledouble_precisionArray1M.AssertModel(models[8],_testData[20], false);Doubledouble_precisionArray1M.AssertModel(models[9],_testData[21], false);Doubledouble_precisionArray1M.AssertModel(models[10],_testData[22], false);Doubledouble_precisionArray1M.AssertModel(models[11],_testData[23], false);Doubledouble_precisionArray1M.AssertModel(models[12],_testData[24], false);Doubledouble_precisionArray1M.AssertModel(models[13],_testData[25], false);Doubledouble_precisionArray1M.AssertModel(models[14],_testData[26], false);Doubledouble_precisionArray1M.AssertModel(models[15],_testData[27], false);Doubledouble_precisionArray1M.AssertModel(models[16],_testData[28], false);Doubledouble_precisionArray1M.AssertModel(models[17],_testData[29], false);Doubledouble_precisionArray1M.AssertModel(models[18],_testData[30], false);Doubledouble_precisionArray1M.AssertModel(models[19],_testData[31], false);Doubledouble_precisionArray1M.AssertModel(models[20],_testData[32], false);Doubledouble_precisionArray1M.AssertModel(models[21],_testData[33], false);Doubledouble_precisionArray1M.AssertModel(models[22],_testData[34], false);
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

