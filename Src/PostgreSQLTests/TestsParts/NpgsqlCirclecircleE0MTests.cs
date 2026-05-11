

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
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.910953224363361d, y: 0.7590411358514177d), radius: 0.14522659240942382d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3604430565985526d, y: 0.8559127516658448d), radius: 0.6777272590337146d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7003750991953647d, y: 0.14589840938003107d), radius: 0.6644818971766566d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2988584458239585d, y: 0.38108122270476585d), radius: 0.23556402452011682d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.026054561337961246d, y: 0.47266425990136973d), radius: 0.8954907545392004d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8046241275950156d, y: 0.0252055115533375d), radius: 0.27134290363319313d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5029656250811605d, y: 0.5758095110522531d), radius: 0.646315104230721d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40205627435296765d, y: 0.4352310209368131d), radius: 0.6186706553884234d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8378914220627659d, y: 0.733226627976624d), radius: 0.8580365400369888d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.299694881997992d, y: 0.49656202315053255d), radius: 0.4294628669981211d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2728727001096811d, y: 0.4262435856235466d), radius: 0.22880098253849634d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2416134591816339d, y: 0.7015465350096548d), radius: 0.3784453954510786d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8715689950812319d, y: 0.9843544701230489d), radius: 0.8988457203311189d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6777958706994793d, y: 0.22208864189182043d), radius: 0.2980847506308971d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45509726566884445d, y: 0.9218570171201649d), radius: 0.31180461648117996d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8326469980041331d, y: 0.6149275114438811d), radius: 0.31443630983282844d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4202359855029223d, y: 0.7051444441824309d), radius: 0.06595598454128149d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7809551513340685d, y: 0.45270651644420146d), radius: 0.6471317176579169d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7867374589461672d, y: 0.7610349369342039d), radius: 0.9604100959582526d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5871592549579316d, y: 0.5410643535427718d), radius: 0.8957413480411831d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6406041242427389d, y: 0.00168825601687983d), radius: 0.8829509385263834d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5588929139805087d, y: 0.4532760576610849d), radius: 0.02625015055057367d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11379937125844308d, y: 0.2907591380795561d), radius: 0.2638689591166784d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.392279396422309d, y: 0.26785149196083935d), radius: 0.739878201510584d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6174099537806303d, y: 0.42986859045628234d), radius: 0.9934464086698713d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38667246219784657d, y: 0.8815698301994218d), radius: 0.9892294016011495d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3597180134150666d, y: 0.42838516467137944d), radius: 0.4201009652439214d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5916186085815444d, y: 0.2985859472111886d), radius: 0.14133622205578267d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7850440174316258d, y: 0.0481962699442644d), radius: 0.6023327951156265d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2868923412964681d, y: 0.7503134505887603d), radius: 0.6704904030598747d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5999012325139095d, y: 0.8784036417985821d), radius: 0.36826808277442813d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9200705927669913d, y: 0.30120245259319245d), radius: 0.18519730124837974d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 85,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05474353755787331d, y: 0.1885044157162098d), radius: 0.11062649749733833d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1889480405950501d, y: 0.2267526356212326d), radius: 0.6070719742279723d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.008663718037554724d, y: 0.9129736636225927d), radius: 0.06634397975156037d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9936551885845469d, y: 0.7930343939362244d), radius: 0.6383260453584522d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6995705286971552d, y: 0.7618572369326017d), radius: 0.5411651985374284d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 96,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8335715103818138d, y: 0.4633575534136969d), radius: 0.4450935518262462d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5532377934313283d, y: 0.3212553035641569d), radius: 0.6995564038518618d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5916957426927816d, y: 0.7942584088708524d), radius: 0.5514354496410029d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9985471016461706d, y: 0.6865271058428633d), radius: 0.49798957409684974d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17847124647393486d, y: 0.021203259045946d), radius: 0.13056709313964532d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8135276529170498d, y: 0.019125147115112595d), radius: 0.470573603686398d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4648956648186042d, y: 0.22218396881916513d), radius: 0.19662830314955915d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4940718833020844d, y: 0.43755231439113895d), radius: 0.38984699315757687d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09961824747794767d, y: 0.1308208019004079d), radius: 0.022901721131375563d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45149710663403075d, y: 0.44090960117796674d), radius: 0.2865855362826649d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14242638974262223d, y: 0.7658991127930367d), radius: 0.42822517345635336d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3318690956881519d, y: 0.6739145767928107d), radius: 0.9132025597463931d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13188071635681953d, y: 0.21629822091592799d), radius: 0.0542450889316729d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03946387462088563d, y: 0.15989653298997852d), radius: 0.42717980351046936d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9294714511846673d, y: 0.017948978932704418d), radius: 0.714079979047095d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3840126311043479d, y: 0.012802409775143353d), radius: 0.22811061691028311d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6260114380554963d, y: 0.7233296641752787d), radius: 0.6668522237525827d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9692818963930642d, y: 0.5690983958272673d), radius: 0.888064496090403d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38915402354816253d, y: 0.7678099847063075d), radius: 0.12957006315061248d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2444357607059695d, y: 0.5632269950148924d), radius: 0.31905170947489625d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9568704295773452d, y: 0.5303787908197078d), radius: 0.6309254791191002d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16015673228499216d, y: 0.3467626164303992d), radius: 0.7052143854230766d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.575201159123974d, y: 0.7231456139763978d), radius: 0.8986005330408174d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17868970010544616d, y: 0.6901196854138235d), radius: 0.15940581119736863d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1106395184044352d, y: 0.6810944943409999d), radius: 0.9844085808304929d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8683910672556114d, y: 0.1967407540524404d), radius: 0.9111880604524782d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 156,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8393414297815128d, y: 0.18218700955316514d), radius: 0.09969278314727426d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9724233615528123d, y: 0.9116329767830104d), radius: 0.8910691957426436d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.55417972083772d, y: 0.7136317112201653d), radius: 0.8013390199521584d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6734452235837675d, y: 0.014374065166527727d), radius: 0.0845006929385046d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761733665628858d, y: 0.7455887634639258d), radius: 0.09996445200379611d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 166,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.060922480786108624d, y: 0.1519227089280385d), radius: 0.4887501367255287d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11277027086137092d, y: 0.510283739759392d), radius: 0.040307567468396255d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 174,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12149060240457399d, y: 0.30104993913357103d), radius: 0.5692490543802889d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3283841144543217d, y: 0.8591302917588685d), radius: 0.03810078929861849d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 180,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8522908952971222d, y: 0.21670975177213425d), radius: 0.11934858715393115d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.006066197232450721d, y: 0.08060269670289577d), radius: 0.24122548269073607d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8530570313698563d, y: 0.44668152577420994d), radius: 0.3997821947737803d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5211910290538099d, y: 0.0039564713176794d), radius: 0.7220904504141255d),
},
            new NpgsqlCirclecircleE0M
{
    Id = 183,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4997631285368389d, y: 0.8074154634922572d), radius: 0.2622378108052038d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 189,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42737118529292584d, y: 0.5234157746125164d), radius: 0.13757853697481992d),
    ModelInner = new NpgsqlCirclecircleE0MI
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.324306784471017d, y: 0.7341212794580575d), radius: 0.13613001514667933d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1287936492295444d, y: 0.23254304023269212d), radius: 0.2717140007720913d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircleE0M
{
    Id = 195,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4615612904047788d, y: 0.6069172358796816d), radius: 0.06732954701043992d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7638462551832835d, y: 0.4038327464098789d), radius: 0.20514156654016957d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6777958706994793d, y: 0.22208864189182043d), radius: 0.2980847506308971d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4202359855029223d, y: 0.7051444441824309d), radius: 0.06595598454128149d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5916186085815444d, y: 0.2985859472111886d), radius: 0.14133622205578267d)));
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
                parametr1.Value = 10;
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[33],_testData[34], false);
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
                parametr1.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[34], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[34], false);
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
                parametr2.Value = 163;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 180;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[34], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 120, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[34], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 12, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 16, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[28],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 64, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems2[22],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 8, query1, 76, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[34], false);
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
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 151, query1, 34, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[27],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 76, query1, 125, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlCirclecircleE0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(models[12],_testData[34], false);
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
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 131, query1, 111, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircleE0M.AssertModel(secondItems2[14],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 43, 174))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 40, 56))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[18],_testData[29], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[19],_testData[30], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[20],_testData[31], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[21],_testData[32], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[22],_testData[33], false);
                        NpgsqlCirclecircleE0M.AssertModel(models[23],_testData[34], false);
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
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 128);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[23], false);
                NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[24], false);
                NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[25], false);
                NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[26], false);
                NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[27], false);
                NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[28], false);
                NpgsqlCirclecircleE0M.AssertModel(models[6],_testData[29], false);
                NpgsqlCirclecircleE0M.AssertModel(models[7],_testData[30], false);
                NpgsqlCirclecircleE0M.AssertModel(models[8],_testData[31], false);
                NpgsqlCirclecircleE0M.AssertModel(models[9],_testData[32], false);
                NpgsqlCirclecircleE0M.AssertModel(models[10],_testData[33], false);
                NpgsqlCirclecircleE0M.AssertModel(models[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 163);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                NpgsqlCirclecircleE0M.AssertModel(models[0],_testData[29], false);
                NpgsqlCirclecircleE0M.AssertModel(models[1],_testData[30], false);
                NpgsqlCirclecircleE0M.AssertModel(models[2],_testData[31], false);
                NpgsqlCirclecircleE0M.AssertModel(models[3],_testData[32], false);
                NpgsqlCirclecircleE0M.AssertModel(models[4],_testData[33], false);
                NpgsqlCirclecircleE0M.AssertModel(models[5],_testData[34], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.910953224363361d, y: 0.7590411358514177d), radius: 0.14522659240942382d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3604430565985526d, y: 0.8559127516658448d), radius: 0.6777272590337146d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7003750991953647d, y: 0.14589840938003107d), radius: 0.6644818971766566d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2988584458239585d, y: 0.38108122270476585d), radius: 0.23556402452011682d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.026054561337961246d, y: 0.47266425990136973d), radius: 0.8954907545392004d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8046241275950156d, y: 0.0252055115533375d), radius: 0.27134290363319313d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5029656250811605d, y: 0.5758095110522531d), radius: 0.646315104230721d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40205627435296765d, y: 0.4352310209368131d), radius: 0.6186706553884234d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8378914220627659d, y: 0.733226627976624d), radius: 0.8580365400369888d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.299694881997992d, y: 0.49656202315053255d), radius: 0.4294628669981211d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2728727001096811d, y: 0.4262435856235466d), radius: 0.22880098253849634d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2416134591816339d, y: 0.7015465350096548d), radius: 0.3784453954510786d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8715689950812319d, y: 0.9843544701230489d), radius: 0.8988457203311189d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6777958706994793d, y: 0.22208864189182043d), radius: 0.2980847506308971d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45509726566884445d, y: 0.9218570171201649d), radius: 0.31180461648117996d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8326469980041331d, y: 0.6149275114438811d), radius: 0.31443630983282844d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4202359855029223d, y: 0.7051444441824309d), radius: 0.06595598454128149d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7809551513340685d, y: 0.45270651644420146d), radius: 0.6471317176579169d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7867374589461672d, y: 0.7610349369342039d), radius: 0.9604100959582526d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5871592549579316d, y: 0.5410643535427718d), radius: 0.8957413480411831d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6406041242427389d, y: 0.00168825601687983d), radius: 0.8829509385263834d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5588929139805087d, y: 0.4532760576610849d), radius: 0.02625015055057367d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11379937125844308d, y: 0.2907591380795561d), radius: 0.2638689591166784d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.392279396422309d, y: 0.26785149196083935d), radius: 0.739878201510584d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6174099537806303d, y: 0.42986859045628234d), radius: 0.9934464086698713d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38667246219784657d, y: 0.8815698301994218d), radius: 0.9892294016011495d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3597180134150666d, y: 0.42838516467137944d), radius: 0.4201009652439214d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5916186085815444d, y: 0.2985859472111886d), radius: 0.14133622205578267d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7850440174316258d, y: 0.0481962699442644d), radius: 0.6023327951156265d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2868923412964681d, y: 0.7503134505887603d), radius: 0.6704904030598747d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5999012325139095d, y: 0.8784036417985821d), radius: 0.36826808277442813d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9200705927669913d, y: 0.30120245259319245d), radius: 0.18519730124837974d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05474353755787331d, y: 0.1885044157162098d), radius: 0.11062649749733833d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1889480405950501d, y: 0.2267526356212326d), radius: 0.6070719742279723d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.008663718037554724d, y: 0.9129736636225927d), radius: 0.06634397975156037d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9936551885845469d, y: 0.7930343939362244d), radius: 0.6383260453584522d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6995705286971552d, y: 0.7618572369326017d), radius: 0.5411651985374284d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8335715103818138d, y: 0.4633575534136969d), radius: 0.4450935518262462d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5532377934313283d, y: 0.3212553035641569d), radius: 0.6995564038518618d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5916957426927816d, y: 0.7942584088708524d), radius: 0.5514354496410029d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9985471016461706d, y: 0.6865271058428633d), radius: 0.49798957409684974d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17847124647393486d, y: 0.021203259045946d), radius: 0.13056709313964532d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8135276529170498d, y: 0.019125147115112595d), radius: 0.470573603686398d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4648956648186042d, y: 0.22218396881916513d), radius: 0.19662830314955915d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4940718833020844d, y: 0.43755231439113895d), radius: 0.38984699315757687d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09961824747794767d, y: 0.1308208019004079d), radius: 0.022901721131375563d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45149710663403075d, y: 0.44090960117796674d), radius: 0.2865855362826649d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14242638974262223d, y: 0.7658991127930367d), radius: 0.42822517345635336d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3318690956881519d, y: 0.6739145767928107d), radius: 0.9132025597463931d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13188071635681953d, y: 0.21629822091592799d), radius: 0.0542450889316729d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03946387462088563d, y: 0.15989653298997852d), radius: 0.42717980351046936d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9294714511846673d, y: 0.017948978932704418d), radius: 0.714079979047095d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3840126311043479d, y: 0.012802409775143353d), radius: 0.22811061691028311d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6260114380554963d, y: 0.7233296641752787d), radius: 0.6668522237525827d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9692818963930642d, y: 0.5690983958272673d), radius: 0.888064496090403d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38915402354816253d, y: 0.7678099847063075d), radius: 0.12957006315061248d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2444357607059695d, y: 0.5632269950148924d), radius: 0.31905170947489625d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9568704295773452d, y: 0.5303787908197078d), radius: 0.6309254791191002d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16015673228499216d, y: 0.3467626164303992d), radius: 0.7052143854230766d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.575201159123974d, y: 0.7231456139763978d), radius: 0.8986005330408174d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17868970010544616d, y: 0.6901196854138235d), radius: 0.15940581119736863d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1106395184044352d, y: 0.6810944943409999d), radius: 0.9844085808304929d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8683910672556114d, y: 0.1967407540524404d), radius: 0.9111880604524782d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8393414297815128d, y: 0.18218700955316514d), radius: 0.09969278314727426d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9724233615528123d, y: 0.9116329767830104d), radius: 0.8910691957426436d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.55417972083772d, y: 0.7136317112201653d), radius: 0.8013390199521584d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6734452235837675d, y: 0.014374065166527727d), radius: 0.0845006929385046d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761733665628858d, y: 0.7455887634639258d), radius: 0.09996445200379611d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.060922480786108624d, y: 0.1519227089280385d), radius: 0.4887501367255287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11277027086137092d, y: 0.510283739759392d), radius: 0.040307567468396255d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12149060240457399d, y: 0.30104993913357103d), radius: 0.5692490543802889d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3283841144543217d, y: 0.8591302917588685d), radius: 0.03810078929861849d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8522908952971222d, y: 0.21670975177213425d), radius: 0.11934858715393115d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.006066197232450721d, y: 0.08060269670289577d), radius: 0.24122548269073607d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8530570313698563d, y: 0.44668152577420994d), radius: 0.3997821947737803d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5211910290538099d, y: 0.0039564713176794d), radius: 0.7220904504141255d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4997631285368389d, y: 0.8074154634922572d), radius: 0.2622378108052038d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42737118529292584d, y: 0.5234157746125164d), radius: 0.13757853697481992d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.324306784471017d, y: 0.7341212794580575d), radius: 0.13613001514667933d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1287936492295444d, y: 0.23254304023269212d), radius: 0.2717140007720913d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4615612904047788d, y: 0.6069172358796816d), radius: 0.06732954701043992d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7638462551832835d, y: 0.4038327464098789d), radius: 0.20514156654016957d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.910953224363361d, y: 0.7590411358514177d), radius: 0.14522659240942382d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3604430565985526d, y: 0.8559127516658448d), radius: 0.6777272590337146d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7003750991953647d, y: 0.14589840938003107d), radius: 0.6644818971766566d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2988584458239585d, y: 0.38108122270476585d), radius: 0.23556402452011682d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.026054561337961246d, y: 0.47266425990136973d), radius: 0.8954907545392004d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8046241275950156d, y: 0.0252055115533375d), radius: 0.27134290363319313d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5029656250811605d, y: 0.5758095110522531d), radius: 0.646315104230721d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40205627435296765d, y: 0.4352310209368131d), radius: 0.6186706553884234d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8378914220627659d, y: 0.733226627976624d), radius: 0.8580365400369888d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.299694881997992d, y: 0.49656202315053255d), radius: 0.4294628669981211d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2728727001096811d, y: 0.4262435856235466d), radius: 0.22880098253849634d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2416134591816339d, y: 0.7015465350096548d), radius: 0.3784453954510786d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8715689950812319d, y: 0.9843544701230489d), radius: 0.8988457203311189d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6777958706994793d, y: 0.22208864189182043d), radius: 0.2980847506308971d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45509726566884445d, y: 0.9218570171201649d), radius: 0.31180461648117996d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8326469980041331d, y: 0.6149275114438811d), radius: 0.31443630983282844d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4202359855029223d, y: 0.7051444441824309d), radius: 0.06595598454128149d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7809551513340685d, y: 0.45270651644420146d), radius: 0.6471317176579169d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7867374589461672d, y: 0.7610349369342039d), radius: 0.9604100959582526d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5871592549579316d, y: 0.5410643535427718d), radius: 0.8957413480411831d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6406041242427389d, y: 0.00168825601687983d), radius: 0.8829509385263834d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((52)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5588929139805087d, y: 0.4532760576610849d), radius: 0.02625015055057367d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11379937125844308d, y: 0.2907591380795561d), radius: 0.2638689591166784d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.392279396422309d, y: 0.26785149196083935d), radius: 0.739878201510584d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6174099537806303d, y: 0.42986859045628234d), radius: 0.9934464086698713d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38667246219784657d, y: 0.8815698301994218d), radius: 0.9892294016011495d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3597180134150666d, y: 0.42838516467137944d), radius: 0.4201009652439214d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5916186085815444d, y: 0.2985859472111886d), radius: 0.14133622205578267d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7850440174316258d, y: 0.0481962699442644d), radius: 0.6023327951156265d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((76)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2868923412964681d, y: 0.7503134505887603d), radius: 0.6704904030598747d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5999012325139095d, y: 0.8784036417985821d), radius: 0.36826808277442813d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9200705927669913d, y: 0.30120245259319245d), radius: 0.18519730124837974d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((85)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05474353755787331d, y: 0.1885044157162098d), radius: 0.11062649749733833d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1889480405950501d, y: 0.2267526356212326d), radius: 0.6070719742279723d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.008663718037554724d, y: 0.9129736636225927d), radius: 0.06634397975156037d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9936551885845469d, y: 0.7930343939362244d), radius: 0.6383260453584522d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6995705286971552d, y: 0.7618572369326017d), radius: 0.5411651985374284d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((96)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8335715103818138d, y: 0.4633575534136969d), radius: 0.4450935518262462d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5532377934313283d, y: 0.3212553035641569d), radius: 0.6995564038518618d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5916957426927816d, y: 0.7942584088708524d), radius: 0.5514354496410029d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9985471016461706d, y: 0.6865271058428633d), radius: 0.49798957409684974d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17847124647393486d, y: 0.021203259045946d), radius: 0.13056709313964532d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8135276529170498d, y: 0.019125147115112595d), radius: 0.470573603686398d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4648956648186042d, y: 0.22218396881916513d), radius: 0.19662830314955915d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4940718833020844d, y: 0.43755231439113895d), radius: 0.38984699315757687d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09961824747794767d, y: 0.1308208019004079d), radius: 0.022901721131375563d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45149710663403075d, y: 0.44090960117796674d), radius: 0.2865855362826649d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14242638974262223d, y: 0.7658991127930367d), radius: 0.42822517345635336d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3318690956881519d, y: 0.6739145767928107d), radius: 0.9132025597463931d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13188071635681953d, y: 0.21629822091592799d), radius: 0.0542450889316729d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03946387462088563d, y: 0.15989653298997852d), radius: 0.42717980351046936d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9294714511846673d, y: 0.017948978932704418d), radius: 0.714079979047095d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3840126311043479d, y: 0.012802409775143353d), radius: 0.22811061691028311d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6260114380554963d, y: 0.7233296641752787d), radius: 0.6668522237525827d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9692818963930642d, y: 0.5690983958272673d), radius: 0.888064496090403d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38915402354816253d, y: 0.7678099847063075d), radius: 0.12957006315061248d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2444357607059695d, y: 0.5632269950148924d), radius: 0.31905170947489625d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9568704295773452d, y: 0.5303787908197078d), radius: 0.6309254791191002d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16015673228499216d, y: 0.3467626164303992d), radius: 0.7052143854230766d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.575201159123974d, y: 0.7231456139763978d), radius: 0.8986005330408174d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17868970010544616d, y: 0.6901196854138235d), radius: 0.15940581119736863d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1106395184044352d, y: 0.6810944943409999d), radius: 0.9844085808304929d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8683910672556114d, y: 0.1967407540524404d), radius: 0.9111880604524782d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((156)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8393414297815128d, y: 0.18218700955316514d), radius: 0.09969278314727426d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9724233615528123d, y: 0.9116329767830104d), radius: 0.8910691957426436d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.55417972083772d, y: 0.7136317112201653d), radius: 0.8013390199521584d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6734452235837675d, y: 0.014374065166527727d), radius: 0.0845006929385046d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6761733665628858d, y: 0.7455887634639258d), radius: 0.09996445200379611d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((166)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.060922480786108624d, y: 0.1519227089280385d), radius: 0.4887501367255287d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11277027086137092d, y: 0.510283739759392d), radius: 0.040307567468396255d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((174)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12149060240457399d, y: 0.30104993913357103d), radius: 0.5692490543802889d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3283841144543217d, y: 0.8591302917588685d), radius: 0.03810078929861849d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((180)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8522908952971222d, y: 0.21670975177213425d), radius: 0.11934858715393115d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.006066197232450721d, y: 0.08060269670289577d), radius: 0.24122548269073607d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8530570313698563d, y: 0.44668152577420994d), radius: 0.3997821947737803d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5211910290538099d, y: 0.0039564713176794d), radius: 0.7220904504141255d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((183)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4997631285368389d, y: 0.8074154634922572d), radius: 0.2622378108052038d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((189)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42737118529292584d, y: 0.5234157746125164d), radius: 0.13757853697481992d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((90)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.324306784471017d, y: 0.7341212794580575d), radius: 0.13613001514667933d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1287936492295444d, y: 0.23254304023269212d), radius: 0.2717140007720913d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((195)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4615612904047788d, y: 0.6069172358796816d), radius: 0.06732954701043992d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7638462551832835d, y: 0.4038327464098789d), radius: 0.20514156654016957d))));

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

