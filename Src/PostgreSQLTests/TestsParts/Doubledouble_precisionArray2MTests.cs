

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5554159616322331d,

0.12493326437479113d,

0.5784735141056627d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9258452470213534d,

0.40767195589994665d,

0.5526893391893223d,

0.6978732985800112d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.03425581963408564d,

0.6122876015594945d,

0.6811166503513129d,

0.5162183081042021d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6977036997661693d,

0.6054970281961449d,

0.672884558915714d,

0.06733676149066814d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1107963973404622d,

0.6145269862784056d,

0.05717725116342365d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31473467260909394d,

0.11685794710788289d,

0.7176835302170457d,

0.3085905805674618d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2801971729346313d,

0.6201575782138551d,

0.8430327987757085d,

0.09785518977261631d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9297378559997738d,

0.975794364118983d,

0.669614821407447d,

0.6768919495894345d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3688961205830428d,

0.6170732684758022d,

0.43780209849029217d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.010379961570137208d,

0.8077198153359836d,

0.2395071669425738d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8351230323368001d,

0.6431423136342953d,

0.5780736318091718d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5021521542069333d,

0.5661481050743495d,

0.7891625856083712d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.655624456056532d,

0.9907729446797867d,

0.7992077244543462d,

0.7655350089159417d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.551256446011247d,

0.11619648670267735d,

0.8815052565781952d,

0.6956861729764348d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4830412113618927d,

0.418841575513355d,

0.005588709182208218d,

0.8982947051868123d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8643817053401682d,

0.6898024759858765d,

0.4155508387921253d,

0.23521189025629474d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6360447487610037d,

0.6538322461837064d,

0.7557413272271051d,

0.859768986434945d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0806691823955904d,

0.04042316656798617d,

0.9699667583722414d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.637100852746725d,

0.023440028949205605d,

0.29159897689045167d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.40802265520872805d,

0.8405116774505951d,

0.8242878061756783d,

0.02056325239345902d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3217135186516875d,

0.7026913153013545d,

0.849212618802213d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9183687684574787d,

0.7493009396065372d,

0.5240314446047519d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6740853965050517d,

0.9283487548158527d,

0.7382459474501779d,

0.09372488386568922d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7802964797241912d,

0.6581597188521854d,

0.48443662176813274d,

0.9262720509639474d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.30627203859579044d,

0.8842130251016483d,

0.5308130229797337d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9141556992853376d,

0.8133826747666215d,

0.32519533340564577d,

0.30476530693489556d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7767178274382763d,

0.34085872277480667d,

0.5623156960435479d,

0.513813240232887d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.35398205638887326d,

0.3429172010989525d,

0.6512905560383935d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6246740679363597d,

0.23152884052013245d,

0.028413428652995676d,

0.2168552197865118d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.24066547784441183d,

0.44144766368526955d,

0.3186268487902517d,

0.8493825768571392d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7879480429958147d,

0.1551582261287906d,

0.7010416434967237d,

0.41072914107445113d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9907217949687237d,

0.15369745234781595d,

0.5988147767149196d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.011237692809524913d,

0.9211164150353836d,

0.11581576507189673d,

0.06394993250188163d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.08841218293395414d,

0.8342881400707673d,

0.6691112754419911d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9776219868333387d,

0.7309557719051585d,

0.9040819814238881d,

0.2044759009390663d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.28123150270716d,

0.8492044669043199d,

0.6302774375026494d,

0.8705337239064426d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7785229634297223d,

0.6332540133339614d,

0.2283471633748848d,

0.321219654700017d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9539954332331454d,

0.40539590347294086d,

0.9854905474441047d,

0.10074278060168662d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8556428850988413d,

0.3161438198636781d,

0.4239546344305657d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9183539283179595d,

0.7952195823039707d,

0.17060806441173804d,

0.6572001075341531d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.10842015104398672d,

0.9593193352813673d,

0.772280229980952d,

0.9309091638877097d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.37078048794872664d,

0.2116371754582388d,

0.31117721594505265d,

0.5762295966549578d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9276686606863358d,

0.0564855928643041d,

0.6979594777104978d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.13164705699873636d,

0.2637229346428346d,

0.27459235121734915d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5731112740062639d,

0.607058537943232d,

0.9218805869876556d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.09157082584109599d,

0.4501259046235806d,

0.2405144499600015d,

0.47317548817634847d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.42033719901841826d,

0.6951475839417837d,

0.852559270900358d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5593459674164558d,

0.6780933968766936d,

0.7750113744437302d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05343605694591358d,

0.4970503301026572d,

0.5259642766353352d,

0.1909150506651529d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.30657274575220983d,

0.2861830705402021d,

0.9911199601921281d,

0.5530324463063793d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2621278748056277d,

0.14884207335053978d,

0.5576398298635299d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8403320005623364d,

0.5722848627276711d,

0.020491126008020832d,

0.9766959087278003d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6767215900582269d,

0.8898642053161913d,

0.9540295880125164d,

0.7870719121874654d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6749178100083361d,

0.06412489251354925d,

0.8666378656974181d,

0.7739007156647661d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9548357308752867d,

0.9970720758830952d,

0.5807636638416531d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.684995306382295d,

0.13374385669442568d,

0.6973275911881577d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7946005995510369d,

0.9076225819446517d,

0.6601028054246746d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.17708253861658507d,

0.5998383524766379d,

0.7604087688143257d,

0.21680712426176585d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3644674237967107d,

0.9849556507240184d,

0.14565176364464505d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9405374672738847d,

0.22253994181113457d,

0.958570366051373d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7780150808559303d,

0.47563967789245154d,

0.9669964322686015d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8945778515505722d,

0.6159733136335388d,

0.7324345159760957d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.03318813687677702d,

0.7492396295138952d,

0.3039598434436056d,

0.7044875242240914d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2591096084710297d,

0.9118891512814834d,

0.06744460310792544d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11830207282059613d,

0.13473383119874072d,

0.8125865802490644d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.48058787099743394d,

0.303227262611663d,

0.29953196805565274d,

0.6867099755369754d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3616554097120608d,

0.18435777678000997d,

0.4797455067942784d,

0.30273079036499917d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4020668071038952d,

0.05719114678025006d,

0.5665130361684051d,

0.16372587061697164d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 184,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.35572758091829115d,

0.9308978392016782d,

0.8757362593051943d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3151431244337558d,

0.4062898904162522d,

0.8837607430968858d,

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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[32],_testData[34], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[34], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 72, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 139, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 93, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 20, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 167, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 175, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 20, query1, 131, query2))
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 93, query1, 20, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 89, 171))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 98, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[14], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[15], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[16], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[17], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[18], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[19], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[20], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[21], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[22], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[23], false);
                Doubledouble_precisionArray2M.AssertModel(models[15],_testData[24], false);
                Doubledouble_precisionArray2M.AssertModel(models[16],_testData[25], false);
                Doubledouble_precisionArray2M.AssertModel(models[17],_testData[26], false);
                Doubledouble_precisionArray2M.AssertModel(models[18],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[19],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[20],_testData[29], false);
                Doubledouble_precisionArray2M.AssertModel(models[21],_testData[30], false);
                Doubledouble_precisionArray2M.AssertModel(models[22],_testData[31], false);
                Doubledouble_precisionArray2M.AssertModel(models[23],_testData[32], false);
                Doubledouble_precisionArray2M.AssertModel(models[24],_testData[33], false);
                Doubledouble_precisionArray2M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 63);
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

