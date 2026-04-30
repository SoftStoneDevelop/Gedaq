

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
    internal partial interface INpgsqlBoxSingleTypebox
    {
    }
    
    internal partial class NpgsqlBoxSingleTypebox : INpgsqlBoxSingleTypebox
    {


#region TestData

        private readonly NpgsqlBoxbox0M[] _testData = new NpgsqlBoxbox0M[]
        {
            new NpgsqlBoxbox0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7411835513018386d,right: 0.639022058050705d,bottom: 0.2702188952333603d,left: 0.06431088529724327d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5290225521823438d,right: 0.36828344117771983d,bottom: 0.3144702874295776d,left: 0.05965364548833696d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7129339288111223d,right: 0.9356833776529885d,bottom: 0.21622975887987095d,left: 0.6891464523134334d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6420670144894381d,right: 0.48345647015857895d,bottom: 0.08957356682565965d,left: 0.3893691639215743d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2734152116307923d,right: 0.15961660013904821d,bottom: 0.1310258367104189d,left: 0.05988374662531959d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.546108078261603d,right: 0.8510883148011531d,bottom: 0.0232033094898616d,left: 0.011456650053629613d),
},
            new NpgsqlBoxbox0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.526543204293471d,right: 0.5339959652729229d,bottom: 0.11815585332371525d,left: 0.3187014933689992d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8032792564520329d,right: 0.6705567743731106d,bottom: 0.2694958045238439d,left: 0.6060886630360128d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9639778129238565d,right: 0.7128670430222316d,bottom: 0.38593377783097427d,left: 0.4489604186267606d),
},
            new NpgsqlBoxbox0M
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9931712852596413d,right: 0.8201269264954236d,bottom: 0.354867107886495d,left: 0.0624924715159354d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9044503541653651d,right: 0.8484045008544479d,bottom: 0.7224719052369838d,left: 0.7018015635616632d),
},
            new NpgsqlBoxbox0M
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.90069065540623d,right: 0.5153525378906585d,bottom: 0.6150718294015024d,left: 0.08832015207452626d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1868656591036495d,right: 0.47477119172804894d,bottom: 0.006175763586876659d,left: 0.0682091968213836d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9413110171501675d,right: 0.7995328512670762d,bottom: 0.01453796904547966d,left: 0.34099035094844043d),
},
            new NpgsqlBoxbox0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7579282644007976d,right: 0.27484097584555967d,bottom: 0.7063599118982491d,left: 0.11930349652193784d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6267974939671639d,right: 0.7735466078873533d,bottom: 0.3811626646696532d,left: 0.24988100490191256d),
},
            new NpgsqlBoxbox0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5136297505696512d,right: 0.5038164026536497d,bottom: 0.16302061721912608d,left: 0.0007083959516523963d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7473225751150805d,right: 0.834969520672516d,bottom: 0.12317738380536014d,left: 0.14359383465603004d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9268164348689313d,right: 0.8712726877170912d,bottom: 0.3568279416057174d,left: 0.5657731014652377d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7917918186569265d,right: 0.9384175569323739d,bottom: 0.753783008855189d,left: 0.7038480376677887d),
},
            new NpgsqlBoxbox0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9316146012708805d,right: 0.8166397961818032d,bottom: 0.1989077377614462d,left: 0.10497441860065759d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9360185563875048d,right: 0.8679123573479144d,bottom: 0.32751670626506846d,left: 0.22309472327611812d),
},
            new NpgsqlBoxbox0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7310600545925768d,right: 0.657311643503193d,bottom: 0.6862988203248952d,left: 0.2938747018985779d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9927313750151824d,right: 0.7576828895802918d,bottom: 0.9011290905876388d,left: 0.5254879419892563d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9076279265305819d,right: 0.8339028414931551d,bottom: 0.18454981488246247d,left: 0.05075548312207989d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.23468415471370008d,right: 0.5560509882437831d,bottom: 0.10150136673300514d,left: 0.2690200301625044d),
},
            new NpgsqlBoxbox0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5022404051892971d,right: 0.2773334213264942d,bottom: 0.20860602868086575d,left: 0.16658785403776455d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8609572846104595d,right: 0.8829417394927179d,bottom: 0.6047286444212009d,left: 0.7420893559787101d),
},
            new NpgsqlBoxbox0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.0694134811249284d,right: 0.28809087750108053d,bottom: 0.010292806890293327d,left: 0.23723974317658736d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.17054203633326803d,right: 0.26183432510285665d,bottom: 0.13335629743817945d,left: 0.10969413697776487d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9777150411681768d,right: 0.9805442957630387d,bottom: 0.5977107699358971d,left: 0.08442095526234672d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.938756763741115d,right: 0.6368541027216978d,bottom: 0.3377628533984801d,left: 0.4361902800110363d),
},
            new NpgsqlBoxbox0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7959621258388819d,right: 0.1722157308809923d,bottom: 0.5228658390627174d,left: 0.10861369052327519d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3283581638299483d,right: 0.24228455461586307d,bottom: 0.07067729419834567d,left: 0.16992478219964124d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.329655248084308d,right: 0.9379814583983409d,bottom: 0.28260675335840457d,left: 0.7287652940690243d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9246133372590255d,right: 0.850001247728229d,bottom: 0.1370935125555217d,left: 0.5504549718600287d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5124139512537588d,right: 0.4795254340767364d,bottom: 0.029503250969656336d,left: 0.38040482873593706d),
},
            new NpgsqlBoxbox0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4176195194954926d,right: 0.8126020306383198d,bottom: 0.20160862141951397d,left: 0.05708402910137156d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.05622854418656065d,right: 0.7537209864609183d,bottom: 0.04134456408987186d,left: 0.5604415664385692d),
},
            new NpgsqlBoxbox0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7475622039458804d,right: 0.5617858750106592d,bottom: 0.6194480705559859d,left: 0.47582876692754494d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9123441600314731d,right: 0.6770833191937975d,bottom: 0.5865738957147881d,left: 0.06734376412583953d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.75979371728698d,right: 0.15754935246333224d,bottom: 0.03322693349721295d,left: 0.15390718410235382d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8235195486369439d,right: 0.17415305038015505d,bottom: 0.2562370051270928d,left: 0.10795013552237143d),
},
            new NpgsqlBoxbox0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.572086628596446d,right: 0.7628649631738694d,bottom: 0.5269073399593642d,left: 0.1422117800572168d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3843911440211589d,right: 0.6670604079135527d,bottom: 0.07059243112457958d,left: 0.09219131538858083d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8735359028412241d,right: 0.8496597842816707d,bottom: 0.5663426544937867d,left: 0.34665189579916644d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4086041097845434d,right: 0.816534557920449d,bottom: 0.229705218849114d,left: 0.5230985739540108d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9966527204411856d,right: 0.3492888707567988d,bottom: 0.6427982877052905d,left: 0.1767392383966424d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4320961920002453d,right: 0.5421142764753513d,bottom: 0.34480649330756286d,left: 0.2813454360469868d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8993725895960307d,right: 0.9146859740804211d,bottom: 0.5885829384023153d,left: 0.43850565587133306d),
},
            new NpgsqlBoxbox0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9990107519198886d,right: 0.6019845642822235d,bottom: 0.4767320481441675d,left: 0.5552668136672281d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.651557753546303d,right: 0.9078959069817111d,bottom: 0.2391408480427053d,left: 0.01626027393496987d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8560894697530094d,right: 0.8906700190703345d,bottom: 0.7851170832662738d,left: 0.7701968845141393d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6499219061527116d,right: 0.9346307512635512d,bottom: 0.4221857373708128d,left: 0.03584854704134588d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8797710664495082d,right: 0.956153690778523d,bottom: 0.18662046969343826d,left: 0.7054510690366875d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9753139878247443d,right: 0.8475019219385095d,bottom: 0.9369299640810842d,left: 0.6926280764672261d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9021797494243272d,right: 0.22813217339407355d,bottom: 0.4394844624824479d,left: 0.029425178572385136d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.41594712002349843d,right: 0.9915240001226706d,bottom: 0.23971607384831295d,left: 0.17563075399685912d),
},
            new NpgsqlBoxbox0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5169572469383206d,right: 0.7679568632779836d,bottom: 0.33289295389335793d,left: 0.08046446338289248d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8883887300322133d,right: 0.7050269025094998d,bottom: 0.2503409022126748d,left: 0.6633009458851578d),
},
            new NpgsqlBoxbox0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8991253056511072d,right: 0.7579961849955127d,bottom: 0.07582253228994751d,left: 0.27950064632341853d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.22074835426463024d,right: 0.9115268815596244d,bottom: 0.017259433641684807d,left: 0.5276801876407208d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6065144350492565d,right: 0.3119632509505087d,bottom: 0.1117883043185589d,left: 0.17179467961660588d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5340790184956635d,right: 0.7136881262728435d,bottom: 0.19023365572442608d,left: 0.0013137522533018808d),
},
            new NpgsqlBoxbox0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5484660600456837d,right: 0.9208101158580073d,bottom: 0.4006723908159697d,left: 0.2559853447616993d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5981885315739803d,right: 0.5431326455390524d,bottom: 0.5608410273004056d,left: 0.43301380298107206d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9514752725170157d,right: 0.3377978307876971d,bottom: 0.4117488409526745d,left: 0.06755864815107415d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.49394469808244656d,right: 0.6262317612232347d,bottom: 0.32577786113631513d,left: 0.05406635927208059d),
},
            new NpgsqlBoxbox0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6942661365961645d,right: 0.9798359303399825d,bottom: 0.19813996038718973d,left: 0.029339644940479137d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5191842078254467d,right: 0.6753911018288195d,bottom: 0.504329166667991d,left: 0.16785922420144528d),
},
            new NpgsqlBoxbox0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8462214548247846d,right: 0.7666302051352628d,bottom: 0.7219937009894368d,left: 0.17467580447658282d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.32580035884978664d,right: 0.7995744704108481d,bottom: 0.1494032330303503d,left: 0.44453646901609123d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7217379800785415d,right: 0.35592982708293697d,bottom: 0.1071237933268413d,left: 0.34845124892363943d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7996039177401282d,right: 0.9807880269388566d,bottom: 0.09326670314112973d,left: 0.8587949768356351d),
},
            new NpgsqlBoxbox0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.918010502734412d,right: 0.9806027920484703d,bottom: 0.1987812695195672d,left: 0.4749489012205095d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5144064513474184d,right: 0.7249592598837324d,bottom: 0.4489035903164489d,left: 0.578935336638997d),
},
            new NpgsqlBoxbox0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6997982569406392d,right: 0.5001009604555674d,bottom: 0.10000937788721587d,left: 0.34411526651649127d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8934208860032274d,right: 0.372911857930304d,bottom: 0.48889416782147677d,left: 0.06235443808579688d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 153,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9101685451338851d,right: 0.970698526895487d,bottom: 0.08938990768900268d,left: 0.6155209194084931d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8725990428948772d,right: 0.7100535668052642d,bottom: 0.47339679669301205d,left: 0.580622295034593d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9674538221639829d,right: 0.30381147365209427d,bottom: 0.42962295013239515d,left: 0.1038051088062949d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.592775873025672d,right: 0.8963462654723179d,bottom: 0.4888254420146627d,left: 0.40664784341086035d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9565105994021001d,right: 0.6329295003263267d,bottom: 0.20973932036544896d,left: 0.5040309427739029d),
},
            new NpgsqlBoxbox0M
{
    Id = 164,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8890084213126171d,right: 0.42149808433985014d,bottom: 0.2923510742926386d,left: 0.14058380603720555d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9044503541653651d,right: 0.8484045008544479d,bottom: 0.7224719052369838d,left: 0.7018015635616632d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9413110171501675d,right: 0.7995328512670762d,bottom: 0.01453796904547966d,left: 0.34099035094844043d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.6267974939671639d,right: 0.7735466078873533d,bottom: 0.3811626646696532d,left: 0.24988100490191256d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7917918186569265d,right: 0.9384175569323739d,bottom: 0.753783008855189d,left: 0.7038480376677887d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9360185563875048d,right: 0.8679123573479144d,bottom: 0.32751670626506846d,left: 0.22309472327611812d)));
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.23468415471370008d,right: 0.5560509882437831d,bottom: 0.10150136673300514d,left: 0.2690200301625044d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8609572846104595d,right: 0.8829417394927179d,bottom: 0.6047286444212009d,left: 0.7420893559787101d)));
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.938756763741115d,right: 0.6368541027216978d,bottom: 0.3377628533984801d,left: 0.4361902800110363d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxbox0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlBox), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlboxbox0mi_id", 
                methodParametrName: "npgsqlboxbox0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 125, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 98, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 142, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 81, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 134, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 55, query1, 125, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 55, query1, 11, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 6, query1, 11, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 105, 49))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 96, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[8], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[9], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[10], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[19],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[20],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[21],_testData[29], false);NpgsqlBoxbox0M.AssertModel(models[22],_testData[30], false);NpgsqlBoxbox0M.AssertModel(models[23],_testData[31], false);NpgsqlBoxbox0M.AssertModel(models[24],_testData[32], false);NpgsqlBoxbox0M.AssertModel(models[25],_testData[33], false);NpgsqlBoxbox0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 113);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[29], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[30], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[31], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[32], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[33], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7411835513018386d,right: 0.639022058050705d,bottom: 0.2702188952333603d,left: 0.06431088529724327d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5290225521823438d,right: 0.36828344117771983d,bottom: 0.3144702874295776d,left: 0.05965364548833696d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7129339288111223d,right: 0.9356833776529885d,bottom: 0.21622975887987095d,left: 0.6891464523134334d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6420670144894381d,right: 0.48345647015857895d,bottom: 0.08957356682565965d,left: 0.3893691639215743d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2734152116307923d,right: 0.15961660013904821d,bottom: 0.1310258367104189d,left: 0.05988374662531959d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.546108078261603d,right: 0.8510883148011531d,bottom: 0.0232033094898616d,left: 0.011456650053629613d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.526543204293471d,right: 0.5339959652729229d,bottom: 0.11815585332371525d,left: 0.3187014933689992d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8032792564520329d,right: 0.6705567743731106d,bottom: 0.2694958045238439d,left: 0.6060886630360128d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9639778129238565d,right: 0.7128670430222316d,bottom: 0.38593377783097427d,left: 0.4489604186267606d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9931712852596413d,right: 0.8201269264954236d,bottom: 0.354867107886495d,left: 0.0624924715159354d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9044503541653651d,right: 0.8484045008544479d,bottom: 0.7224719052369838d,left: 0.7018015635616632d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.90069065540623d,right: 0.5153525378906585d,bottom: 0.6150718294015024d,left: 0.08832015207452626d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1868656591036495d,right: 0.47477119172804894d,bottom: 0.006175763586876659d,left: 0.0682091968213836d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9413110171501675d,right: 0.7995328512670762d,bottom: 0.01453796904547966d,left: 0.34099035094844043d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7579282644007976d,right: 0.27484097584555967d,bottom: 0.7063599118982491d,left: 0.11930349652193784d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6267974939671639d,right: 0.7735466078873533d,bottom: 0.3811626646696532d,left: 0.24988100490191256d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5136297505696512d,right: 0.5038164026536497d,bottom: 0.16302061721912608d,left: 0.0007083959516523963d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7473225751150805d,right: 0.834969520672516d,bottom: 0.12317738380536014d,left: 0.14359383465603004d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9268164348689313d,right: 0.8712726877170912d,bottom: 0.3568279416057174d,left: 0.5657731014652377d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7917918186569265d,right: 0.9384175569323739d,bottom: 0.753783008855189d,left: 0.7038480376677887d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9316146012708805d,right: 0.8166397961818032d,bottom: 0.1989077377614462d,left: 0.10497441860065759d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9360185563875048d,right: 0.8679123573479144d,bottom: 0.32751670626506846d,left: 0.22309472327611812d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7310600545925768d,right: 0.657311643503193d,bottom: 0.6862988203248952d,left: 0.2938747018985779d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9927313750151824d,right: 0.7576828895802918d,bottom: 0.9011290905876388d,left: 0.5254879419892563d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9076279265305819d,right: 0.8339028414931551d,bottom: 0.18454981488246247d,left: 0.05075548312207989d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.23468415471370008d,right: 0.5560509882437831d,bottom: 0.10150136673300514d,left: 0.2690200301625044d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5022404051892971d,right: 0.2773334213264942d,bottom: 0.20860602868086575d,left: 0.16658785403776455d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8609572846104595d,right: 0.8829417394927179d,bottom: 0.6047286444212009d,left: 0.7420893559787101d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.0694134811249284d,right: 0.28809087750108053d,bottom: 0.010292806890293327d,left: 0.23723974317658736d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17054203633326803d,right: 0.26183432510285665d,bottom: 0.13335629743817945d,left: 0.10969413697776487d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9777150411681768d,right: 0.9805442957630387d,bottom: 0.5977107699358971d,left: 0.08442095526234672d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.938756763741115d,right: 0.6368541027216978d,bottom: 0.3377628533984801d,left: 0.4361902800110363d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7959621258388819d,right: 0.1722157308809923d,bottom: 0.5228658390627174d,left: 0.10861369052327519d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3283581638299483d,right: 0.24228455461586307d,bottom: 0.07067729419834567d,left: 0.16992478219964124d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.329655248084308d,right: 0.9379814583983409d,bottom: 0.28260675335840457d,left: 0.7287652940690243d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9246133372590255d,right: 0.850001247728229d,bottom: 0.1370935125555217d,left: 0.5504549718600287d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5124139512537588d,right: 0.4795254340767364d,bottom: 0.029503250969656336d,left: 0.38040482873593706d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4176195194954926d,right: 0.8126020306383198d,bottom: 0.20160862141951397d,left: 0.05708402910137156d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.05622854418656065d,right: 0.7537209864609183d,bottom: 0.04134456408987186d,left: 0.5604415664385692d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7475622039458804d,right: 0.5617858750106592d,bottom: 0.6194480705559859d,left: 0.47582876692754494d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9123441600314731d,right: 0.6770833191937975d,bottom: 0.5865738957147881d,left: 0.06734376412583953d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.75979371728698d,right: 0.15754935246333224d,bottom: 0.03322693349721295d,left: 0.15390718410235382d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8235195486369439d,right: 0.17415305038015505d,bottom: 0.2562370051270928d,left: 0.10795013552237143d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.572086628596446d,right: 0.7628649631738694d,bottom: 0.5269073399593642d,left: 0.1422117800572168d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3843911440211589d,right: 0.6670604079135527d,bottom: 0.07059243112457958d,left: 0.09219131538858083d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8735359028412241d,right: 0.8496597842816707d,bottom: 0.5663426544937867d,left: 0.34665189579916644d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4086041097845434d,right: 0.816534557920449d,bottom: 0.229705218849114d,left: 0.5230985739540108d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9966527204411856d,right: 0.3492888707567988d,bottom: 0.6427982877052905d,left: 0.1767392383966424d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4320961920002453d,right: 0.5421142764753513d,bottom: 0.34480649330756286d,left: 0.2813454360469868d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8993725895960307d,right: 0.9146859740804211d,bottom: 0.5885829384023153d,left: 0.43850565587133306d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9990107519198886d,right: 0.6019845642822235d,bottom: 0.4767320481441675d,left: 0.5552668136672281d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.651557753546303d,right: 0.9078959069817111d,bottom: 0.2391408480427053d,left: 0.01626027393496987d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8560894697530094d,right: 0.8906700190703345d,bottom: 0.7851170832662738d,left: 0.7701968845141393d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6499219061527116d,right: 0.9346307512635512d,bottom: 0.4221857373708128d,left: 0.03584854704134588d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8797710664495082d,right: 0.956153690778523d,bottom: 0.18662046969343826d,left: 0.7054510690366875d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9753139878247443d,right: 0.8475019219385095d,bottom: 0.9369299640810842d,left: 0.6926280764672261d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9021797494243272d,right: 0.22813217339407355d,bottom: 0.4394844624824479d,left: 0.029425178572385136d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41594712002349843d,right: 0.9915240001226706d,bottom: 0.23971607384831295d,left: 0.17563075399685912d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5169572469383206d,right: 0.7679568632779836d,bottom: 0.33289295389335793d,left: 0.08046446338289248d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8883887300322133d,right: 0.7050269025094998d,bottom: 0.2503409022126748d,left: 0.6633009458851578d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8991253056511072d,right: 0.7579961849955127d,bottom: 0.07582253228994751d,left: 0.27950064632341853d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.22074835426463024d,right: 0.9115268815596244d,bottom: 0.017259433641684807d,left: 0.5276801876407208d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6065144350492565d,right: 0.3119632509505087d,bottom: 0.1117883043185589d,left: 0.17179467961660588d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5340790184956635d,right: 0.7136881262728435d,bottom: 0.19023365572442608d,left: 0.0013137522533018808d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5484660600456837d,right: 0.9208101158580073d,bottom: 0.4006723908159697d,left: 0.2559853447616993d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5981885315739803d,right: 0.5431326455390524d,bottom: 0.5608410273004056d,left: 0.43301380298107206d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9514752725170157d,right: 0.3377978307876971d,bottom: 0.4117488409526745d,left: 0.06755864815107415d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49394469808244656d,right: 0.6262317612232347d,bottom: 0.32577786113631513d,left: 0.05406635927208059d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6942661365961645d,right: 0.9798359303399825d,bottom: 0.19813996038718973d,left: 0.029339644940479137d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5191842078254467d,right: 0.6753911018288195d,bottom: 0.504329166667991d,left: 0.16785922420144528d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8462214548247846d,right: 0.7666302051352628d,bottom: 0.7219937009894368d,left: 0.17467580447658282d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.32580035884978664d,right: 0.7995744704108481d,bottom: 0.1494032330303503d,left: 0.44453646901609123d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7217379800785415d,right: 0.35592982708293697d,bottom: 0.1071237933268413d,left: 0.34845124892363943d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7996039177401282d,right: 0.9807880269388566d,bottom: 0.09326670314112973d,left: 0.8587949768356351d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.918010502734412d,right: 0.9806027920484703d,bottom: 0.1987812695195672d,left: 0.4749489012205095d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5144064513474184d,right: 0.7249592598837324d,bottom: 0.4489035903164489d,left: 0.578935336638997d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6997982569406392d,right: 0.5001009604555674d,bottom: 0.10000937788721587d,left: 0.34411526651649127d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8934208860032274d,right: 0.372911857930304d,bottom: 0.48889416782147677d,left: 0.06235443808579688d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9101685451338851d,right: 0.970698526895487d,bottom: 0.08938990768900268d,left: 0.6155209194084931d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8725990428948772d,right: 0.7100535668052642d,bottom: 0.47339679669301205d,left: 0.580622295034593d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9674538221639829d,right: 0.30381147365209427d,bottom: 0.42962295013239515d,left: 0.1038051088062949d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.592775873025672d,right: 0.8963462654723179d,bottom: 0.4888254420146627d,left: 0.40664784341086035d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9565105994021001d,right: 0.6329295003263267d,bottom: 0.20973932036544896d,left: 0.5040309427739029d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8890084213126171d,right: 0.42149808433985014d,bottom: 0.2923510742926386d,left: 0.14058380603720555d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7411835513018386d,right: 0.639022058050705d,bottom: 0.2702188952333603d,left: 0.06431088529724327d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5290225521823438d,right: 0.36828344117771983d,bottom: 0.3144702874295776d,left: 0.05965364548833696d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7129339288111223d,right: 0.9356833776529885d,bottom: 0.21622975887987095d,left: 0.6891464523134334d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6420670144894381d,right: 0.48345647015857895d,bottom: 0.08957356682565965d,left: 0.3893691639215743d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((11)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2734152116307923d,right: 0.15961660013904821d,bottom: 0.1310258367104189d,left: 0.05988374662531959d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.546108078261603d,right: 0.8510883148011531d,bottom: 0.0232033094898616d,left: 0.011456650053629613d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.526543204293471d,right: 0.5339959652729229d,bottom: 0.11815585332371525d,left: 0.3187014933689992d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8032792564520329d,right: 0.6705567743731106d,bottom: 0.2694958045238439d,left: 0.6060886630360128d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9639778129238565d,right: 0.7128670430222316d,bottom: 0.38593377783097427d,left: 0.4489604186267606d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((14)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9931712852596413d,right: 0.8201269264954236d,bottom: 0.354867107886495d,left: 0.0624924715159354d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9044503541653651d,right: 0.8484045008544479d,bottom: 0.7224719052369838d,left: 0.7018015635616632d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((23)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.90069065540623d,right: 0.5153525378906585d,bottom: 0.6150718294015024d,left: 0.08832015207452626d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1868656591036495d,right: 0.47477119172804894d,bottom: 0.006175763586876659d,left: 0.0682091968213836d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9413110171501675d,right: 0.7995328512670762d,bottom: 0.01453796904547966d,left: 0.34099035094844043d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7579282644007976d,right: 0.27484097584555967d,bottom: 0.7063599118982491d,left: 0.11930349652193784d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6267974939671639d,right: 0.7735466078873533d,bottom: 0.3811626646696532d,left: 0.24988100490191256d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5136297505696512d,right: 0.5038164026536497d,bottom: 0.16302061721912608d,left: 0.0007083959516523963d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7473225751150805d,right: 0.834969520672516d,bottom: 0.12317738380536014d,left: 0.14359383465603004d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9268164348689313d,right: 0.8712726877170912d,bottom: 0.3568279416057174d,left: 0.5657731014652377d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7917918186569265d,right: 0.9384175569323739d,bottom: 0.753783008855189d,left: 0.7038480376677887d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9316146012708805d,right: 0.8166397961818032d,bottom: 0.1989077377614462d,left: 0.10497441860065759d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9360185563875048d,right: 0.8679123573479144d,bottom: 0.32751670626506846d,left: 0.22309472327611812d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7310600545925768d,right: 0.657311643503193d,bottom: 0.6862988203248952d,left: 0.2938747018985779d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9927313750151824d,right: 0.7576828895802918d,bottom: 0.9011290905876388d,left: 0.5254879419892563d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9076279265305819d,right: 0.8339028414931551d,bottom: 0.18454981488246247d,left: 0.05075548312207989d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.23468415471370008d,right: 0.5560509882437831d,bottom: 0.10150136673300514d,left: 0.2690200301625044d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5022404051892971d,right: 0.2773334213264942d,bottom: 0.20860602868086575d,left: 0.16658785403776455d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8609572846104595d,right: 0.8829417394927179d,bottom: 0.6047286444212009d,left: 0.7420893559787101d))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.0694134811249284d,right: 0.28809087750108053d,bottom: 0.010292806890293327d,left: 0.23723974317658736d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17054203633326803d,right: 0.26183432510285665d,bottom: 0.13335629743817945d,left: 0.10969413697776487d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9777150411681768d,right: 0.9805442957630387d,bottom: 0.5977107699358971d,left: 0.08442095526234672d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.938756763741115d,right: 0.6368541027216978d,bottom: 0.3377628533984801d,left: 0.4361902800110363d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7959621258388819d,right: 0.1722157308809923d,bottom: 0.5228658390627174d,left: 0.10861369052327519d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3283581638299483d,right: 0.24228455461586307d,bottom: 0.07067729419834567d,left: 0.16992478219964124d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.329655248084308d,right: 0.9379814583983409d,bottom: 0.28260675335840457d,left: 0.7287652940690243d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9246133372590255d,right: 0.850001247728229d,bottom: 0.1370935125555217d,left: 0.5504549718600287d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5124139512537588d,right: 0.4795254340767364d,bottom: 0.029503250969656336d,left: 0.38040482873593706d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4176195194954926d,right: 0.8126020306383198d,bottom: 0.20160862141951397d,left: 0.05708402910137156d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.05622854418656065d,right: 0.7537209864609183d,bottom: 0.04134456408987186d,left: 0.5604415664385692d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7475622039458804d,right: 0.5617858750106592d,bottom: 0.6194480705559859d,left: 0.47582876692754494d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9123441600314731d,right: 0.6770833191937975d,bottom: 0.5865738957147881d,left: 0.06734376412583953d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.75979371728698d,right: 0.15754935246333224d,bottom: 0.03322693349721295d,left: 0.15390718410235382d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8235195486369439d,right: 0.17415305038015505d,bottom: 0.2562370051270928d,left: 0.10795013552237143d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.572086628596446d,right: 0.7628649631738694d,bottom: 0.5269073399593642d,left: 0.1422117800572168d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3843911440211589d,right: 0.6670604079135527d,bottom: 0.07059243112457958d,left: 0.09219131538858083d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8735359028412241d,right: 0.8496597842816707d,bottom: 0.5663426544937867d,left: 0.34665189579916644d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4086041097845434d,right: 0.816534557920449d,bottom: 0.229705218849114d,left: 0.5230985739540108d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9966527204411856d,right: 0.3492888707567988d,bottom: 0.6427982877052905d,left: 0.1767392383966424d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4320961920002453d,right: 0.5421142764753513d,bottom: 0.34480649330756286d,left: 0.2813454360469868d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8993725895960307d,right: 0.9146859740804211d,bottom: 0.5885829384023153d,left: 0.43850565587133306d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9990107519198886d,right: 0.6019845642822235d,bottom: 0.4767320481441675d,left: 0.5552668136672281d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.651557753546303d,right: 0.9078959069817111d,bottom: 0.2391408480427053d,left: 0.01626027393496987d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8560894697530094d,right: 0.8906700190703345d,bottom: 0.7851170832662738d,left: 0.7701968845141393d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6499219061527116d,right: 0.9346307512635512d,bottom: 0.4221857373708128d,left: 0.03584854704134588d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8797710664495082d,right: 0.956153690778523d,bottom: 0.18662046969343826d,left: 0.7054510690366875d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((56)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9753139878247443d,right: 0.8475019219385095d,bottom: 0.9369299640810842d,left: 0.6926280764672261d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9021797494243272d,right: 0.22813217339407355d,bottom: 0.4394844624824479d,left: 0.029425178572385136d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41594712002349843d,right: 0.9915240001226706d,bottom: 0.23971607384831295d,left: 0.17563075399685912d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5169572469383206d,right: 0.7679568632779836d,bottom: 0.33289295389335793d,left: 0.08046446338289248d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8883887300322133d,right: 0.7050269025094998d,bottom: 0.2503409022126748d,left: 0.6633009458851578d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8991253056511072d,right: 0.7579961849955127d,bottom: 0.07582253228994751d,left: 0.27950064632341853d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.22074835426463024d,right: 0.9115268815596244d,bottom: 0.017259433641684807d,left: 0.5276801876407208d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6065144350492565d,right: 0.3119632509505087d,bottom: 0.1117883043185589d,left: 0.17179467961660588d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5340790184956635d,right: 0.7136881262728435d,bottom: 0.19023365572442608d,left: 0.0013137522533018808d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5484660600456837d,right: 0.9208101158580073d,bottom: 0.4006723908159697d,left: 0.2559853447616993d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5981885315739803d,right: 0.5431326455390524d,bottom: 0.5608410273004056d,left: 0.43301380298107206d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9514752725170157d,right: 0.3377978307876971d,bottom: 0.4117488409526745d,left: 0.06755864815107415d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49394469808244656d,right: 0.6262317612232347d,bottom: 0.32577786113631513d,left: 0.05406635927208059d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6942661365961645d,right: 0.9798359303399825d,bottom: 0.19813996038718973d,left: 0.029339644940479137d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5191842078254467d,right: 0.6753911018288195d,bottom: 0.504329166667991d,left: 0.16785922420144528d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8462214548247846d,right: 0.7666302051352628d,bottom: 0.7219937009894368d,left: 0.17467580447658282d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.32580035884978664d,right: 0.7995744704108481d,bottom: 0.1494032330303503d,left: 0.44453646901609123d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7217379800785415d,right: 0.35592982708293697d,bottom: 0.1071237933268413d,left: 0.34845124892363943d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7996039177401282d,right: 0.9807880269388566d,bottom: 0.09326670314112973d,left: 0.8587949768356351d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.918010502734412d,right: 0.9806027920484703d,bottom: 0.1987812695195672d,left: 0.4749489012205095d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5144064513474184d,right: 0.7249592598837324d,bottom: 0.4489035903164489d,left: 0.578935336638997d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6997982569406392d,right: 0.5001009604555674d,bottom: 0.10000937788721587d,left: 0.34411526651649127d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((71)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8934208860032274d,right: 0.372911857930304d,bottom: 0.48889416782147677d,left: 0.06235443808579688d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9101685451338851d,right: 0.970698526895487d,bottom: 0.08938990768900268d,left: 0.6155209194084931d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8725990428948772d,right: 0.7100535668052642d,bottom: 0.47339679669301205d,left: 0.580622295034593d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9674538221639829d,right: 0.30381147365209427d,bottom: 0.42962295013239515d,left: 0.1038051088062949d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.592775873025672d,right: 0.8963462654723179d,bottom: 0.4888254420146627d,left: 0.40664784341086035d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9565105994021001d,right: 0.6329295003263267d,bottom: 0.20973932036544896d,left: 0.5040309427739029d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8890084213126171d,right: 0.42149808433985014d,bottom: 0.2923510742926386d,left: 0.14058380603720555d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxbox0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxbox0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
FROM public.binary_npgsqlboxbox0m m
LEFT JOIN public.binary_npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI), typeof(NpgsqlBoxbox0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                await ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

