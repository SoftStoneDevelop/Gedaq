

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
    internal partial interface IDoubleMArraydouble_precisionMMArrayD1
    {
    }
    
    internal partial class DoubleMArraydouble_precisionMMArrayD1 : IDoubleMArraydouble_precisionMMArrayD1
    {


#region TestData

        private readonly Doubledouble_precisionMMArrayD1E1M[] _testData = new Doubledouble_precisionMMArrayD1E1M[]
        {
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 1,
    Value = 
new System.Double[3]
{
0.009918226735896596d,
0.5645119263808495d,
0.4961318995299627d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.16754429834467532d,
0.7475404105116835d,
0.7934482765968541d,
0.11128784411400428d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 7,
    Value = 
new System.Double[3]
{
0.780916878145201d,
0.17825868003206735d,
0.32155047614099275d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 1,
    Value = 
new System.Double[3]
{
0.6343337147249282d,
0.9635062327966705d,
0.131314002694363d,
},
    NullableValue = 
new System.Double[4]
{
0.17312515004248086d,
0.6782351178504844d,
0.1691278882397087d,
0.6862717524550742d,
},
},
    NullableValue = 
new System.Double[4]
{
0.4144253492591147d,
0.9449821769032825d,
0.4702905633418245d,
0.7208910868379059d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Double[3]
{
0.6513998301551973d,
0.5991825608242854d,
0.4724440658963496d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 20,
    Value = 
new System.Double[3]
{
0.5602672206674785d,
0.07181763580841272d,
0.06524405882011786d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Double[3]
{
0.8791236585881774d,
0.6019937825323357d,
0.699661303299748d,
},
    NullableValue = 
new System.Double[4]
{
0.628584710738003d,
0.5545267420727934d,
0.28700212401513214d,
0.2829596706807048d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Double[3]
{
0.1459748786691374d,
0.5878192082345471d,
0.1844197573645716d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 27,
    Value = 
new System.Double[3]
{
0.4780489152793389d,
0.6497646263008822d,
0.6404576145455546d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Double[3]
{
0.9002957300545978d,
0.24454977549902535d,
0.9796784162591717d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Double[4]
{
0.7431496507793797d,
0.6822234330236115d,
0.05370312667674915d,
0.8557966757166054d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Double[3]
{
0.6679641426959394d,
0.5333721238019412d,
0.5836094871788539d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Double[4]
{
0.8168677656689136d,
0.011730848877395506d,
0.4228133971176615d,
0.37753124183415376d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.07189687277154655d,
0.07300716375376459d,
0.35655820353204426d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 46,
    Value = 
new System.Double[3]
{
0.48644766826962316d,
0.6745323299267998d,
0.9805660102912108d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 52,
    Value = 
new System.Double[3]
{
0.7241692488035057d,
0.34143468635713703d,
0.3508883129809669d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Double[3]
{
0.35160890787241716d,
0.8768433514685742d,
0.31904741492193245d,
},
    NullableValue = 
new System.Double[3]
{
0.9355685017461035d,
0.9419247088404126d,
0.5795297058740638d,
},
},
    NullableValue = 
new System.Double[3]
{
0.013173612258141065d,
0.5797400461140665d,
0.9195630585160963d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Double[4]
{
0.5964402473495581d,
0.20143932291301947d,
0.22235621706963649d,
0.149127669894784d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Double[4]
{
0.5460611100757392d,
0.9255560079887576d,
0.21102662780648274d,
0.7764725354611758d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Double[3]
{
0.1581507119335811d,
0.9142046425245319d,
0.753483726050446d,
},
    NullableValue = 
new System.Double[3]
{
0.005375649632855417d,
0.8528377907131203d,
0.5825549521783735d,
},
},
    NullableValue = 
new System.Double[3]
{
0.6614221828895401d,
0.3521836629692868d,
0.9074549105213423d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Double[4]
{
0.09887554456776881d,
0.27357798390725674d,
0.5300853083160024d,
0.5386227541504869d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.8943774355235714d,
0.8905548622566112d,
0.8932594107071478d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 72,
    Value = 
new System.Double[3]
{
0.07618486509931854d,
0.8168567847513478d,
0.9915052297841203d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Double[4]
{
0.8737339982785882d,
0.8598118748692247d,
0.9264769625468768d,
0.3266334656525949d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.5254747102848778d,
0.9228317691560218d,
0.6850012713425973d,
0.6816017863083284d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 77,
    Value = 
new System.Double[4]
{
0.9133201512249223d,
0.8683185053192539d,
0.9262873851817388d,
0.32605159180970433d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.43411626091552225d,
0.7443072013696107d,
0.10712649957984122d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 82,
    Value = 
new System.Double[4]
{
0.3292463159193435d,
0.7695674640671807d,
0.1075260386708009d,
0.7807748068404469d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Double[3]
{
0.45933994007719114d,
0.4656402951431896d,
0.33908725255535677d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.8010462245763538d,
0.40593392629593394d,
0.6240163596427072d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Double[4]
{
0.027454432121488015d,
0.5079625488168403d,
0.8418668358298005d,
0.23045773206826936d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 90,
    Value = 
new System.Double[3]
{
0.7873361129070868d,
0.6378586769638003d,
0.37769895782921126d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Double[4]
{
0.16668141265662184d,
0.056360174892302606d,
0.04068064515482961d,
0.6369873026324725d,
},
    NullableValue = 
new System.Double[3]
{
0.7520926337698878d,
0.2801763376494707d,
0.7071873358504218d,
},
},
    NullableValue = 
new System.Double[4]
{
0.7810574015880833d,
0.5721135123472383d,
0.4816343464086782d,
0.4968155465311296d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Double[4]
{
0.031927676545047246d,
0.9710825717527537d,
0.10111664045781266d,
0.8875462477735008d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.9652409307200751d,
0.9653997330278687d,
0.38106666792602806d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Double[4]
{
0.39921527617837227d,
0.3254419267857218d,
0.07307272516646712d,
0.21038665257002842d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Double[4]
{
0.6853821573298238d,
0.2400486218717186d,
0.6299909160830326d,
0.8200154061962028d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.5852885322239617d,
0.2894147132882041d,
0.6679199319922153d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Double[3]
{
0.4663937378326083d,
0.8808341847669142d,
0.7599177178483746d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.45526358165792324d,
0.42766476312382706d,
0.009256993524881407d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Double[4]
{
0.5445419073303303d,
0.5376955140233248d,
0.7025279762161716d,
0.7260949518722979d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Double[3]
{
0.8007350057912197d,
0.6648866351943373d,
0.24258738840636673d,
},
    NullableValue = 
new System.Double[4]
{
0.37802764052729787d,
0.8113025338809782d,
0.07898197939439655d,
0.8590920291810634d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 101,
    Value = 
new System.Double[4]
{
0.5920566321397336d,
0.3950341988997673d,
0.7042272802467201d,
0.6859175532388154d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Double[3]
{
0.8446850102452319d,
0.9966484076268856d,
0.8443175265027537d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Double[4]
{
0.388689446537553d,
0.9738651201659912d,
0.6509999150965837d,
0.9370486840957308d,
},
    NullableValue = 
new System.Double[3]
{
0.971436948384312d,
0.3477450879278665d,
0.8778757174569585d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 110,
    Value = 
new System.Double[3]
{
0.059033574519029464d,
0.12343496434269108d,
0.7761407841951345d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.503415185391827d,
0.8511256045529557d,
0.8818064983446557d,
0.9442871819031644d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 119,
    Value = 
new System.Double[4]
{
0.009785194748412662d,
0.8821852984289095d,
0.42562866313704895d,
0.2470946644207993d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Double[4]
{
0.10691755244823498d,
0.7999795486143467d,
0.4355513374366913d,
0.029849350893302984d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Double[3]
{
0.3089028051355096d,
0.6742201984841756d,
0.3367320804027938d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.09656201713874535d,
0.43838029784680177d,
0.8259352451094488d,
0.6986516533564536d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Double[4]
{
0.31237721964987897d,
0.7008250669213886d,
0.3236126847953652d,
0.4371699808656504d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Double[4]
{
0.18693770002796484d,
0.7256374516386469d,
0.6460573146155022d,
0.2398333521122924d,
},
    NullableValue = 
new System.Double[4]
{
0.8837423211652662d,
0.19453562755498965d,
0.06939508514701476d,
0.8314274666076944d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Double[4]
{
0.5442761653287831d,
0.39482965666993597d,
0.8056762293728661d,
0.1362269624253475d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Double[3]
{
0.2767968639235737d,
0.8497687998214836d,
0.9904421997470922d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Double[3]
{
0.2309106653940588d,
0.5042616829221838d,
0.20132711335095244d,
},
    NullableValue = 
new System.Double[3]
{
0.5122779762096996d,
0.04503518496344505d,
0.39090617371989433d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Double[3]
{
0.8223388847806313d,
0.5911857463051533d,
0.6607644063600729d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Double[4]
{
0.8892329960709642d,
0.6874422402193098d,
0.9264409731527721d,
0.37425313904482127d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 83,
    Value = 
new System.Double[3]
{
0.4815490431903995d,
0.9783682191812525d,
0.9809386635965213d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 152,
    Value = 
new System.Double[3]
{
0.32793968248098115d,
0.6068585248101744d,
0.154694540042017d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.21375753713660373d,
0.9628192404066419d,
0.7597610961095899d,
0.3274452975205451d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 156,
    Value = 
new System.Double[4]
{
0.3173675912924656d,
0.7858030344042289d,
0.9836670204697792d,
0.5506164235238302d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Double[3]
{
0.43797553789560106d,
0.09608227964513238d,
0.701175779075657d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.5506442528810647d,
0.5281516215696872d,
0.24237795558780983d,
0.46482551603377953d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 164,
    Value = 
new System.Double[4]
{
0.5545656356752798d,
0.020519185403691576d,
0.5277277077350371d,
0.8039639825939108d,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1mi(
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
INSERT INTO public.doubledouble_precisionmmarrayd1e1mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd1e1mi_id
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)), 
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
                methodParametrName: "doubledouble_precisionmmarrayd1e1mi_id", 
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
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd1e1mi_id
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
    doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.07189687277154655d,
0.07300716375376459d,
0.35655820353204426d,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd1e1mi_id
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
    doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                methodParametrName: "doubledouble_precisionmmarrayd1e1mi_id", 
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
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.013173612258141065d,
0.5797400461140665d,
0.9195630585160963d,
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
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.6614221828895401d,
0.3521836629692868d,
0.9074549105213423d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD1E1M> models = null;

                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD1E1M> models = null;

                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
                parametr2.Value = 95;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 119;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 152;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 95;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 1;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 65, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 65, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 82, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 101, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 20, query1, 131, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 65, query1, 131, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 97, query1, 131, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 54, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 123, 144))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 60, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
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
                await using var cmd = await ((IDoubleMArraydouble_precisionMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleMArraydouble_precisionMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleMArraydouble_precisionMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleMArraydouble_precisionMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 123);
                var models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MI),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1M),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
FROM public.binary_doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.binary_doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA), typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA), typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI), typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA), typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

