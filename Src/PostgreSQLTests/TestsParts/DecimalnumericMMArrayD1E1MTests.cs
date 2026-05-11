

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
    internal partial interface IDecimalMArraynumericMMArrayD1
    {
    }
    
    internal partial class DecimalMArraynumericMMArrayD1 : IDecimalMArraynumericMMArrayD1
    {


#region TestData

        private readonly DecimalnumericMMArrayD1E1M[] _testData = new DecimalnumericMMArrayD1E1M[]
        {
            new DecimalnumericMMArrayD1E1M
{
    Id = 3,
    Value = 
new System.Decimal[4]
{
0.84089997173546m,
0.654774322575862m,
0.609178711436955m,
0.192153092065286m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 7,
    Value = 
new System.Decimal[4]
{
0.775450821276734m,
0.573971212471562m,
0.00097741650473604m,
0.66530557990632m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Decimal[3]
{
0.445887093969747m,
0.480552509402257m,
0.721323074748119m,
},
    NullableValue = 
new System.Decimal[4]
{
0.098967413593623m,
0.550120845810888m,
0.123954430030241m,
0.487538907166417m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.590439494113813m,
0.593947397778948m,
0.267178560271764m,
0.194438689409724m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 12,
    Value = 
new System.Decimal[4]
{
0.533611812397766m,
0.650610851371424m,
0.447619835759613m,
0.0713305451113857m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.236301403419479m,
0.38893498679409m,
0.518308815497367m,
0.253285462335498m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Decimal[4]
{
0.434377088315591m,
0.48608633845456m,
0.91346847654302m,
0.251772409895651m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Decimal[3]
{
0.835369162670155m,
0.907821356998798m,
0.939223368352741m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 16,
    Value = 
new System.Decimal[3]
{
0.310400241551881m,
0.430504761123888m,
0.800362663534866m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Decimal[3]
{
0.869778636929763m,
0.974282597120712m,
0.260495851524953m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Decimal[4]
{
0.293467007893028m,
0.0657992926275809m,
0.584351682369065m,
0.193107527420824m,
},
    NullableValue = 
new System.Decimal[3]
{
0.842211318047937m,
0.843587724480515m,
0.0166506381044249m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.780139582988103m,
0.443498065982914m,
0.936718128045819m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Decimal[4]
{
0.83008277081965m,
0.498825531821539m,
0.766367814274716m,
0.264822499124119m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Decimal[4]
{
0.899742573612458m,
0.00177073139224093m,
0.844063658465255m,
0.205405840522961m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Decimal[3]
{
0.827100862773368m,
0.377622744081582m,
0.81683336213629m,
},
    NullableValue = 
new System.Decimal[4]
{
0.593542236086192m,
0.885772366478258m,
0.561496459429205m,
0.993011311818892m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.531221026193987m,
0.739798132617365m,
0.911558019720422m,
0.868122025425059m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Decimal[3]
{
0.0731075805861339m,
0.354008415699154m,
0.325857847900681m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Decimal[4]
{
0.273997666523271m,
0.686601204807474m,
0.685541834192947m,
0.972252454910916m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Decimal[4]
{
0.213566335884773m,
0.657013404365686m,
0.865824954249809m,
0.0512277565832187m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Decimal[3]
{
0.955233446077527m,
0.997837815525511m,
0.217344676246791m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 50,
    Value = 
new System.Decimal[4]
{
0.230962206831706m,
0.022464750144762m,
0.337569060660044m,
0.116192042725371m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Decimal[4]
{
0.330093267505992m,
0.912309081555866m,
0.0524905930254975m,
0.000994620244440525m,
},
    NullableValue = 
new System.Decimal[3]
{
0.981191231821878m,
0.380932621576528m,
0.525498909930585m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 59,
    Value = 
new System.Decimal[3]
{
0.500872035800056m,
0.0672328503594931m,
0.969930416681634m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.213668520769894m,
0.617880719393472m,
0.139504764767522m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Decimal[3]
{
0.175601266699113m,
0.355498572598781m,
0.283991146687857m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Decimal[4]
{
0.602940596185198m,
0.925010102804497m,
0.842843905508521m,
0.322170770165785m,
},
    NullableValue = 
new System.Decimal[4]
{
0.0416700686520373m,
0.413103531501662m,
0.611207948484772m,
0.0011663077450671m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.466271226405577m,
0.310349329469838m,
0.550471921849886m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 63,
    Value = 
new System.Decimal[4]
{
0.983072704455702m,
0.807854703565608m,
0.226064883936639m,
0.708692341394378m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 69,
    Value = 
new System.Decimal[3]
{
0.0738452078701709m,
0.308800066150191m,
0.431320804162475m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Decimal[4]
{
0.929388859364366m,
0.0472140168448418m,
0.820682556824416m,
0.134019251236192m,
},
    NullableValue = 
new System.Decimal[3]
{
0.579931374700189m,
0.540784699802838m,
0.541541749358393m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.79420049975878m,
0.0217536335497421m,
0.381599383326696m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Decimal[4]
{
0.670316896486304m,
0.775688168941336m,
0.854598716931283m,
0.715110714279866m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Decimal[3]
{
0.471060970035206m,
0.528849817410945m,
0.909285155030077m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 42,
    Value = 
new System.Decimal[4]
{
0.203862961230918m,
0.709517843582306m,
0.596584258290564m,
0.60581218173618m,
},
    NullableValue = 
new System.Decimal[4]
{
0.0623220858755235m,
0.306693346134328m,
0.456906359695443m,
0.256003640118472m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.111455872053922m,
0.783477927515348m,
0.931103023312544m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 85,
    Value = 
new System.Decimal[4]
{
0.389294219047347m,
0.0897117319635274m,
0.747625921088966m,
0.209454587517912m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Decimal[3]
{
0.0763811446708679m,
0.39469823839423m,
0.218425317645498m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Decimal[4]
{
0.929174150794268m,
0.458764547728767m,
0.597059787318008m,
0.946091262191773m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Decimal[4]
{
0.25348753215387m,
0.225683506262562m,
0.420000653912275m,
0.7262751786587m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 104,
    Value = 
new System.Decimal[4]
{
0.394028797119933m,
0.307824011321577m,
0.496811954159544m,
0.325809745792791m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Decimal[4]
{
0.0726831301141918m,
0.96271971998524m,
0.354059921627718m,
0.751742815538409m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 110,
    Value = 
new System.Decimal[3]
{
0.811640216673572m,
0.388314157903244m,
0.212047667215535m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 117,
    Value = 
new System.Decimal[3]
{
0.486407648549318m,
0.895480490414501m,
0.71832654545829m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 57,
    Value = 
new System.Decimal[3]
{
0.40827608566209m,
0.64165482752377m,
0.82533954578649m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.0373798888674296m,
0.72386637262726m,
0.306502111360435m,
0.0463928447080351m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 125,
    Value = 
new System.Decimal[3]
{
0.223249047330783m,
0.474693298555221m,
0.424410581130915m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.638036461922934m,
0.495767541351058m,
0.336253370743524m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Decimal[4]
{
0.458876078195255m,
0.667919827431057m,
0.597450433740472m,
0.757528868251291m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Decimal[4]
{
0.47593000053921m,
0.391809857642549m,
0.440943623583002m,
0.818154005387261m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.855595207165972m,
0.408595149112561m,
0.586593910245732m,
0.326741614536215m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 135,
    Value = 
new System.Decimal[3]
{
0.0816771917358626m,
0.705258882336625m,
0.0143026583013184m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.402407799996789m,
0.856788458011947m,
0.237296115596952m,
0.959139147286637m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Decimal[3]
{
0.12177241810158m,
0.198078961869464m,
0.344410056040622m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Decimal[3]
{
0.771865268697906m,
0.414516322002091m,
0.3835485316603m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Decimal[4]
{
0.363637723428409m,
0.195854007484642m,
0.32236151449423m,
0.514880314038992m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Decimal[4]
{
0.662335725107249m,
0.790896300511074m,
0.847404970817632m,
0.272824280831331m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Decimal[3]
{
0.450151828025365m,
0.625845750557007m,
0.692331504571351m,
},
    NullableValue = 
new System.Decimal[3]
{
0.404570242925079m,
0.298820794227276m,
0.730786871134884m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 157,
    Value = 
new System.Decimal[3]
{
0.556501565977003m,
0.859953681521312m,
0.786928437311842m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Decimal[4]
{
0.0448885279364123m,
0.351596906240579m,
0.0814815579019769m,
0.0303653338910744m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Decimal[3]
{
0.715715185946142m,
0.0755528977418864m,
0.378368694973159m,
},
    NullableValue = 
new System.Decimal[3]
{
0.703098720702605m,
0.0381705868343474m,
0.34502943576361m,
},
},
    NullableValue = null,
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Decimal[4]
{
0.641504603646459m,
0.7118758953629m,
0.474066761654838m,
0.385502291125281m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.601001469783384m,
0.76258062515028m,
0.578965391987168m,
0.0612671455947536m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 171,
    Value = 
new System.Decimal[3]
{
0.0918708697265285m,
0.584393304933267m,
0.622214610327188m,
},
    ModelInner = new DecimalnumericMMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Decimal[4]
{
0.70320780855393m,
0.34419031762225m,
0.548016496747306m,
0.592751427152894m,
},
    NullableValue = 
new System.Decimal[4]
{
0.0632779862679129m,
0.597394443585746m,
0.577456671233882m,
0.814494170019183m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.570669764826438m,
0.847524329550463m,
0.155367320139164m,
0.0153199242085121m,
},
},
            new DecimalnumericMMArrayD1E1M
{
    Id = 173,
    Value = 
new System.Decimal[4]
{
0.912419631596044m,
0.212843762043116m,
0.893482799426135m,
0.178628535706934m,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1mi(
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1mi(
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
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
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

                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmmarrayd1e1mi_id", 
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
                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalMArraynumericMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.780139582988103m,
0.443498065982914m,
0.936718128045819m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
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

                    nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.531221026193987m,
0.739798132617365m,
0.911558019720422m,
0.868122025425059m,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    decimalnumericmmarrayd1e1mi_id
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
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericmmarrayd1e1mi_id", 
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
                System.Decimal[] nullable = null;
                nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDecimalMArraynumericMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD1E1M> models = null;

                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericMMArrayD1E1M> models = null;

                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalMArraynumericMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 15;
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M), typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 74, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 32, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var models2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 69, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var firstItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 32, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 135, query1, 104, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 160, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 3, query1, 110, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
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
FROM public.decimalnumericmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems1 = new List<FlatDecimalnumericMMArrayD1E1M>();
                var secondItems2 = new List<FlatDecimalnumericMMArrayD1E1M>();
                 ((IDecimalMArraynumericMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 146, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDecimalnumericMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.decimalnumericmmarrayd1e1m m
LEFT JOIN public.decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
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
                var models = await((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 15, 162))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalMArraynumericMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 36, 59))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        DecimalnumericMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
                await using var cmd = await ((IDecimalMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalMArraynumericMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalMArraynumericMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models =  ((IDecimalMArraynumericMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                DecimalnumericMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                DecimalnumericMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MI),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalMArraynumericMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalMArraynumericMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericMMArrayD1E1M),
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
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
FROM public.binary_decimalnumericmmarrayd1e1m m
LEFT JOIN public.binary_decimalnumericmmarrayd1e1mi mi ON mi.id = m.decimalnumericmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalMArraynumericMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalMArraynumericMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalMArraynumericMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IDecimalMArraynumericMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models =  ((IDecimalMArraynumericMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericmmarrayd1e1mi
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
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI), typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericMMArrayD1E1MI>();
                var models2 = new List<DecimalnumericMMArrayD1E1MI>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MI>();
                var models2 = new List<DecimalnumericMMArrayD1E1MI>();
                ((IDecimalMArraynumericMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA), typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                await ((IDecimalMArraynumericMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericMMArrayD1E1MIWA>();
                var models2 = new List<DecimalnumericMMArrayD1E1MIWA>();
                ((IDecimalMArraynumericMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalMArraynumericMMArrayD1))]
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
                var models = await ((IDecimalMArraynumericMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalMArraynumericMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

