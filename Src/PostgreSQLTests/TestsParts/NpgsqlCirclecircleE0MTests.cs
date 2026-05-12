

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
    internal partial interface INpgsqlCircleSingleTypecircle
    {
    }
    
    internal partial class NpgsqlCircleSingleTypecircle : INpgsqlCircleSingleTypecircle
    {


#region TestData

        private readonly NpgsqlCirclecircleE0M[] _testData = new NpgsqlCirclecircleE0M[]
        {
            new NpgsqlCirclecircleE0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9649428284783615d, y: 0.9063899830368207d), radius: 0.7121049795442763d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7050744857994201d, y: 0.12825810982695884d), radius: 0.7364783379821817d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8583151032418919d, y: 0.4663367022122631d), radius: 0.6806882478465899d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.030870871408626432d, y: 0.9789591849636867d), radius: 0.7430589031834068d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49666517006140576d, y: 0.7067903870618689d), radius: 0.18348621315493896d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8043229708496434d, y: 0.2843326430628492d), radius: 0.9492531267164412d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8088801085187105d, y: 0.6172097957230244d), radius: 0.23613038851897783d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5195980820112066d, y: 0.9353714778878249d), radius: 0.6197066879153215d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6187610836701185d, y: 0.611337311533061d), radius: 0.9815449924846372d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10506294206128253d, y: 0.17357073422523772d), radius: 0.33038085758449554d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7853427240577576d, y: 0.8385250793379723d), radius: 0.5090136903010112d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3152289063040853d, y: 0.5006522826804739d), radius: 0.5379627462679618d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07256731378536574d, y: 0.78373693944318d), radius: 0.7019143208627043d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7927257662700556d, y: 0.7753071039333387d), radius: 0.2837204492938171d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.939290396441523d, y: 0.6808341592991225d), radius: 0.5550589936667114d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18564709978783833d, y: 0.48460094351889593d), radius: 0.5077203657831034d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7864634946092791d, y: 0.4579552608979439d), radius: 0.3481108681282651d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20689282658815666d, y: 0.14313202728730356d), radius: 0.14381900538885062d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6384788230348959d, y: 0.7920928168144209d), radius: 0.1963060317614168d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9415440855523229d, y: 0.9310426461952899d), radius: 0.8398935405871297d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7053652904506392d, y: 0.6129231290795656d), radius: 0.2059450037709203d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8329550730940597d, y: 0.5418797429282267d), radius: 0.7469280950095032d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5505458996170682d, y: 0.7277855872221414d), radius: 0.014951126460180375d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3749131939179733d, y: 0.34147402682523686d), radius: 0.6422791832085359d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6999987983086485d, y: 0.023615618119635418d), radius: 0.8725273152383574d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.291138137571917d, y: 0.947052181939681d), radius: 0.649569866388943d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5765984216502085d, y: 0.7702162076221476d), radius: 0.7056634210476533d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43079323839617634d, y: 0.7871524644640198d), radius: 0.42643165886537704d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09822012218185683d, y: 0.6115880157232809d), radius: 0.8487427432963247d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3571809110766515d, y: 0.3634217345199471d), radius: 0.36575703693587036d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5462480892193625d, y: 0.04678520432442401d), radius: 0.7443079381323665d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9427731803001144d, y: 0.8442709359529424d), radius: 0.8982697844909817d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8257065522607427d, y: 0.8396363816984227d), radius: 0.9699366731470238d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3597706135221318d, y: 0.978822310375294d), radius: 0.6273222257200448d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7540824914015016d, y: 0.07604117235039665d), radius: 0.48473056852807794d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9675392694301561d, y: 0.045177305885132024d), radius: 0.26686504392285537d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5939200218947963d, y: 0.36160774277126717d), radius: 0.11707551382336123d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6590495293632117d, y: 0.3949864816125386d), radius: 0.014467981532002794d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8400097940628197d, y: 0.014596283970651491d), radius: 0.9571890677852306d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.564717277783246d, y: 0.7466442506504297d), radius: 0.8941889317596303d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6965282939241748d, y: 0.26262122208251903d), radius: 0.1428010528374387d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023316665414528037d, y: 0.4773691100442865d), radius: 0.32712388109644497d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.95971597757389d, y: 0.9592274875227823d), radius: 0.5004603098920399d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6133274338666205d, y: 0.3634141106749781d), radius: 0.6606475475122611d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2671479063734279d, y: 0.4119444206217918d), radius: 0.7133812119666957d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36961440523897415d, y: 0.2234360107631621d), radius: 0.6651435381818377d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14145946107046492d, y: 0.24634124228186705d), radius: 0.19830177843569896d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5119721300160275d, y: 0.12405237535103841d), radius: 0.5894756148078191d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26777048835378137d, y: 0.09612865152797634d), radius: 0.5606423422520652d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8889828904026055d, y: 0.19451155898940575d), radius: 0.513926540914546d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06416339605687504d, y: 0.6310748742076333d), radius: 0.11880377868869296d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6493006019319765d, y: 0.4727549345052251d), radius: 0.8676913974599794d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34285446668291464d, y: 0.7519525714277357d), radius: 0.8525704029790399d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17985274154855646d, y: 0.07033686440454745d), radius: 0.9000636544210182d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19981849686280284d, y: 0.08044040222707971d), radius: 0.3978332198008545d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11972409206831469d, y: 0.2464151179493128d), radius: 0.7890245194280218d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20981979336982082d, y: 0.51323641115721d), radius: 0.6301529344931275d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42523496893648716d, y: 0.06770824594061997d), radius: 0.4575953260105927d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6209448982103806d, y: 0.2001638858111645d), radius: 0.21378259337433714d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2975310692428641d, y: 0.5056721837723397d), radius: 0.020923683862978937d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7554095317014259d, y: 0.5052631109121781d), radius: 0.8828904690712622d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43417623354841917d, y: 0.3080722739967243d), radius: 0.7732822787937408d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9753851937818329d, y: 0.6028015771187308d), radius: 0.9322400646230774d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 172,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19094942631787193d, y: 0.26811068277916195d), radius: 0.9222606805247423d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9161328509635578d, y: 0.2763877367574974d), radius: 0.03088086734178286d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3121102735765413d, y: 0.8536533639884721d), radius: 0.5720371053007823d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6726028400762589d, y: 0.8977863556164104d), radius: 0.4658154807232745d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6734008942322234d, y: 0.3778836083997541d), radius: 0.21721715493631744d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2668551892358173d, y: 0.1619214366562718d), radius: 0.5947734483249427d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 185,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16757165353269632d, y: 0.7534148572985775d), radius: 0.666067936395389d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 187,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4947540360492346d, y: 0.5271072299258235d), radius: 0.22391546248803684d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8596663300907664d, y: 0.17977790887583012d), radius: 0.23118099415766957d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5593633038476221d, y: 0.2251414908299234d), radius: 0.10443854886955806d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 194,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16745093031494285d, y: 0.6344489709738116d), radius: 0.6908531648445669d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0mi(
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0mi(
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclee0mi_id
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclee0mi_id", 
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
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclee0mi_id
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
    npgsqlcirclecirclee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07256731378536574d, y: 0.78373693944318d), radius: 0.7019143208627043d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclee0mi_id
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
    npgsqlcirclecirclee0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclee0mi_id", 
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7864634946092791d, y: 0.4579552608979439d), radius: 0.3481108681282651d)));
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5505458996170682d, y: 0.7277855872221414d), radius: 0.014951126460180375d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleE0M> models = null;

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleE0M> models = null;

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclee0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclee0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlcirclecirclee0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlCircle), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlcirclecirclee0mi_id", 
                methodParametrName: "npgsqlcirclecirclee0mi_id", 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M), typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M), typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M), typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 48;
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 86;
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 179;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 172;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M), typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 114, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 135, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleE0M>();
                var models2 = new List<FlatNpgsqlCirclecircleE0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 51, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 79, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 40, query1, 9, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 123, query1, 79, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 101, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
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
FROM public.npgsqlcirclecirclee0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleE0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleE0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 9, query1, 166, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 155, 79))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 17, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[24],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[25],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 152);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[27], false);
                NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[28], false);
                NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[29], false);
                NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[30], false);
                NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[31], false);
                NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[32], false);
                NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[33], false);
                NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 86);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[15], false);
                NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[16], false);
                NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[17], false);
                NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[18], false);
                NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[19], false);
                NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[20], false);
                NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[21], false);
                NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[22], false);
                NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[23], false);
                NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[24], false);
                NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[25], false);
                NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[26], false);
                NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[27], false);
                NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[28], false);
                NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[29], false);
                NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[30], false);
                NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[31], false);
                NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[32], false);
                NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[33], false);
                NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlcirclecirclee0m m
LEFT JOIN public.npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9649428284783615d, y: 0.9063899830368207d), radius: 0.7121049795442763d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7050744857994201d, y: 0.12825810982695884d), radius: 0.7364783379821817d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8583151032418919d, y: 0.4663367022122631d), radius: 0.6806882478465899d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.030870871408626432d, y: 0.9789591849636867d), radius: 0.7430589031834068d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49666517006140576d, y: 0.7067903870618689d), radius: 0.18348621315493896d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8043229708496434d, y: 0.2843326430628492d), radius: 0.9492531267164412d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8088801085187105d, y: 0.6172097957230244d), radius: 0.23613038851897783d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5195980820112066d, y: 0.9353714778878249d), radius: 0.6197066879153215d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6187610836701185d, y: 0.611337311533061d), radius: 0.9815449924846372d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10506294206128253d, y: 0.17357073422523772d), radius: 0.33038085758449554d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7853427240577576d, y: 0.8385250793379723d), radius: 0.5090136903010112d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3152289063040853d, y: 0.5006522826804739d), radius: 0.5379627462679618d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07256731378536574d, y: 0.78373693944318d), radius: 0.7019143208627043d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7927257662700556d, y: 0.7753071039333387d), radius: 0.2837204492938171d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.939290396441523d, y: 0.6808341592991225d), radius: 0.5550589936667114d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18564709978783833d, y: 0.48460094351889593d), radius: 0.5077203657831034d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7864634946092791d, y: 0.4579552608979439d), radius: 0.3481108681282651d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20689282658815666d, y: 0.14313202728730356d), radius: 0.14381900538885062d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6384788230348959d, y: 0.7920928168144209d), radius: 0.1963060317614168d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9415440855523229d, y: 0.9310426461952899d), radius: 0.8398935405871297d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7053652904506392d, y: 0.6129231290795656d), radius: 0.2059450037709203d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8329550730940597d, y: 0.5418797429282267d), radius: 0.7469280950095032d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5505458996170682d, y: 0.7277855872221414d), radius: 0.014951126460180375d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3749131939179733d, y: 0.34147402682523686d), radius: 0.6422791832085359d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6999987983086485d, y: 0.023615618119635418d), radius: 0.8725273152383574d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.291138137571917d, y: 0.947052181939681d), radius: 0.649569866388943d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5765984216502085d, y: 0.7702162076221476d), radius: 0.7056634210476533d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43079323839617634d, y: 0.7871524644640198d), radius: 0.42643165886537704d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09822012218185683d, y: 0.6115880157232809d), radius: 0.8487427432963247d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3571809110766515d, y: 0.3634217345199471d), radius: 0.36575703693587036d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5462480892193625d, y: 0.04678520432442401d), radius: 0.7443079381323665d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9427731803001144d, y: 0.8442709359529424d), radius: 0.8982697844909817d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8257065522607427d, y: 0.8396363816984227d), radius: 0.9699366731470238d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3597706135221318d, y: 0.978822310375294d), radius: 0.6273222257200448d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7540824914015016d, y: 0.07604117235039665d), radius: 0.48473056852807794d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9675392694301561d, y: 0.045177305885132024d), radius: 0.26686504392285537d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5939200218947963d, y: 0.36160774277126717d), radius: 0.11707551382336123d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6590495293632117d, y: 0.3949864816125386d), radius: 0.014467981532002794d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8400097940628197d, y: 0.014596283970651491d), radius: 0.9571890677852306d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.564717277783246d, y: 0.7466442506504297d), radius: 0.8941889317596303d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6965282939241748d, y: 0.26262122208251903d), radius: 0.1428010528374387d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023316665414528037d, y: 0.4773691100442865d), radius: 0.32712388109644497d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.95971597757389d, y: 0.9592274875227823d), radius: 0.5004603098920399d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6133274338666205d, y: 0.3634141106749781d), radius: 0.6606475475122611d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2671479063734279d, y: 0.4119444206217918d), radius: 0.7133812119666957d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36961440523897415d, y: 0.2234360107631621d), radius: 0.6651435381818377d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14145946107046492d, y: 0.24634124228186705d), radius: 0.19830177843569896d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5119721300160275d, y: 0.12405237535103841d), radius: 0.5894756148078191d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26777048835378137d, y: 0.09612865152797634d), radius: 0.5606423422520652d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8889828904026055d, y: 0.19451155898940575d), radius: 0.513926540914546d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06416339605687504d, y: 0.6310748742076333d), radius: 0.11880377868869296d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6493006019319765d, y: 0.4727549345052251d), radius: 0.8676913974599794d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34285446668291464d, y: 0.7519525714277357d), radius: 0.8525704029790399d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17985274154855646d, y: 0.07033686440454745d), radius: 0.9000636544210182d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19981849686280284d, y: 0.08044040222707971d), radius: 0.3978332198008545d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11972409206831469d, y: 0.2464151179493128d), radius: 0.7890245194280218d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20981979336982082d, y: 0.51323641115721d), radius: 0.6301529344931275d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42523496893648716d, y: 0.06770824594061997d), radius: 0.4575953260105927d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6209448982103806d, y: 0.2001638858111645d), radius: 0.21378259337433714d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2975310692428641d, y: 0.5056721837723397d), radius: 0.020923683862978937d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7554095317014259d, y: 0.5052631109121781d), radius: 0.8828904690712622d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43417623354841917d, y: 0.3080722739967243d), radius: 0.7732822787937408d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9753851937818329d, y: 0.6028015771187308d), radius: 0.9322400646230774d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19094942631787193d, y: 0.26811068277916195d), radius: 0.9222606805247423d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9161328509635578d, y: 0.2763877367574974d), radius: 0.03088086734178286d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3121102735765413d, y: 0.8536533639884721d), radius: 0.5720371053007823d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6726028400762589d, y: 0.8977863556164104d), radius: 0.4658154807232745d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6734008942322234d, y: 0.3778836083997541d), radius: 0.21721715493631744d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2668551892358173d, y: 0.1619214366562718d), radius: 0.5947734483249427d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16757165353269632d, y: 0.7534148572985775d), radius: 0.666067936395389d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4947540360492346d, y: 0.5271072299258235d), radius: 0.22391546248803684d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8596663300907664d, y: 0.17977790887583012d), radius: 0.23118099415766957d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5593633038476221d, y: 0.2251414908299234d), radius: 0.10443854886955806d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16745093031494285d, y: 0.6344489709738116d), radius: 0.6908531648445669d))));//Value

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
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9649428284783615d, y: 0.9063899830368207d), radius: 0.7121049795442763d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7050744857994201d, y: 0.12825810982695884d), radius: 0.7364783379821817d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8583151032418919d, y: 0.4663367022122631d), radius: 0.6806882478465899d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.030870871408626432d, y: 0.9789591849636867d), radius: 0.7430589031834068d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49666517006140576d, y: 0.7067903870618689d), radius: 0.18348621315493896d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8043229708496434d, y: 0.2843326430628492d), radius: 0.9492531267164412d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8088801085187105d, y: 0.6172097957230244d), radius: 0.23613038851897783d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5195980820112066d, y: 0.9353714778878249d), radius: 0.6197066879153215d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6187610836701185d, y: 0.611337311533061d), radius: 0.9815449924846372d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10506294206128253d, y: 0.17357073422523772d), radius: 0.33038085758449554d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7853427240577576d, y: 0.8385250793379723d), radius: 0.5090136903010112d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3152289063040853d, y: 0.5006522826804739d), radius: 0.5379627462679618d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07256731378536574d, y: 0.78373693944318d), radius: 0.7019143208627043d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7927257662700556d, y: 0.7753071039333387d), radius: 0.2837204492938171d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.939290396441523d, y: 0.6808341592991225d), radius: 0.5550589936667114d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18564709978783833d, y: 0.48460094351889593d), radius: 0.5077203657831034d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7864634946092791d, y: 0.4579552608979439d), radius: 0.3481108681282651d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20689282658815666d, y: 0.14313202728730356d), radius: 0.14381900538885062d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6384788230348959d, y: 0.7920928168144209d), radius: 0.1963060317614168d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9415440855523229d, y: 0.9310426461952899d), radius: 0.8398935405871297d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7053652904506392d, y: 0.6129231290795656d), radius: 0.2059450037709203d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8329550730940597d, y: 0.5418797429282267d), radius: 0.7469280950095032d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5505458996170682d, y: 0.7277855872221414d), radius: 0.014951126460180375d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3749131939179733d, y: 0.34147402682523686d), radius: 0.6422791832085359d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6999987983086485d, y: 0.023615618119635418d), radius: 0.8725273152383574d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.291138137571917d, y: 0.947052181939681d), radius: 0.649569866388943d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5765984216502085d, y: 0.7702162076221476d), radius: 0.7056634210476533d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43079323839617634d, y: 0.7871524644640198d), radius: 0.42643165886537704d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09822012218185683d, y: 0.6115880157232809d), radius: 0.8487427432963247d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((89)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3571809110766515d, y: 0.3634217345199471d), radius: 0.36575703693587036d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5462480892193625d, y: 0.04678520432442401d), radius: 0.7443079381323665d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9427731803001144d, y: 0.8442709359529424d), radius: 0.8982697844909817d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8257065522607427d, y: 0.8396363816984227d), radius: 0.9699366731470238d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3597706135221318d, y: 0.978822310375294d), radius: 0.6273222257200448d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7540824914015016d, y: 0.07604117235039665d), radius: 0.48473056852807794d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9675392694301561d, y: 0.045177305885132024d), radius: 0.26686504392285537d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5939200218947963d, y: 0.36160774277126717d), radius: 0.11707551382336123d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6590495293632117d, y: 0.3949864816125386d), radius: 0.014467981532002794d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8400097940628197d, y: 0.014596283970651491d), radius: 0.9571890677852306d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.564717277783246d, y: 0.7466442506504297d), radius: 0.8941889317596303d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6965282939241748d, y: 0.26262122208251903d), radius: 0.1428010528374387d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023316665414528037d, y: 0.4773691100442865d), radius: 0.32712388109644497d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.95971597757389d, y: 0.9592274875227823d), radius: 0.5004603098920399d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6133274338666205d, y: 0.3634141106749781d), radius: 0.6606475475122611d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2671479063734279d, y: 0.4119444206217918d), radius: 0.7133812119666957d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36961440523897415d, y: 0.2234360107631621d), radius: 0.6651435381818377d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14145946107046492d, y: 0.24634124228186705d), radius: 0.19830177843569896d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5119721300160275d, y: 0.12405237535103841d), radius: 0.5894756148078191d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26777048835378137d, y: 0.09612865152797634d), radius: 0.5606423422520652d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8889828904026055d, y: 0.19451155898940575d), radius: 0.513926540914546d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06416339605687504d, y: 0.6310748742076333d), radius: 0.11880377868869296d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6493006019319765d, y: 0.4727549345052251d), radius: 0.8676913974599794d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34285446668291464d, y: 0.7519525714277357d), radius: 0.8525704029790399d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17985274154855646d, y: 0.07033686440454745d), radius: 0.9000636544210182d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19981849686280284d, y: 0.08044040222707971d), radius: 0.3978332198008545d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11972409206831469d, y: 0.2464151179493128d), radius: 0.7890245194280218d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20981979336982082d, y: 0.51323641115721d), radius: 0.6301529344931275d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42523496893648716d, y: 0.06770824594061997d), radius: 0.4575953260105927d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((66)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6209448982103806d, y: 0.2001638858111645d), radius: 0.21378259337433714d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2975310692428641d, y: 0.5056721837723397d), radius: 0.020923683862978937d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7554095317014259d, y: 0.5052631109121781d), radius: 0.8828904690712622d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43417623354841917d, y: 0.3080722739967243d), radius: 0.7732822787937408d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9753851937818329d, y: 0.6028015771187308d), radius: 0.9322400646230774d))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19094942631787193d, y: 0.26811068277916195d), radius: 0.9222606805247423d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9161328509635578d, y: 0.2763877367574974d), radius: 0.03088086734178286d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3121102735765413d, y: 0.8536533639884721d), radius: 0.5720371053007823d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6726028400762589d, y: 0.8977863556164104d), radius: 0.4658154807232745d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6734008942322234d, y: 0.3778836083997541d), radius: 0.21721715493631744d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2668551892358173d, y: 0.1619214366562718d), radius: 0.5947734483249427d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((185)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16757165353269632d, y: 0.7534148572985775d), radius: 0.666067936395389d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((187)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4947540360492346d, y: 0.5271072299258235d), radius: 0.22391546248803684d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8596663300907664d, y: 0.17977790887583012d), radius: 0.23118099415766957d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5593633038476221d, y: 0.2251414908299234d), radius: 0.10443854886955806d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((194)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16745093031494285d, y: 0.6344489709738116d), radius: 0.6908531648445669d))));//Value

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
FROM public.binary_npgsqlcirclecirclee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleSingleTypecircle)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleSingleTypecircle)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclee0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclee0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
FROM public.binary_npgsqlcirclecirclee0m m
LEFT JOIN public.binary_npgsqlcirclecirclee0mi mi ON mi.id = m.npgsqlcirclecirclee0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleSingleTypecircle)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleSingleTypecircle)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclee0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA), typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA), typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclee0mi
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
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MI), typeof(NpgsqlCirclecircleE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models1 = new List<NpgsqlCirclecircleE0MI>();
                var models2 = new List<NpgsqlCirclecircleE0MI>();
                await ((INpgsqlCircleSingleTypecircle)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleE0MI>();
                var models2 = new List<NpgsqlCirclecircleE0MI>();
                ((INpgsqlCircleSingleTypecircle)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclee0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA), typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleE0MIWA>();
                var models2 = new List<NpgsqlCirclecircleE0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclee0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

