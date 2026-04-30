

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9179186718700487d,

0.7982306202692584d,

0.8103143803946763d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26440021804809943d,

0.22902260514212036d,

0.8696979180655867d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2890049560564505d,

0.43207666030848835d,

0.17207267162504647d,

0.11968648240229773d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6692372027474502d,

0.3976662332726624d,

0.819213367375602d,

0.08961988557375078d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1368650140725307d,

0.3171469228677707d,

0.32507319981696237d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7006396585498308d,

0.8177489727721118d,

0.9467086131887349d,

0.3599688465200723d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.0457495646548689d,

0.6384944677323544d,

0.40370420709237176d,

0.8385202358452263d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8292001059214362d,

0.7743143097894627d,

0.2047681959776323d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8146314987660791d,

0.6963352734754409d,

0.8367468728470002d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5171190038584416d,

0.32790686448724027d,

0.07021326138783268d,

0.9449582510119006d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9992387123673572d,

0.72712224383614d,

0.1990888678071182d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.07537378432605668d,

0.527368757896355d,

0.718416688106221d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6805574934247159d,

0.7074094298467722d,

0.9822061481163835d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8826493925290626d,

0.3539964398453378d,

0.9874509916885938d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7963941491388259d,

0.5606606293416465d,

0.5418509951530791d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7373428907257885d,

0.3789021189093905d,

0.5731758136223335d,

0.7907463434903108d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7152637488233873d,

0.7790543019271805d,

0.1504285122050545d,

0.7600297494988145d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8619271270082969d,

0.9265245720452832d,

0.5202605872846313d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.13788535822350267d,

0.13987709535729287d,

0.1768286818689233d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9917846384636831d,

0.16648138219501962d,

0.6090371929625695d,

0.49921669824325987d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3617909541171569d,

0.9982160886600052d,

0.7280768105886991d,

0.8723182142649504d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5980163261851169d,

0.15106139166091115d,

0.7482849354530002d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7428207059186879d,

0.3611004199167188d,

0.44507989145589766d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6127929602501221d,

0.4295895185830919d,

0.1686853323161589d,

0.013849288995268827d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2122675208113568d,

0.4108613880894041d,

0.6640767983130437d,

0.9481624699845133d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7391517903078137d,

0.9610217156857254d,

0.037985615418249075d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2971771403648291d,

0.43597464331364433d,

0.4285871239117668d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.08951279445803184d,

0.20552132861491723d,

0.7662506258952573d,

0.7493221992543593d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9916733987260197d,

0.1785862570993857d,

0.7558815696166293d,

0.5231145598351838d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8440497935869999d,

0.24290298298053525d,

0.7711713896743605d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3380451526549473d,

0.5852114590520278d,

0.18034188618315528d,

0.07545570225970333d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.09013692468407264d,

0.5591400936410232d,

0.004780860865932435d,

0.9227545097625165d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.20677746871964198d,

0.43283472920325794d,

0.37498859587138567d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.857391849868818d,

0.4116826988906088d,

0.9640166882509178d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4408455727295141d,

0.21220422432640695d,

0.36876191805925906d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18945659510875779d,

0.12877478861241265d,

0.9163155915570725d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.47592147662898077d,

0.32184191345779123d,

0.3822673230826654d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6761842267424695d,

0.47152647801550884d,

0.9101999999121639d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07259553561135268d,

0.5583536133319336d,

0.7482954872222581d,

0.4929190844694642d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6137184222167231d,

0.0005760127310564522d,

0.42949929195000314d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.25566119382875363d,

0.6854299379430019d,

0.9179773684496098d,

0.7213882102712278d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.17423429270077695d,

0.9761004609303702d,

0.056764650399263816d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.10818740227774526d,

0.9398389936296291d,

0.6588020700206989d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3299135126240862d,

0.56124495896175d,

0.485887861078795d,

0.4723750401403063d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6631016515573118d,

0.502121156985384d,

0.6277824017510683d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3784675587717722d,

0.8057253083736435d,

0.4098233168221902d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8903241275163143d,

0.09896642683511625d,

0.39249188627475895d,

0.312166254178481d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4918632198157613d,

0.7823157158690454d,

0.6349743147626825d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3635954860342244d,

0.3767676731134857d,

0.6402736860498482d,

0.9060019714463753d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9635935464534322d,

0.2681012816130227d,

0.3851654507932931d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.14741441555679935d,

0.34959528231909587d,

0.9951510034305291d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3741942154098882d,

0.8513791368940288d,

0.17154527708329204d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.26588378407776436d,

0.9902357701346725d,

0.4112166658428108d,

0.9427648667595687d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.48301379306263925d,

0.8873930117370207d,

0.4968540463136808d,

0.43692495712020785d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3728265991629297d,

0.8881646098731458d,

0.14804097750739798d,

0.8527240961985711d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3709136509807711d,

0.8004240050833181d,

0.18747311051058702d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.904656973460461d,

0.3982777795631893d,

0.39885839555685276d,

0.04274429349519293d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9470455881554584d,

0.01898296217809403d,

0.7016280010910304d,

0.6192339450411611d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8632027621127877d,

0.8184507585015512d,

0.472467985325314d,

0.15006471184100678d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8909732919916414d,

0.4083601372722184d,

0.7983677927113475d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6102541704963896d,

0.1007476374572861d,

0.005551169238401488d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4642403845925531d,

0.526865250205434d,

0.09163020354630047d,

0.6677384087605773d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3902893993284158d,

0.058064678515098d,

0.7611058145165842d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.21188377025191574d,

0.8118185595468497d,

0.7608154024640956d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0026056966967452633d,

0.3789735408276502d,

0.6231527873907525d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.001666292436405259d,

0.13910345007737657d,

0.006060121700396381d,

0.5523536808182714d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5687926724150184d,

0.11217588322978289d,

0.7243562065761189d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7576573203342647d,

0.5439402216840057d,

0.35797917850444716d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8031585829794973d,

0.5306260063205765d,

0.2630570514104732d,

0.8377857080802643d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8126719200892856d,

0.5297044200524041d,

0.6385095900426015d,

0.8515680266998238d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.05188928081531119d,

0.7602620111628724d,

0.49429448647174234d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8080386108465523d,

0.15067608692968892d,

0.9501794828712099d,

0.8539166213729285d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.39453878012510457d,

0.5977099815700915d,

0.8503095720728727d,

0.1354741801985221d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.793764986437928d,

0.20276785604926495d,

0.4435357355516576d,

0.9218646975221061d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7405708185282758d,

0.0780039272110663d,

0.04845242861694998d,

0.7636269709573634d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.017397463323343798d,

0.5222290463861502d,

0.9562723078516632d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6426836303401136d,

0.7983143724840933d,

0.333910354214747d,

0.2800866352050123d,

},
    ModelInner = null,
    NullableValue = null,
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[34], false);
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
                parametr1.Value = 7;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 147, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 43, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 137, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 147, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 143, query1, 114, query2))
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
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 107, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 25, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[34], false);
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
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 21, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[29],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 12, 31))
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
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionArray2M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionArray2M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionArray2M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionArray2M.AssertModel(models[28],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 147, 43))
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 25);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[6], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[7], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[8], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[21],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[22],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[23],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[24],_testData[29], false);Doubledouble_precisionArray2M.AssertModel(models[25],_testData[30], false);Doubledouble_precisionArray2M.AssertModel(models[26],_testData[31], false);Doubledouble_precisionArray2M.AssertModel(models[27],_testData[32], false);Doubledouble_precisionArray2M.AssertModel(models[28],_testData[33], false);Doubledouble_precisionArray2M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[29], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[30], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[31], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[32], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[33], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[34], false);
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
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
            dbTypes: null,
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
            dbTypes: null,
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
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
            dbTypes: null,
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
            dbTypes: null,
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

