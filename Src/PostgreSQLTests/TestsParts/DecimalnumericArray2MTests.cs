

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
    internal partial interface IDecimalListnumericArray
    {
    }
    
    internal partial class DecimalListnumericArray : IDecimalListnumericArray
    {


#region TestData

        private readonly DecimalnumericArray2M[] _testData = new DecimalnumericArray2M[]
        {
            new DecimalnumericArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.355739173977957m,

0.547247934549709m,

0.471372647579139m,

0.073951952511541m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.479359035809984m,

0.825105086510612m,

0.969762247595127m,

0.944201136744362m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.788639017872874m,

0.754146804223856m,

0.648094349550012m,

0.783910154610866m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.828342767930461m,

0.0613617592959567m,

0.0951171234080854m,

0.181382097059877m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.733002690553644m,

0.920606055723261m,

0.922317189648783m,

0.822640869693056m,

},
},
            new DecimalnumericArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.680690151724039m,

0.873644191936379m,

0.624492251810369m,

0.847214897195176m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.57033627435939m,

0.155061049750632m,

0.483126137908175m,

0.258735705267148m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0769386434734688m,

0.90718314564611m,

0.0994695757130837m,

0.146656823819325m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.510030007870866m,

0.994710150707766m,

0.609637404593523m,

0.959442033085468m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.308238997152036m,

0.502797690693604m,

0.975835003541803m,

0.408797553186211m,

},
},
            new DecimalnumericArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.712774744987648m,

0.401369656098334m,

0.250062935428218m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.936509168821539m,

0.765242506128367m,

0.419098599360389m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.522211279693023m,

0.443783303653128m,

0.89717120870548m,

},
},
            new DecimalnumericArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.51140456498553m,

0.491980209113613m,

0.945695128300484m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.375608356637946m,

0.188916190355932m,

0.643597749591606m,

0.065794597508041m,

},
},
            new DecimalnumericArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.846859613061481m,

0.592677047677994m,

0.127703994618897m,

0.304225649508144m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.780311496518054m,

0.902560222214642m,

0.975724694176134m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0528820814199041m,

0.47043710633893m,

0.722334938817894m,

0.557275623674539m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.315780422706111m,

0.966769110119719m,

0.0819317071515955m,

0.338018330364876m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0239862105290921m,

0.911646217150489m,

0.0474527493586547m,

0.274987678455206m,

},
},
            new DecimalnumericArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.354768819683677m,

0.610776693889754m,

0.417870885377827m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.292398243439297m,

0.814346578014436m,

0.746518469371824m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.842709692900256m,

0.150768969347357m,

0.651344650810074m,

0.512578819859935m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.401297693338043m,

0.772208875017845m,

0.194941697481377m,

0.333555890645604m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.443283371068665m,

0.0796907466412256m,

0.746727560951472m,

0.0654641748969664m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.232509829515153m,

0.233830623833803m,

0.519331332173391m,

0.979666993556852m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.269797899538104m,

0.71518181493365m,

0.793412049813649m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.781114048065617m,

0.473662932725458m,

0.791483044600323m,

0.376939145105425m,

},
},
            new DecimalnumericArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.733127824865999m,

0.781301227738311m,

0.414118741995701m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.891765768365912m,

0.172629509860274m,

0.375333856953267m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.642868909872796m,

0.956441290698087m,

0.0596685663206891m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.658371355892757m,

0.94493226865705m,

0.475395878981505m,

},
},
            new DecimalnumericArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.723799755461084m,

0.538009378970213m,

0.158892087970418m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.334761344466166m,

0.882728180893342m,

0.418463514393708m,

0.401695583824111m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0338046662430095m,

0.667772277140851m,

0.0154590084317386m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.548704251648987m,

0.266877027604233m,

0.0991771895998449m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.096740809790845m,

0.710352526926096m,

0.87265060636055m,

0.89707161178113m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.593777851061216m,

0.334156643298238m,

0.742217864964624m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.244345641119118m,

0.633593965536034m,

0.0311397461937815m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.798080414838549m,

0.16651474373761m,

0.368740302963497m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.528562648649628m,

0.381519493237532m,

0.889256894007849m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.439716943961181m,

0.34374308062565m,

0.125769865544192m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.210355798319701m,

0.938316363430207m,

0.364886310327427m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.109046391536308m,

0.692931015791479m,

0.350163638709708m,

0.518743900058062m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.683323129940099m,

0.89103888010892m,

0.378474173224911m,

},
},
            new DecimalnumericArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.568527684964531m,

0.928486784352112m,

0.223858101926553m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.97527090708346m,

0.58650529556319m,

0.530518222143503m,

},
},
            new DecimalnumericArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.212038776240194m,

0.794889931399096m,

0.701482793972396m,

0.13838922659301m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.86124966364814m,

0.962489872204609m,

0.905872675811741m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.413758534651679m,

0.540819353899436m,

0.563193615711432m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.261621818953676m,

0.406483916347651m,

0.303019251951266m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0451170150683952m,

0.566792991431212m,

0.0775305584971411m,

0.586238889756505m,

},
},
            new DecimalnumericArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.542151996632396m,

0.174973089898435m,

0.356549749279688m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.977901737135809m,

0.413235494321263m,

0.389545532630554m,

0.135365061845364m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0614557840039422m,

0.0550155805875157m,

0.339627614662361m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.731755255047818m,

0.0338641217701772m,

0.31020757701592m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.747356819711628m,

0.432966951044549m,

0.58660474793414m,

},
},
            new DecimalnumericArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.344708893064071m,

0.08636491226936m,

0.19523906997567m,

0.659357868803949m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.839633831937444m,

0.394394369984822m,

0.882556451792742m,

0.923811661494021m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.706709213756472m,

0.90525585277696m,

0.574809584185786m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.382039170032123m,

0.927118354773512m,

0.209774300741877m,

0.339555830013058m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.818593479320384m,

0.00993551932652414m,

0.945644166009852m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.320242164502238m,

0.641782168482086m,

0.857353389691627m,

0.566496871950918m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.761171808759486m,

0.280380094850682m,

0.198144235070083m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.441244107892976m,

0.493187850056527m,

0.197297598975657m,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2mi(
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
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2mi(
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
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
            asPartInterface: typeof(IDecimalListnumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray2mi_id", 
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
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray2mi_id", 
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
                List<DecimalnumericArray2M> models = null;

                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray2M> models = null;

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IDecimalListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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

                var models = await ((IDecimalListnumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((IDecimalListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IDecimalListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatDecimalnumericArray2M.AssertModel(models[0],_testData[24], false);FlatDecimalnumericArray2M.AssertModel(models[1],_testData[25], false);FlatDecimalnumericArray2M.AssertModel(models[2],_testData[26], false);FlatDecimalnumericArray2M.AssertModel(models[3],_testData[27], false);FlatDecimalnumericArray2M.AssertModel(models[4],_testData[28], false);FlatDecimalnumericArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatDecimalnumericArray2M.AssertModel(models[0],_testData[21], false);FlatDecimalnumericArray2M.AssertModel(models[1],_testData[22], false);FlatDecimalnumericArray2M.AssertModel(models[2],_testData[23], false);FlatDecimalnumericArray2M.AssertModel(models[3],_testData[24], false);FlatDecimalnumericArray2M.AssertModel(models[4],_testData[25], false);FlatDecimalnumericArray2M.AssertModel(models[5],_testData[26], false);FlatDecimalnumericArray2M.AssertModel(models[6],_testData[27], false);FlatDecimalnumericArray2M.AssertModel(models[7],_testData[28], false);FlatDecimalnumericArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatDecimalnumericArray2M.AssertModel(models[0],_testData[25], false);FlatDecimalnumericArray2M.AssertModel(models[1],_testData[26], false);FlatDecimalnumericArray2M.AssertModel(models[2],_testData[27], false);FlatDecimalnumericArray2M.AssertModel(models[3],_testData[28], false);FlatDecimalnumericArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatDecimalnumericArray2M.AssertModel(models[0],_testData[15], false);FlatDecimalnumericArray2M.AssertModel(models[1],_testData[16], false);FlatDecimalnumericArray2M.AssertModel(models[2],_testData[17], false);FlatDecimalnumericArray2M.AssertModel(models[3],_testData[18], false);FlatDecimalnumericArray2M.AssertModel(models[4],_testData[19], false);FlatDecimalnumericArray2M.AssertModel(models[5],_testData[20], false);FlatDecimalnumericArray2M.AssertModel(models[6],_testData[21], false);FlatDecimalnumericArray2M.AssertModel(models[7],_testData[22], false);FlatDecimalnumericArray2M.AssertModel(models[8],_testData[23], false);FlatDecimalnumericArray2M.AssertModel(models[9],_testData[24], false);FlatDecimalnumericArray2M.AssertModel(models[10],_testData[25], false);FlatDecimalnumericArray2M.AssertModel(models[11],_testData[26], false);FlatDecimalnumericArray2M.AssertModel(models[12],_testData[27], false);FlatDecimalnumericArray2M.AssertModel(models[13],_testData[28], false);FlatDecimalnumericArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((IDecimalListnumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
DecimalnumericArray2M.AssertModel(models[0],_testData[17], false);DecimalnumericArray2M.AssertModel(models[1],_testData[18], false);DecimalnumericArray2M.AssertModel(models[2],_testData[19], false);DecimalnumericArray2M.AssertModel(models[3],_testData[20], false);DecimalnumericArray2M.AssertModel(models[4],_testData[21], false);DecimalnumericArray2M.AssertModel(models[5],_testData[22], false);DecimalnumericArray2M.AssertModel(models[6],_testData[23], false);DecimalnumericArray2M.AssertModel(models[7],_testData[24], false);DecimalnumericArray2M.AssertModel(models[8],_testData[25], false);DecimalnumericArray2M.AssertModel(models[9],_testData[26], false);DecimalnumericArray2M.AssertModel(models[10],_testData[27], false);DecimalnumericArray2M.AssertModel(models[11],_testData[28], false);DecimalnumericArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
DecimalnumericArray2M.AssertModel(models[0],_testData[3], false);DecimalnumericArray2M.AssertModel(models[1],_testData[4], false);DecimalnumericArray2M.AssertModel(models[2],_testData[5], false);DecimalnumericArray2M.AssertModel(models[3],_testData[6], false);DecimalnumericArray2M.AssertModel(models[4],_testData[7], false);DecimalnumericArray2M.AssertModel(models[5],_testData[8], false);DecimalnumericArray2M.AssertModel(models[6],_testData[9], false);DecimalnumericArray2M.AssertModel(models[7],_testData[10], false);DecimalnumericArray2M.AssertModel(models[8],_testData[11], false);DecimalnumericArray2M.AssertModel(models[9],_testData[12], false);DecimalnumericArray2M.AssertModel(models[10],_testData[13], false);DecimalnumericArray2M.AssertModel(models[11],_testData[14], false);DecimalnumericArray2M.AssertModel(models[12],_testData[15], false);DecimalnumericArray2M.AssertModel(models[13],_testData[16], false);DecimalnumericArray2M.AssertModel(models[14],_testData[17], false);DecimalnumericArray2M.AssertModel(models[15],_testData[18], false);DecimalnumericArray2M.AssertModel(models[16],_testData[19], false);DecimalnumericArray2M.AssertModel(models[17],_testData[20], false);DecimalnumericArray2M.AssertModel(models[18],_testData[21], false);DecimalnumericArray2M.AssertModel(models[19],_testData[22], false);DecimalnumericArray2M.AssertModel(models[20],_testData[23], false);DecimalnumericArray2M.AssertModel(models[21],_testData[24], false);DecimalnumericArray2M.AssertModel(models[22],_testData[25], false);DecimalnumericArray2M.AssertModel(models[23],_testData[26], false);DecimalnumericArray2M.AssertModel(models[24],_testData[27], false);DecimalnumericArray2M.AssertModel(models[25],_testData[28], false);DecimalnumericArray2M.AssertModel(models[26],_testData[29], false);
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

                var models =  ((IDecimalListnumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
DecimalnumericArray2M.AssertModel(models[0],_testData[14], false);DecimalnumericArray2M.AssertModel(models[1],_testData[15], false);DecimalnumericArray2M.AssertModel(models[2],_testData[16], false);DecimalnumericArray2M.AssertModel(models[3],_testData[17], false);DecimalnumericArray2M.AssertModel(models[4],_testData[18], false);DecimalnumericArray2M.AssertModel(models[5],_testData[19], false);DecimalnumericArray2M.AssertModel(models[6],_testData[20], false);DecimalnumericArray2M.AssertModel(models[7],_testData[21], false);DecimalnumericArray2M.AssertModel(models[8],_testData[22], false);DecimalnumericArray2M.AssertModel(models[9],_testData[23], false);DecimalnumericArray2M.AssertModel(models[10],_testData[24], false);DecimalnumericArray2M.AssertModel(models[11],_testData[25], false);DecimalnumericArray2M.AssertModel(models[12],_testData[26], false);DecimalnumericArray2M.AssertModel(models[13],_testData[27], false);DecimalnumericArray2M.AssertModel(models[14],_testData[28], false);DecimalnumericArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
DecimalnumericArray2M.AssertModel(models[0],_testData[5], false);DecimalnumericArray2M.AssertModel(models[1],_testData[6], false);DecimalnumericArray2M.AssertModel(models[2],_testData[7], false);DecimalnumericArray2M.AssertModel(models[3],_testData[8], false);DecimalnumericArray2M.AssertModel(models[4],_testData[9], false);DecimalnumericArray2M.AssertModel(models[5],_testData[10], false);DecimalnumericArray2M.AssertModel(models[6],_testData[11], false);DecimalnumericArray2M.AssertModel(models[7],_testData[12], false);DecimalnumericArray2M.AssertModel(models[8],_testData[13], false);DecimalnumericArray2M.AssertModel(models[9],_testData[14], false);DecimalnumericArray2M.AssertModel(models[10],_testData[15], false);DecimalnumericArray2M.AssertModel(models[11],_testData[16], false);DecimalnumericArray2M.AssertModel(models[12],_testData[17], false);DecimalnumericArray2M.AssertModel(models[13],_testData[18], false);DecimalnumericArray2M.AssertModel(models[14],_testData[19], false);DecimalnumericArray2M.AssertModel(models[15],_testData[20], false);DecimalnumericArray2M.AssertModel(models[16],_testData[21], false);DecimalnumericArray2M.AssertModel(models[17],_testData[22], false);DecimalnumericArray2M.AssertModel(models[18],_testData[23], false);DecimalnumericArray2M.AssertModel(models[19],_testData[24], false);DecimalnumericArray2M.AssertModel(models[20],_testData[25], false);DecimalnumericArray2M.AssertModel(models[21],_testData[26], false);DecimalnumericArray2M.AssertModel(models[22],_testData[27], false);DecimalnumericArray2M.AssertModel(models[23],_testData[28], false);DecimalnumericArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 115, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatDecimalnumericArray2M.AssertModel(models[0],_testData[26], false);FlatDecimalnumericArray2M.AssertModel(models[1],_testData[27], false);FlatDecimalnumericArray2M.AssertModel(models[2],_testData[28], false);FlatDecimalnumericArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatDecimalnumericArray2M.AssertModel(models[0],_testData[21], false);FlatDecimalnumericArray2M.AssertModel(models[1],_testData[22], false);FlatDecimalnumericArray2M.AssertModel(models[2],_testData[23], false);FlatDecimalnumericArray2M.AssertModel(models[3],_testData[24], false);FlatDecimalnumericArray2M.AssertModel(models[4],_testData[25], false);FlatDecimalnumericArray2M.AssertModel(models[5],_testData[26], false);FlatDecimalnumericArray2M.AssertModel(models[6],_testData[27], false);FlatDecimalnumericArray2M.AssertModel(models[7],_testData[28], false);FlatDecimalnumericArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 30, query1, 23, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatDecimalnumericArray2M.AssertModel(models[0],_testData[6], false);FlatDecimalnumericArray2M.AssertModel(models[1],_testData[7], false);FlatDecimalnumericArray2M.AssertModel(models[2],_testData[8], false);FlatDecimalnumericArray2M.AssertModel(models[3],_testData[9], false);FlatDecimalnumericArray2M.AssertModel(models[4],_testData[10], false);FlatDecimalnumericArray2M.AssertModel(models[5],_testData[11], false);FlatDecimalnumericArray2M.AssertModel(models[6],_testData[12], false);FlatDecimalnumericArray2M.AssertModel(models[7],_testData[13], false);FlatDecimalnumericArray2M.AssertModel(models[8],_testData[14], false);FlatDecimalnumericArray2M.AssertModel(models[9],_testData[15], false);FlatDecimalnumericArray2M.AssertModel(models[10],_testData[16], false);FlatDecimalnumericArray2M.AssertModel(models[11],_testData[17], false);FlatDecimalnumericArray2M.AssertModel(models[12],_testData[18], false);FlatDecimalnumericArray2M.AssertModel(models[13],_testData[19], false);FlatDecimalnumericArray2M.AssertModel(models[14],_testData[20], false);FlatDecimalnumericArray2M.AssertModel(models[15],_testData[21], false);FlatDecimalnumericArray2M.AssertModel(models[16],_testData[22], false);FlatDecimalnumericArray2M.AssertModel(models[17],_testData[23], false);FlatDecimalnumericArray2M.AssertModel(models[18],_testData[24], false);FlatDecimalnumericArray2M.AssertModel(models[19],_testData[25], false);FlatDecimalnumericArray2M.AssertModel(models[20],_testData[26], false);FlatDecimalnumericArray2M.AssertModel(models[21],_testData[27], false);FlatDecimalnumericArray2M.AssertModel(models[22],_testData[28], false);FlatDecimalnumericArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatDecimalnumericArray2M.AssertModel(models[0],_testData[4], false);FlatDecimalnumericArray2M.AssertModel(models[1],_testData[5], false);FlatDecimalnumericArray2M.AssertModel(models[2],_testData[6], false);FlatDecimalnumericArray2M.AssertModel(models[3],_testData[7], false);FlatDecimalnumericArray2M.AssertModel(models[4],_testData[8], false);FlatDecimalnumericArray2M.AssertModel(models[5],_testData[9], false);FlatDecimalnumericArray2M.AssertModel(models[6],_testData[10], false);FlatDecimalnumericArray2M.AssertModel(models[7],_testData[11], false);FlatDecimalnumericArray2M.AssertModel(models[8],_testData[12], false);FlatDecimalnumericArray2M.AssertModel(models[9],_testData[13], false);FlatDecimalnumericArray2M.AssertModel(models[10],_testData[14], false);FlatDecimalnumericArray2M.AssertModel(models[11],_testData[15], false);FlatDecimalnumericArray2M.AssertModel(models[12],_testData[16], false);FlatDecimalnumericArray2M.AssertModel(models[13],_testData[17], false);FlatDecimalnumericArray2M.AssertModel(models[14],_testData[18], false);FlatDecimalnumericArray2M.AssertModel(models[15],_testData[19], false);FlatDecimalnumericArray2M.AssertModel(models[16],_testData[20], false);FlatDecimalnumericArray2M.AssertModel(models[17],_testData[21], false);FlatDecimalnumericArray2M.AssertModel(models[18],_testData[22], false);FlatDecimalnumericArray2M.AssertModel(models[19],_testData[23], false);FlatDecimalnumericArray2M.AssertModel(models[20],_testData[24], false);FlatDecimalnumericArray2M.AssertModel(models[21],_testData[25], false);FlatDecimalnumericArray2M.AssertModel(models[22],_testData[26], false);FlatDecimalnumericArray2M.AssertModel(models[23],_testData[27], false);FlatDecimalnumericArray2M.AssertModel(models[24],_testData[28], false);FlatDecimalnumericArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSelectModelBatchAsync(connection, 66, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
DecimalnumericArray2M.AssertModel(models[0],_testData[13], false);DecimalnumericArray2M.AssertModel(models[1],_testData[14], false);DecimalnumericArray2M.AssertModel(models[2],_testData[15], false);DecimalnumericArray2M.AssertModel(models[3],_testData[16], false);DecimalnumericArray2M.AssertModel(models[4],_testData[17], false);DecimalnumericArray2M.AssertModel(models[5],_testData[18], false);DecimalnumericArray2M.AssertModel(models[6],_testData[19], false);DecimalnumericArray2M.AssertModel(models[7],_testData[20], false);DecimalnumericArray2M.AssertModel(models[8],_testData[21], false);DecimalnumericArray2M.AssertModel(models[9],_testData[22], false);DecimalnumericArray2M.AssertModel(models[10],_testData[23], false);DecimalnumericArray2M.AssertModel(models[11],_testData[24], false);DecimalnumericArray2M.AssertModel(models[12],_testData[25], false);DecimalnumericArray2M.AssertModel(models[13],_testData[26], false);DecimalnumericArray2M.AssertModel(models[14],_testData[27], false);DecimalnumericArray2M.AssertModel(models[15],_testData[28], false);DecimalnumericArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
DecimalnumericArray2M.AssertModel(models[0],_testData[18], false);DecimalnumericArray2M.AssertModel(models[1],_testData[19], false);DecimalnumericArray2M.AssertModel(models[2],_testData[20], false);DecimalnumericArray2M.AssertModel(models[3],_testData[21], false);DecimalnumericArray2M.AssertModel(models[4],_testData[22], false);DecimalnumericArray2M.AssertModel(models[5],_testData[23], false);DecimalnumericArray2M.AssertModel(models[6],_testData[24], false);DecimalnumericArray2M.AssertModel(models[7],_testData[25], false);DecimalnumericArray2M.AssertModel(models[8],_testData[26], false);DecimalnumericArray2M.AssertModel(models[9],_testData[27], false);DecimalnumericArray2M.AssertModel(models[10],_testData[28], false);DecimalnumericArray2M.AssertModel(models[11],_testData[29], false);
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
                var models =  ((IDecimalListnumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSelectModelBatch(connection, 76, 23))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
DecimalnumericArray2M.AssertModel(models[0],_testData[15], false);DecimalnumericArray2M.AssertModel(models[1],_testData[16], false);DecimalnumericArray2M.AssertModel(models[2],_testData[17], false);DecimalnumericArray2M.AssertModel(models[3],_testData[18], false);DecimalnumericArray2M.AssertModel(models[4],_testData[19], false);DecimalnumericArray2M.AssertModel(models[5],_testData[20], false);DecimalnumericArray2M.AssertModel(models[6],_testData[21], false);DecimalnumericArray2M.AssertModel(models[7],_testData[22], false);DecimalnumericArray2M.AssertModel(models[8],_testData[23], false);DecimalnumericArray2M.AssertModel(models[9],_testData[24], false);DecimalnumericArray2M.AssertModel(models[10],_testData[25], false);DecimalnumericArray2M.AssertModel(models[11],_testData[26], false);DecimalnumericArray2M.AssertModel(models[12],_testData[27], false);DecimalnumericArray2M.AssertModel(models[13],_testData[28], false);DecimalnumericArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
DecimalnumericArray2M.AssertModel(models[0],_testData[4], false);DecimalnumericArray2M.AssertModel(models[1],_testData[5], false);DecimalnumericArray2M.AssertModel(models[2],_testData[6], false);DecimalnumericArray2M.AssertModel(models[3],_testData[7], false);DecimalnumericArray2M.AssertModel(models[4],_testData[8], false);DecimalnumericArray2M.AssertModel(models[5],_testData[9], false);DecimalnumericArray2M.AssertModel(models[6],_testData[10], false);DecimalnumericArray2M.AssertModel(models[7],_testData[11], false);DecimalnumericArray2M.AssertModel(models[8],_testData[12], false);DecimalnumericArray2M.AssertModel(models[9],_testData[13], false);DecimalnumericArray2M.AssertModel(models[10],_testData[14], false);DecimalnumericArray2M.AssertModel(models[11],_testData[15], false);DecimalnumericArray2M.AssertModel(models[12],_testData[16], false);DecimalnumericArray2M.AssertModel(models[13],_testData[17], false);DecimalnumericArray2M.AssertModel(models[14],_testData[18], false);DecimalnumericArray2M.AssertModel(models[15],_testData[19], false);DecimalnumericArray2M.AssertModel(models[16],_testData[20], false);DecimalnumericArray2M.AssertModel(models[17],_testData[21], false);DecimalnumericArray2M.AssertModel(models[18],_testData[22], false);DecimalnumericArray2M.AssertModel(models[19],_testData[23], false);DecimalnumericArray2M.AssertModel(models[20],_testData[24], false);DecimalnumericArray2M.AssertModel(models[21],_testData[25], false);DecimalnumericArray2M.AssertModel(models[22],_testData[26], false);DecimalnumericArray2M.AssertModel(models[23],_testData[27], false);DecimalnumericArray2M.AssertModel(models[24],_testData[28], false);DecimalnumericArray2M.AssertModel(models[25],_testData[29], false);
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
                await using var cmd = await ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 75);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
DecimalnumericArray2M.AssertModel(models[0],_testData[14], false);DecimalnumericArray2M.AssertModel(models[1],_testData[15], false);DecimalnumericArray2M.AssertModel(models[2],_testData[16], false);DecimalnumericArray2M.AssertModel(models[3],_testData[17], false);DecimalnumericArray2M.AssertModel(models[4],_testData[18], false);DecimalnumericArray2M.AssertModel(models[5],_testData[19], false);DecimalnumericArray2M.AssertModel(models[6],_testData[20], false);DecimalnumericArray2M.AssertModel(models[7],_testData[21], false);DecimalnumericArray2M.AssertModel(models[8],_testData[22], false);DecimalnumericArray2M.AssertModel(models[9],_testData[23], false);DecimalnumericArray2M.AssertModel(models[10],_testData[24], false);DecimalnumericArray2M.AssertModel(models[11],_testData[25], false);DecimalnumericArray2M.AssertModel(models[12],_testData[26], false);DecimalnumericArray2M.AssertModel(models[13],_testData[27], false);DecimalnumericArray2M.AssertModel(models[14],_testData[28], false);DecimalnumericArray2M.AssertModel(models[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
DecimalnumericArray2M.AssertModel(models[0],_testData[9], false);DecimalnumericArray2M.AssertModel(models[1],_testData[10], false);DecimalnumericArray2M.AssertModel(models[2],_testData[11], false);DecimalnumericArray2M.AssertModel(models[3],_testData[12], false);DecimalnumericArray2M.AssertModel(models[4],_testData[13], false);DecimalnumericArray2M.AssertModel(models[5],_testData[14], false);DecimalnumericArray2M.AssertModel(models[6],_testData[15], false);DecimalnumericArray2M.AssertModel(models[7],_testData[16], false);DecimalnumericArray2M.AssertModel(models[8],_testData[17], false);DecimalnumericArray2M.AssertModel(models[9],_testData[18], false);DecimalnumericArray2M.AssertModel(models[10],_testData[19], false);DecimalnumericArray2M.AssertModel(models[11],_testData[20], false);DecimalnumericArray2M.AssertModel(models[12],_testData[21], false);DecimalnumericArray2M.AssertModel(models[13],_testData[22], false);DecimalnumericArray2M.AssertModel(models[14],_testData[23], false);DecimalnumericArray2M.AssertModel(models[15],_testData[24], false);DecimalnumericArray2M.AssertModel(models[16],_testData[25], false);DecimalnumericArray2M.AssertModel(models[17],_testData[26], false);DecimalnumericArray2M.AssertModel(models[18],_testData[27], false);DecimalnumericArray2M.AssertModel(models[19],_testData[28], false);DecimalnumericArray2M.AssertModel(models[20],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDecimalListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
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
                await ((IDecimalListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDecimalListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
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
FROM public.binary_decimalnumericarray2m m
LEFT JOIN public.binary_decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray2M>(15);

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
                ((IDecimalListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DecimalnumericArray2M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IDecimalListnumericArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDecimalListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DecimalnumericArray2M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray2M.AssertModel(models[14],_testData[14], false);
                DecimalnumericArray2M.AssertModel(models[15],_testData[15], false);
                DecimalnumericArray2M.AssertModel(models[16],_testData[16], false);
                DecimalnumericArray2M.AssertModel(models[17],_testData[17], false);
                DecimalnumericArray2M.AssertModel(models[18],_testData[18], false);
                DecimalnumericArray2M.AssertModel(models[19],_testData[19], false);
                DecimalnumericArray2M.AssertModel(models[20],_testData[20], false);
                DecimalnumericArray2M.AssertModel(models[21],_testData[21], false);
                DecimalnumericArray2M.AssertModel(models[22],_testData[22], false);
                DecimalnumericArray2M.AssertModel(models[23],_testData[23], false);
                DecimalnumericArray2M.AssertModel(models[24],_testData[24], false);
                DecimalnumericArray2M.AssertModel(models[25],_testData[25], false);
                DecimalnumericArray2M.AssertModel(models[26],_testData[26], false);
                DecimalnumericArray2M.AssertModel(models[27],_testData[27], false);
                DecimalnumericArray2M.AssertModel(models[28],_testData[28], false);
                DecimalnumericArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalListnumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalListnumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

