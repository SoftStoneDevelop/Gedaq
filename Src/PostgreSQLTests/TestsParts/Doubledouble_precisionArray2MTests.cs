

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
new System.Collections.Generic.List<System.Double>(4)
{
0.6102540275463123d,

0.559549083986916d,

0.8316947175551471d,

0.1750975564055317d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.312799144521277d,

0.54441194290377d,

0.909669466538297d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.006306880227028855d,

0.5385766149404326d,

0.8714916637826412d,

0.24744717983312547d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9578791587332518d,

0.3291254150097781d,

0.17526158208354115d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5741531336786281d,

0.38320945251686833d,

0.9217418072704076d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9979307746654973d,

0.8342648436981495d,

0.31882829184329875d,

0.6496122050608056d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.05294056890650123d,

0.7283477069489459d,

0.32312721035384817d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5392218953927216d,

0.4435945372313771d,

0.47487488058540295d,

0.18041179807904195d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5596787041781772d,

0.30026053346733983d,

0.2694862546486766d,

0.6392551535401748d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8337670863328891d,

0.7555172977880312d,

0.17037019724305735d,

0.029648348701596605d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5689253731318483d,

0.5257914335166122d,

0.6188417472775929d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.08360544952479432d,

0.24783102829664405d,

0.9846269082310554d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9653658949363989d,

0.23387073483834764d,

0.719448661411537d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.07156542481592398d,

0.9513816061276916d,

0.5134067175065282d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47720618925109526d,

0.15744474345756732d,

0.8522575298741029d,

0.9726376977016572d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2879884450438389d,

0.9224898080720718d,

0.3488184019709232d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6857984645034272d,

0.49856089570603224d,

0.3921712893728482d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6047944492422956d,

0.6705204360206285d,

0.09572463453558155d,

0.8322823176723649d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8836423379590396d,

0.0825638098157041d,

0.6694789690845535d,

0.4797938357769297d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8676736083440524d,

0.3005413858177556d,

0.16888704371215302d,

0.9056219508120188d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33882546159843707d,

0.31045733481643d,

0.950889919066253d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.08813592888632571d,

0.6971194172870359d,

0.6469052288441234d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6569934497793408d,

0.5006169410251909d,

0.47257982821612654d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11047283634925231d,

0.8172228681920705d,

0.14135394587799865d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.021287012273806916d,

0.4254926878434818d,

0.9824430356066435d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8574354341667899d,

0.9437781343091727d,

0.6489380050548463d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.420240390548154d,

0.7373712899178075d,

0.15667231812269933d,

0.07983270558611832d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.22610150417463926d,

0.36663213680648377d,

0.873325786576568d,

0.22829970621168327d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4982301857618241d,

0.2608624902798191d,

0.002668927592935244d,

0.04742386284969058d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.20640973868382417d,

0.11071683671968457d,

0.5107352580996074d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.04754476566762744d,

0.7862514273615718d,

0.4126627417761648d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8537675457894922d,

0.1898619188795142d,

0.7376082344567022d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.13746291627363394d,

0.9688618109248877d,

0.8079721994643558d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8862995454350305d,

0.3116878572618488d,

0.7649991081614997d,

0.8014951746932673d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3471807206614368d,

0.6021875495384535d,

0.731624802708107d,

0.29981244910472027d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6001170235727986d,

0.7735131892048623d,

0.2932002625876703d,

0.960993184049357d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8072271869136103d,

0.7622252060486565d,

0.306847138725416d,

0.3288015873399094d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2579459463898016d,

0.11519448531160381d,

0.011101445218320571d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.20304344631770344d,

0.33549992938068773d,

0.9610768042658746d,

0.43347425670913164d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8930529640465771d,

0.4660529732375305d,

0.11518805495605067d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07123788605766124d,

0.5814010644071217d,

0.8713160053943789d,

0.27024543199073436d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.18990114249124346d,

0.6191981645016364d,

0.13885719111162986d,

0.3712810459511179d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2450380941213156d,

0.28561674260988534d,

0.050389682269974756d,

0.3374658472083274d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.547002487353881d,

0.6250537360821441d,

0.8698151678671932d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5571287865150932d,

0.15554082459540886d,

0.8195732761133394d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7026404993302315d,

0.20501512720396486d,

0.980979356242024d,

0.5461144922177096d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6529352567747954d,

0.4586989651514899d,

0.6168546187372239d,

0.8297784084999945d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3709553900205296d,

0.04988234417737647d,

0.25612212023946657d,

0.18391107101432103d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7977081745434232d,

0.9801808488474856d,

0.07823764053619742d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5369797647268764d,

0.7165173177588061d,

0.35832653629313194d,

0.6714206615312215d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.21034006699742203d,

0.48970793211647423d,

0.34474271496837805d,

0.6788397522262135d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.08441491176929994d,

0.11463412745649126d,

0.44050587169645816d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.24140597798892072d,

0.46024431421683154d,

0.11199046716591643d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8154968220518392d,

0.9380471109966005d,

0.3758268362123316d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5184378191356126d,

0.18452663493760635d,

0.24944250827302827d,

0.9868281919613322d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.782491844692935d,

0.5873001403924374d,

0.4948363257162368d,

0.6144508207899121d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6224374588797784d,

0.6952338929459058d,

0.9695991666788041d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.37838433417337947d,

0.49389776009098685d,

0.12534459725311975d,

0.17778978778657084d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9088964050235699d,

0.7298020764480811d,

0.3596012877153484d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7115214881646398d,

0.5169309216464595d,

0.43295209040676186d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.707061567016345d,

0.1095512544597147d,

0.16533321563858872d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6960882306069686d,

0.8666026935873119d,

0.33670941541737776d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05540838285274374d,

0.8798832512508564d,

0.7180130553669157d,

0.24736454605171865d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9586706245384351d,

0.9328622243089992d,

0.8027874159975475d,

0.9035778546978736d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9509422237048157d,

0.7677287079503733d,

0.29377023037468897d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7457025788890501d,

0.28007253863096093d,

0.7000851998081262d,

0.9217213956204461d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.525156736194822d,

0.020307368646888313d,

0.10486567628156207d,

0.16604282735757958d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.46143729373919606d,

0.08714945616593195d,

0.9438507372413857d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8958107686571777d,

0.046169597762433456d,

0.4034208922922987d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4638502887697815d,

0.7037301665661126d,

0.35836043208607427d,

0.5609706531931477d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.46553217100724686d,

0.7529181547904693d,

0.3163711161045586d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8777982402478118d,

0.03933408900448976d,

0.06108226209351364d,

0.013734465682087138d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9275820353669203d,

0.5813891367833736d,

0.29764023969552356d,

0.6181054098754598d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8051853507906482d,

0.8244598213639655d,

0.3402908077963197d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8918115648511744d,

0.33867943277943713d,

0.961682964864254d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.0546592768919022d,

0.9146250247978988d,

0.9008951716882414d,

0.5488989557955549d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 191,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8867189273208084d,

0.3602352199869776d,

0.8619668819885622d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7273045827189407d,

0.024475227264126542d,

0.8602947249454094d,

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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 174;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[34], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
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
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[34], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
                parametr2.Value = 123;
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 161;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[2], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[3], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[29],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[30],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[31],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[3], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[29],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[30],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[31],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 30, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 30, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[31],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 113, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 119, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 45, query1, 74, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 47, query1, 174, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 20, query1, 80, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

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
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 147, query1, 112, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 180, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 18, 170))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[3], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[4], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[29],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[30],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[34], false);
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
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(15));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[20], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[21], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[22], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[23], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[24], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[25], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[26], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[29], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[30], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[31], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[32], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[33], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

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
                Doubledouble_precisionArray2M.AssertModel(models[16],_testData[30], false);
                Doubledouble_precisionArray2M.AssertModel(models[17],_testData[31], false);
                Doubledouble_precisionArray2M.AssertModel(models[18],_testData[32], false);
                Doubledouble_precisionArray2M.AssertModel(models[19],_testData[33], false);
                Doubledouble_precisionArray2M.AssertModel(models[20],_testData[34], false);
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

