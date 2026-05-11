

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
    internal partial interface IDecimalListnumericListD1
    {
    }
    
    internal partial class DecimalListnumericListD1 : IDecimalListnumericListD1
    {


#region TestData

        private readonly DecimalnumericListD1E2M[] _testData = new DecimalnumericListD1E2M[]
        {
            new DecimalnumericListD1E2M
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.443244254752378m,

0.150062443255447m,

0.563673842468154m,

0.47747802944308m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.924911968920516m,

0.789752188124767m,

0.314394750750693m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.417169041626715m,

0.605657276995287m,

0.0351363796295042m,

0.170263275047385m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.497286260709091m,

0.0301361607556254m,

0.548614363043094m,

0.75792228755465m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0813761635204754m,

0.481368063764862m,

0.704575139152398m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.666193265397676m,

0.50149079757033m,

0.146196107089567m,

0.979266371984921m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.627924497330756m,

0.311661250196571m,

0.478104271812985m,

0.330814884633257m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0154113584400373m,

0.67386306704844m,

0.503329999292056m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.6077473021949m,

0.493608628818001m,

0.600211273089775m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.720952598687975m,

0.779275928298287m,

0.114757587616291m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.434413839568937m,

0.364006941394366m,

0.353116020841233m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.510687557329774m,

0.5361345806477m,

0.880938862888578m,

0.222370980351734m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0739985579927155m,

0.0644636067068811m,

0.523402573851014m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.805738122383553m,

0.476179883698444m,

0.0982856457002682m,

0.861223093602506m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.600491428516412m,

0.883262699027959m,

0.452864238421862m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.456199710425142m,

0.699686050058728m,

0.829410178333459m,

0.707302779807129m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.890358353094402m,

0.846230260882271m,

0.568822609584227m,

0.047679124927939m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.731395641460194m,

0.118343776937857m,

0.787507878671886m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.309140874898501m,

0.345011987143155m,

0.139590988859428m,

0.044403696522955m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.801685289200604m,

0.250287910601131m,

0.22492156496452m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.706647006275869m,

0.783894282173333m,

0.79249083915774m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.112056740590528m,

0.584306204740456m,

0.169725867522856m,

0.457518819435612m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.756016401591118m,

0.0864152925432639m,

0.655942214634817m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.334536109315042m,

0.447812316538457m,

0.304982785430542m,

0.924473726711113m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632733028029923m,

0.778725108818156m,

0.981444540004352m,

0.869005936879859m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.678519669106376m,

0.326644051659552m,

0.914060274318267m,

0.340571028630432m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.567880175925433m,

0.733077112458411m,

0.0685952435068997m,

0.742725083368658m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.538706220760634m,

0.745211702220762m,

0.450790140248864m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.812529158890938m,

0.35483753363822m,

0.363305061687475m,

0.247155735307514m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.337929199351796m,

0.578622262688344m,

0.135569916818509m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.371138555441703m,

0.448793253834187m,

0.986934230807015m,

0.465874948085847m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.56392982643017m,

0.40529451605564m,

0.713601820844791m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.432651725535759m,

0.457681132996006m,

0.147109731582542m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.377917040384736m,

0.521657281956455m,

0.807989606789736m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.461281181889708m,

0.441647249344963m,

0.573156453869734m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.483164165073752m,

0.146697406266098m,

0.0559999458880117m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.706769434402747m,

0.524015425105799m,

0.979629380051018m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.966471544799199m,

0.285760879887253m,

0.16778106760939m,

0.269470461134736m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.254950516322059m,

0.816440447629223m,

0.776461336006826m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.534855810758454m,

0.295419870278729m,

0.912261237176419m,

0.166806778346916m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0287114819940874m,

0.847532572993636m,

0.639093067007463m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.854606432631169m,

0.0423405004186027m,

0.744075108913386m,

0.563870326694614m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.671487192306836m,

0.78437140852086m,

0.73328239636092m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0622373521854638m,

0.846221583177053m,

0.711961778168149m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.228172610410786m,

0.206131791312592m,

0.70608508868227m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.567558035020581m,

0.527412210371848m,

0.541591086388173m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.253045656200565m,

0.527212087510166m,

0.897141402752694m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.142770228570253m,

0.0142377045327658m,

0.241164604416316m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.151604972423071m,

0.922853621519715m,

0.548341594279538m,

0.37699428266722m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.465282556820162m,

0.884757015471376m,

0.461065942328572m,

0.381103021598097m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.760761904149063m,

0.895472158237372m,

0.103276122014983m,

0.522409821437198m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.478434631962478m,

0.622850610115468m,

0.823710362358915m,

0.949227596968624m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.377485156561597m,

0.460828608673738m,

0.955180726473482m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.19932729602639m,

0.304487987127833m,

0.307636608263129m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.225002524809833m,

0.453561980380941m,

0.656916850610917m,

0.152204360784307m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.25012588531538m,

0.917900538503296m,

0.862881087001005m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.180305609425025m,

0.571564856469304m,

0.720224366323378m,

0.922149433223042m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.670952355222881m,

0.640308058189301m,

0.391210629041722m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0476455078201838m,

0.60760390764041m,

0.796522883026454m,

0.445276808772729m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0402952129973218m,

0.829227509060898m,

0.761967744118518m,

0.215463371990123m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.61546019502802m,

0.990952737065784m,

0.49177278039877m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.35797739022508m,

0.987255799518908m,

0.457605811893223m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.485883503978401m,

0.389402093404397m,

0.790998694400087m,

0.926826688396052m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.378512906653026m,

0.0302181531170129m,

0.703838380984647m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.817914126236494m,

0.754493687538931m,

0.265914488252084m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.899008740882014m,

0.797724071441133m,

0.542247233763609m,

0.87870166785783m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.191261137229186m,

0.896324688856839m,

0.0556410731991103m,

0.805402616758425m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.289105085836009m,

0.367863427343582m,

0.795328985686527m,

0.799085410567167m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.393982841156336m,

0.558232122338798m,

0.439531988641251m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.676574460735846m,

0.509083147381051m,

0.865889342866099m,

0.763955880895584m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.8374789732135m,

0.937254910476563m,

0.205451536545202m,

0.0490532869149876m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.553443194068367m,

0.397806810455088m,

0.515301995500107m,

0.0538360964439702m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.432426747179659m,

0.593701679132252m,

0.525303495379127m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.291154191323475m,

0.230996700907073m,

0.635322740624002m,

0.677711055709909m,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2mi(
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
INSERT INTO public.decimalnumericlistd1e2mi(
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
            queryMapTypes: [typeof(DecimalnumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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

                changedRows =  ((IDecimalListnumericListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListnumericListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalListnumericListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListnumericListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalListnumericListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalListnumericListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2m(
	id,
    value,
    nullablevalue,
    decimalnumericlistd1e2mi_id
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
            asPartInterface: typeof(IDecimalListnumericListD1)), 
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
                methodParametrName: "decimalnumericlistd1e2mi_id", 
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
                changedRows =  ((IDecimalListnumericListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalListnumericListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalListnumericListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalListnumericListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2m(
	id,
    value,
    nullablevalue,
    decimalnumericlistd1e2mi_id
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
    decimalnumericlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2m(
	id,
    value,
    nullablevalue,
    decimalnumericlistd1e2mi_id
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
    decimalnumericlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                methodParametrName: "decimalnumericlistd1e2mi_id", 
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
                List<DecimalnumericListD1E2M> models = null;

                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericListD1E2M> models = null;

                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalListnumericListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalListnumericListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await ((IDecimalListnumericListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalListnumericListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListnumericListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await ((IDecimalListnumericListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalListnumericListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[25],_testData[34], false);
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
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await((IDecimalListnumericListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[34], false);
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
                var models = ((IDecimalListnumericListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[6], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[7], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[8], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[26],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[27],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 121, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 103, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 129, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 117, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 14, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 148, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 21, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 40, query1, 18, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await((IDecimalListnumericListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 157, 1))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[1], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[2], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[3], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[4], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[5], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[6], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[7], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[8], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[26],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[27],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[28],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[29],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[30],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[31],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[32],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[33],_testData[34], false);
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
                var models = ((IDecimalListnumericListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 79, 21))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[7], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[8], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[26],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[27],_testData[34], false);
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
                await using var cmd = await ((IDecimalListnumericListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models = await ((IDecimalListnumericListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                DecimalnumericListD1E2M.AssertModel(models[0],_testData[12], false);
                DecimalnumericListD1E2M.AssertModel(models[1],_testData[13], false);
                DecimalnumericListD1E2M.AssertModel(models[2],_testData[14], false);
                DecimalnumericListD1E2M.AssertModel(models[3],_testData[15], false);
                DecimalnumericListD1E2M.AssertModel(models[4],_testData[16], false);
                DecimalnumericListD1E2M.AssertModel(models[5],_testData[17], false);
                DecimalnumericListD1E2M.AssertModel(models[6],_testData[18], false);
                DecimalnumericListD1E2M.AssertModel(models[7],_testData[19], false);
                DecimalnumericListD1E2M.AssertModel(models[8],_testData[20], false);
                DecimalnumericListD1E2M.AssertModel(models[9],_testData[21], false);
                DecimalnumericListD1E2M.AssertModel(models[10],_testData[22], false);
                DecimalnumericListD1E2M.AssertModel(models[11],_testData[23], false);
                DecimalnumericListD1E2M.AssertModel(models[12],_testData[24], false);
                DecimalnumericListD1E2M.AssertModel(models[13],_testData[25], false);
                DecimalnumericListD1E2M.AssertModel(models[14],_testData[26], false);
                DecimalnumericListD1E2M.AssertModel(models[15],_testData[27], false);
                DecimalnumericListD1E2M.AssertModel(models[16],_testData[28], false);
                DecimalnumericListD1E2M.AssertModel(models[17],_testData[29], false);
                DecimalnumericListD1E2M.AssertModel(models[18],_testData[30], false);
                DecimalnumericListD1E2M.AssertModel(models[19],_testData[31], false);
                DecimalnumericListD1E2M.AssertModel(models[20],_testData[32], false);
                DecimalnumericListD1E2M.AssertModel(models[21],_testData[33], false);
                DecimalnumericListD1E2M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models =  ((IDecimalListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                DecimalnumericListD1E2M.AssertModel(models[0],_testData[12], false);
                DecimalnumericListD1E2M.AssertModel(models[1],_testData[13], false);
                DecimalnumericListD1E2M.AssertModel(models[2],_testData[14], false);
                DecimalnumericListD1E2M.AssertModel(models[3],_testData[15], false);
                DecimalnumericListD1E2M.AssertModel(models[4],_testData[16], false);
                DecimalnumericListD1E2M.AssertModel(models[5],_testData[17], false);
                DecimalnumericListD1E2M.AssertModel(models[6],_testData[18], false);
                DecimalnumericListD1E2M.AssertModel(models[7],_testData[19], false);
                DecimalnumericListD1E2M.AssertModel(models[8],_testData[20], false);
                DecimalnumericListD1E2M.AssertModel(models[9],_testData[21], false);
                DecimalnumericListD1E2M.AssertModel(models[10],_testData[22], false);
                DecimalnumericListD1E2M.AssertModel(models[11],_testData[23], false);
                DecimalnumericListD1E2M.AssertModel(models[12],_testData[24], false);
                DecimalnumericListD1E2M.AssertModel(models[13],_testData[25], false);
                DecimalnumericListD1E2M.AssertModel(models[14],_testData[26], false);
                DecimalnumericListD1E2M.AssertModel(models[15],_testData[27], false);
                DecimalnumericListD1E2M.AssertModel(models[16],_testData[28], false);
                DecimalnumericListD1E2M.AssertModel(models[17],_testData[29], false);
                DecimalnumericListD1E2M.AssertModel(models[18],_testData[30], false);
                DecimalnumericListD1E2M.AssertModel(models[19],_testData[31], false);
                DecimalnumericListD1E2M.AssertModel(models[20],_testData[32], false);
                DecimalnumericListD1E2M.AssertModel(models[21],_testData[33], false);
                DecimalnumericListD1E2M.AssertModel(models[22],_testData[34], false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MIWA),
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
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MI),
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
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericListD1E2M),
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
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
FROM public.binary_decimalnumericlistd1e2m m
LEFT JOIN public.binary_decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalListnumericListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericListD1)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListnumericListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models =  ((IDecimalListnumericListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA), typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                await ((IDecimalListnumericListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                ((IDecimalListnumericListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await ((IDecimalListnumericListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA), typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                await ((IDecimalListnumericListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                ((IDecimalListnumericListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models = await ((IDecimalListnumericListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MI), typeof(DecimalnumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models1 = new List<DecimalnumericListD1E2MI>();
                var models2 = new List<DecimalnumericListD1E2MI>();
                await ((IDecimalListnumericListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MI>();
                var models2 = new List<DecimalnumericListD1E2MI>();
                ((IDecimalListnumericListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await ((IDecimalListnumericListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA), typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                await ((IDecimalListnumericListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                ((IDecimalListnumericListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models = await ((IDecimalListnumericListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

