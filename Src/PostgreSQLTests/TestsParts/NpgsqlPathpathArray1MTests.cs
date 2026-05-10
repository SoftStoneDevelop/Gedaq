

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09817551359620547d, y: 0.4014526471216642d), new NpgsqlTypes.NpgsqlPoint(x: 0.7542993339903769d, y: 0.24279704122483314d), new NpgsqlTypes.NpgsqlPoint(x: 0.07907910601228196d, y: 0.5837045777007802d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5515799128210527d, y: 0.22561986452781624d), new NpgsqlTypes.NpgsqlPoint(x: 0.04177591933559166d, y: 0.1024064944672951d), new NpgsqlTypes.NpgsqlPoint(x: 0.9286609135564254d, y: 0.45475720078112625d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15837985062733784d, y: 0.37565344354729535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7528036332164766d, y: 0.73305697475215d), new NpgsqlTypes.NpgsqlPoint(x: 0.29628541283614585d, y: 0.9573774648234459d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9431644685907883d, y: 0.11982126241047153d), new NpgsqlTypes.NpgsqlPoint(x: 0.8067069607835585d, y: 0.7550735932632267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6210556680840121d, y: 0.912570742844887d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8569236277912451d, y: 0.0577331707909392d), new NpgsqlTypes.NpgsqlPoint(x: 0.680813363854396d, y: 0.7737125753032335d), new NpgsqlTypes.NpgsqlPoint(x: 0.34352697479656524d, y: 0.4754262578117727d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.776592891315657d, y: 0.7524352171054696d), new NpgsqlTypes.NpgsqlPoint(x: 0.4945135828681868d, y: 0.41853568890082316d), new NpgsqlTypes.NpgsqlPoint(x: 0.08584465394331453d, y: 0.936928283503411d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31128476432973273d, y: 0.4578692648378908d), new NpgsqlTypes.NpgsqlPoint(x: 0.5956134268869363d, y: 0.18109657799076162d), new NpgsqlTypes.NpgsqlPoint(x: 0.8675572079299654d, y: 0.36701918680219003d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.529579856349145d, y: 0.9165265998067522d), new NpgsqlTypes.NpgsqlPoint(x: 0.3520580682082155d, y: 0.10540088114371116d), new NpgsqlTypes.NpgsqlPoint(x: 0.5394016269185498d, y: 0.17322455052203367d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29764083768901684d, y: 0.28642111543765225d), new NpgsqlTypes.NpgsqlPoint(x: 0.26184986009349687d, y: 0.9770969387171347d), new NpgsqlTypes.NpgsqlPoint(x: 0.32152454529353114d, y: 0.39480102299913555d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13504068264879154d, y: 0.8249585277106878d), new NpgsqlTypes.NpgsqlPoint(x: 0.052010281041439343d, y: 0.9642302284004975d), new NpgsqlTypes.NpgsqlPoint(x: 0.44081611924100395d, y: 0.6662467229691433d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.961167037631518d, y: 0.45287304096095216d), new NpgsqlTypes.NpgsqlPoint(x: 0.8748139640003867d, y: 0.6640185719272143d), new NpgsqlTypes.NpgsqlPoint(x: 0.4428965056924624d, y: 0.28214053511897064d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6438732731691895d, y: 0.4773508292647265d), new NpgsqlTypes.NpgsqlPoint(x: 0.5192615624308888d, y: 0.8223004292964294d), new NpgsqlTypes.NpgsqlPoint(x: 0.3474645362450782d, y: 0.505927886445303d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05814774123377353d, y: 0.14964711428723254d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570611542629367d, y: 0.2173852993737505d), new NpgsqlTypes.NpgsqlPoint(x: 0.6167181717103292d, y: 0.4648513749197163d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9548280873554357d, y: 0.6630106930014261d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848320763218905d, y: 0.9729978820454677d), new NpgsqlTypes.NpgsqlPoint(x: 0.4354687136068367d, y: 0.8339630106218848d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8424624332285576d, y: 0.8871073288293957d), new NpgsqlTypes.NpgsqlPoint(x: 0.4566462134548962d, y: 0.3384323926133417d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989492016674963d, y: 0.6198045291299779d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5664998210270968d, y: 0.6974746488736941d), new NpgsqlTypes.NpgsqlPoint(x: 0.032904019459012446d, y: 0.30499113406650835d), new NpgsqlTypes.NpgsqlPoint(x: 0.7192237329658773d, y: 0.3218242789752971d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3870808668472796d, y: 0.8452654320760548d), new NpgsqlTypes.NpgsqlPoint(x: 0.5888917219187086d, y: 0.6165377603822122d), new NpgsqlTypes.NpgsqlPoint(x: 0.8415069600305716d, y: 0.08691123553675384d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1951083541696932d, y: 0.013292584251984207d), new NpgsqlTypes.NpgsqlPoint(x: 0.4678819619421357d, y: 0.06052750372982085d), new NpgsqlTypes.NpgsqlPoint(x: 0.19910056617416572d, y: 0.6451992071975942d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9257613481938046d, y: 0.06206558152944075d), new NpgsqlTypes.NpgsqlPoint(x: 0.37235704982371964d, y: 0.3372742133567017d), new NpgsqlTypes.NpgsqlPoint(x: 0.794129919801426d, y: 0.9133796530394582d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7922889861336874d, y: 0.8814809788919227d), new NpgsqlTypes.NpgsqlPoint(x: 0.5548435721140702d, y: 0.05795230266067308d), new NpgsqlTypes.NpgsqlPoint(x: 0.03318032578324681d, y: 0.41848407718821123d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5903984281700144d, y: 0.07645724814680377d), new NpgsqlTypes.NpgsqlPoint(x: 0.6741987114002457d, y: 0.7763723533221468d), new NpgsqlTypes.NpgsqlPoint(x: 0.14892190600910848d, y: 0.09550800888588795d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42878138603259586d, y: 0.5107712403882604d), new NpgsqlTypes.NpgsqlPoint(x: 0.9777542598632585d, y: 0.5234712528262373d), new NpgsqlTypes.NpgsqlPoint(x: 0.288278124406088d, y: 0.5896049570711336d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8319607467377511d, y: 0.9346052468632492d), new NpgsqlTypes.NpgsqlPoint(x: 0.2089120552360223d, y: 0.29125029722152107d), new NpgsqlTypes.NpgsqlPoint(x: 0.35412235657165003d, y: 0.05249865533475817d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8602663796336899d, y: 0.7574224029277439d), new NpgsqlTypes.NpgsqlPoint(x: 0.9640561787213935d, y: 0.17289166170748627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5741057539102064d, y: 0.5427519819048023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6883701950257761d, y: 0.4811547083073465d), new NpgsqlTypes.NpgsqlPoint(x: 0.448596551469864d, y: 0.8996290013090643d), new NpgsqlTypes.NpgsqlPoint(x: 0.7053412722361458d, y: 0.706198725194515d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16337869715263464d, y: 0.5290360854525046d), new NpgsqlTypes.NpgsqlPoint(x: 0.7983765996537494d, y: 0.2501323921390458d), new NpgsqlTypes.NpgsqlPoint(x: 0.527574158593602d, y: 0.30521160522941737d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1292500366872783d, y: 0.46231323689391546d), new NpgsqlTypes.NpgsqlPoint(x: 0.6672264927759878d, y: 0.7404429385580755d), new NpgsqlTypes.NpgsqlPoint(x: 0.5617974635610273d, y: 0.727290090431865d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33837729401741323d, y: 0.9585628098593861d), new NpgsqlTypes.NpgsqlPoint(x: 0.7768840903086431d, y: 0.4757319274725653d), new NpgsqlTypes.NpgsqlPoint(x: 0.011639039388282924d, y: 0.725924929766943d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29774975239783497d, y: 0.32075594172321875d), new NpgsqlTypes.NpgsqlPoint(x: 0.30314249721353126d, y: 0.9714608348278462d), new NpgsqlTypes.NpgsqlPoint(x: 0.5186883383763136d, y: 0.2927446988713306d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6116083837136751d, y: 0.16972995799283985d), new NpgsqlTypes.NpgsqlPoint(x: 0.5467423760660429d, y: 0.30011964310158223d), new NpgsqlTypes.NpgsqlPoint(x: 0.23075567415903575d, y: 0.5666220407698356d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.84986364071639d, y: 0.24757348975668259d), new NpgsqlTypes.NpgsqlPoint(x: 0.6299379305440659d, y: 0.1477295279796489d), new NpgsqlTypes.NpgsqlPoint(x: 0.31550048226287275d, y: 0.014835921448136613d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6903004039232467d, y: 0.6055510817602504d), new NpgsqlTypes.NpgsqlPoint(x: 0.10400457957300402d, y: 0.4795253030862511d), new NpgsqlTypes.NpgsqlPoint(x: 0.2677271653864981d, y: 0.35984054936108123d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.286415629653485d, y: 0.017743443262458913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9576892992134194d, y: 0.8434837153817822d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852575625077718d, y: 0.8147840492838812d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011575813086085462d, y: 0.4119131016002464d), new NpgsqlTypes.NpgsqlPoint(x: 0.4980094526323391d, y: 0.37745147507139387d), new NpgsqlTypes.NpgsqlPoint(x: 0.720664362725452d, y: 0.631292830372502d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8983307025278205d, y: 0.3586194978129398d), new NpgsqlTypes.NpgsqlPoint(x: 0.751512769552963d, y: 0.15892927287490766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5566018504794835d, y: 0.39106982249813615d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19800968244166262d, y: 0.3011502740877635d), new NpgsqlTypes.NpgsqlPoint(x: 0.5223706716024775d, y: 0.21586466334297516d), new NpgsqlTypes.NpgsqlPoint(x: 0.7911691616267409d, y: 0.23958473046718953d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33862907273730136d, y: 0.4531451789572346d), new NpgsqlTypes.NpgsqlPoint(x: 0.824917174511999d, y: 0.43661894431145387d), new NpgsqlTypes.NpgsqlPoint(x: 0.37379712346156047d, y: 0.8960414111177605d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8742973654258501d, y: 0.5729653898044152d), new NpgsqlTypes.NpgsqlPoint(x: 0.3297017150131185d, y: 0.847868513636845d), new NpgsqlTypes.NpgsqlPoint(x: 0.984860072978012d, y: 0.6240448463082119d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3619988576474895d, y: 0.3240880001665768d), new NpgsqlTypes.NpgsqlPoint(x: 0.4057912715190196d, y: 0.28074059881165425d), new NpgsqlTypes.NpgsqlPoint(x: 0.5170847306999364d, y: 0.748072821469881d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8455437063082702d, y: 0.004569475474628049d), new NpgsqlTypes.NpgsqlPoint(x: 0.7680158111828553d, y: 0.40152979091654883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6889041806522833d, y: 0.7820464119825115d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020416405968397777d, y: 0.3107943585650531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9499404190556312d, y: 0.6617475139179515d), new NpgsqlTypes.NpgsqlPoint(x: 0.4418800666296d, y: 0.50989493135962d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6409118053897009d, y: 0.669594102597114d), new NpgsqlTypes.NpgsqlPoint(x: 0.5103093940990872d, y: 0.016725837968538104d), new NpgsqlTypes.NpgsqlPoint(x: 0.4599907417918414d, y: 0.6618793900624024d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8783032648390088d, y: 0.91072282038235d), new NpgsqlTypes.NpgsqlPoint(x: 0.8687895545621234d, y: 0.1610672865171472d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919507776513566d, y: 0.20869638064723495d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7577587602005623d, y: 0.7094137782539175d), new NpgsqlTypes.NpgsqlPoint(x: 0.8192304291586607d, y: 0.5918054333299424d), new NpgsqlTypes.NpgsqlPoint(x: 0.5533517356903038d, y: 0.196734455588499d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6957953878583193d, y: 0.5590580012896066d), new NpgsqlTypes.NpgsqlPoint(x: 0.15951352360066873d, y: 0.49603975319341953d), new NpgsqlTypes.NpgsqlPoint(x: 0.22828566528140437d, y: 0.5934285511543327d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8767527503968019d, y: 0.35752041033831194d), new NpgsqlTypes.NpgsqlPoint(x: 0.3080045604830258d, y: 0.2856883144555695d), new NpgsqlTypes.NpgsqlPoint(x: 0.95869627041027d, y: 0.006535151790267202d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7418189030092505d, y: 0.9920070487020051d), new NpgsqlTypes.NpgsqlPoint(x: 0.2897983617671672d, y: 0.02081514479036284d), new NpgsqlTypes.NpgsqlPoint(x: 0.7430683261901523d, y: 0.058936817158227406d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3700502473302627d, y: 0.27425549766960744d), new NpgsqlTypes.NpgsqlPoint(x: 0.6963493304343955d, y: 0.696835163627168d), new NpgsqlTypes.NpgsqlPoint(x: 0.7064943049473219d, y: 0.8277742357924655d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3533704766483289d, y: 0.8534350557331942d), new NpgsqlTypes.NpgsqlPoint(x: 0.27843358494006487d, y: 0.854282892401068d), new NpgsqlTypes.NpgsqlPoint(x: 0.1677457174676138d, y: 0.6027285798491433d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7376207837622102d, y: 0.8786789287283934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9496518934051583d, y: 0.23289877776016243d), new NpgsqlTypes.NpgsqlPoint(x: 0.4954238630675841d, y: 0.7631706969152542d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5334894621270796d, y: 0.40380973819464383d), new NpgsqlTypes.NpgsqlPoint(x: 0.5295175493027356d, y: 0.5679366051418293d), new NpgsqlTypes.NpgsqlPoint(x: 0.5684233766761605d, y: 0.24352398666643948d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6234850510252675d, y: 0.7824555102773224d), new NpgsqlTypes.NpgsqlPoint(x: 0.6533090004573727d, y: 0.7240768129775523d), new NpgsqlTypes.NpgsqlPoint(x: 0.11665880635992176d, y: 0.14428613033739113d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6974447190725401d, y: 0.8052154758382769d), new NpgsqlTypes.NpgsqlPoint(x: 0.7881856137936685d, y: 0.9535231219614354d), new NpgsqlTypes.NpgsqlPoint(x: 0.47921238829549606d, y: 0.9328178140067929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10350350050317425d, y: 0.41078676221843635d), new NpgsqlTypes.NpgsqlPoint(x: 0.42318446638437357d, y: 0.10641648469724307d), new NpgsqlTypes.NpgsqlPoint(x: 0.3670348603453074d, y: 0.05672867780919444d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04104756171615975d, y: 0.45418142405126705d), new NpgsqlTypes.NpgsqlPoint(x: 0.1468046270461123d, y: 0.41658484646463056d), new NpgsqlTypes.NpgsqlPoint(x: 0.795898597612438d, y: 0.6844937683350076d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9637489477102456d, y: 0.6907712439306389d), new NpgsqlTypes.NpgsqlPoint(x: 0.5012510167318956d, y: 0.038356042397440504d), new NpgsqlTypes.NpgsqlPoint(x: 0.9122552008188652d, y: 0.8933549651964554d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19804812978430153d, y: 0.7390492421607437d), new NpgsqlTypes.NpgsqlPoint(x: 0.047881386055186104d, y: 0.5370820098723273d), new NpgsqlTypes.NpgsqlPoint(x: 0.5793515905239499d, y: 0.015082585881356247d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9674755081007554d, y: 0.22127905763579492d), new NpgsqlTypes.NpgsqlPoint(x: 0.5576865831603391d, y: 0.02878604671288676d), new NpgsqlTypes.NpgsqlPoint(x: 0.2735686804148082d, y: 0.24329062523297618d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6790695367615497d, y: 0.7872827721956481d), new NpgsqlTypes.NpgsqlPoint(x: 0.19238017776161642d, y: 0.807821150232352d), new NpgsqlTypes.NpgsqlPoint(x: 0.324711753374889d, y: 0.5388780164912359d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7759984044913085d, y: 0.9865979679915333d), new NpgsqlTypes.NpgsqlPoint(x: 0.32973923511138425d, y: 0.43708473171314954d), new NpgsqlTypes.NpgsqlPoint(x: 0.4508680278236309d, y: 0.8633883139065954d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2686353380798786d, y: 0.7245695469438532d), new NpgsqlTypes.NpgsqlPoint(x: 0.4477949055334566d, y: 0.8570278011138811d), new NpgsqlTypes.NpgsqlPoint(x: 0.7090176917797747d, y: 0.354086867309358d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9138184785278967d, y: 0.45273469813906086d), new NpgsqlTypes.NpgsqlPoint(x: 0.714231062429058d, y: 0.24900241057499883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6815102131018247d, y: 0.1460084929181915d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5642766908042774d, y: 0.08962485860316272d), new NpgsqlTypes.NpgsqlPoint(x: 0.4795589157660176d, y: 0.8495042520035488d), new NpgsqlTypes.NpgsqlPoint(x: 0.0882017903375556d, y: 0.16685918503776165d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20894413011832946d, y: 0.45684707755661347d), new NpgsqlTypes.NpgsqlPoint(x: 0.9772058878835673d, y: 0.8225683664141626d), new NpgsqlTypes.NpgsqlPoint(x: 0.11760020698075457d, y: 0.8143041813322501d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.967944038891211d, y: 0.6646884523535096d), new NpgsqlTypes.NpgsqlPoint(x: 0.030308505660001095d, y: 0.0324406568814376d), new NpgsqlTypes.NpgsqlPoint(x: 0.32142564148097896d, y: 0.8783960686508874d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33187668356302535d, y: 0.3767222452070278d), new NpgsqlTypes.NpgsqlPoint(x: 0.5782058292282124d, y: 0.21510819250914592d), new NpgsqlTypes.NpgsqlPoint(x: 0.9922982192691228d, y: 0.6752495443196934d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9703726555416844d, y: 0.6319080734950054d), new NpgsqlTypes.NpgsqlPoint(x: 0.10632790985649221d, y: 0.2661726688700109d), new NpgsqlTypes.NpgsqlPoint(x: 0.7612276656368189d, y: 0.7580008896555303d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6685181808679643d, y: 0.8066613949632405d), new NpgsqlTypes.NpgsqlPoint(x: 0.813379350273635d, y: 0.8840925562848869d), new NpgsqlTypes.NpgsqlPoint(x: 0.1422260844830946d, y: 0.13687215135813602d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20491294272784755d, y: 0.1637143715075362d), new NpgsqlTypes.NpgsqlPoint(x: 0.10357412544516853d, y: 0.7763099324161223d), new NpgsqlTypes.NpgsqlPoint(x: 0.17244230116933146d, y: 0.07353796833958348d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7365200403173988d, y: 0.2328163509498501d), new NpgsqlTypes.NpgsqlPoint(x: 0.057553783556261506d, y: 0.26154222463732524d), new NpgsqlTypes.NpgsqlPoint(x: 0.978750920713341d, y: 0.6746948359305972d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8359608610777666d, y: 0.6541698479010482d), new NpgsqlTypes.NpgsqlPoint(x: 0.8278815173349935d, y: 0.8921178908113351d), new NpgsqlTypes.NpgsqlPoint(x: 0.44241987894927226d, y: 0.7082377101472753d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3173381428470128d, y: 0.055801515261896695d), new NpgsqlTypes.NpgsqlPoint(x: 0.19880638936977335d, y: 0.783905621733788d), new NpgsqlTypes.NpgsqlPoint(x: 0.573116027643187d, y: 0.986471269393968d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5689516952058804d, y: 0.34078586927247345d), new NpgsqlTypes.NpgsqlPoint(x: 0.43639578473245544d, y: 0.6542356852998173d), new NpgsqlTypes.NpgsqlPoint(x: 0.13268051806315384d, y: 0.8673693167529772d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15348156864131302d, y: 0.8886131030123526d), new NpgsqlTypes.NpgsqlPoint(x: 0.09101891785798144d, y: 0.35755651333181127d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626871065456863d, y: 0.9649485704621326d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35130549272752465d, y: 0.594814077598571d), new NpgsqlTypes.NpgsqlPoint(x: 0.7508451983126222d, y: 0.5403468913754648d), new NpgsqlTypes.NpgsqlPoint(x: 0.42345522502380484d, y: 0.9969855790546587d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23248319861937305d, y: 0.43151278316067543d), new NpgsqlTypes.NpgsqlPoint(x: 0.2727016408546037d, y: 0.17341500544716792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9843042677814337d, y: 0.5442200439955428d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8550538629209126d, y: 0.9370502389266303d), new NpgsqlTypes.NpgsqlPoint(x: 0.6982024772078854d, y: 0.0029999565691153363d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534635114870948d, y: 0.3264838590910233d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.509748213470085d, y: 0.7768386355829049d), new NpgsqlTypes.NpgsqlPoint(x: 0.3363572552848636d, y: 0.13961818950972493d), new NpgsqlTypes.NpgsqlPoint(x: 0.0966110045770161d, y: 0.9406048095848353d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9914996325227937d, y: 0.8613677930269305d), new NpgsqlTypes.NpgsqlPoint(x: 0.7869236636041171d, y: 0.8883657252721289d), new NpgsqlTypes.NpgsqlPoint(x: 0.4475941257505296d, y: 0.9250491120862125d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2808859366665497d, y: 0.8931128474807264d), new NpgsqlTypes.NpgsqlPoint(x: 0.1485052324387216d, y: 0.08844778678278453d), new NpgsqlTypes.NpgsqlPoint(x: 0.18509492987119114d, y: 0.7970220289889752d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37985867099104675d, y: 0.17859444770212896d), new NpgsqlTypes.NpgsqlPoint(x: 0.5839022910895242d, y: 0.8522078373468135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8861281422371455d, y: 0.12990792514392213d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2179859308626264d, y: 0.4966552071098981d), new NpgsqlTypes.NpgsqlPoint(x: 0.870807360580117d, y: 0.5602320005215253d), new NpgsqlTypes.NpgsqlPoint(x: 0.898992466061638d, y: 0.4289689520722809d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29734852441198467d, y: 0.46918811343764033d), new NpgsqlTypes.NpgsqlPoint(x: 0.4130498041963827d, y: 0.8862708996633674d), new NpgsqlTypes.NpgsqlPoint(x: 0.6708102589290283d, y: 0.4917468687694968d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31589275738213995d, y: 0.02903591875465117d), new NpgsqlTypes.NpgsqlPoint(x: 0.6862858279385932d, y: 0.12710155236696596d), new NpgsqlTypes.NpgsqlPoint(x: 0.08189366762600936d, y: 0.6258233941475517d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8245472098343753d, y: 0.3004419360166587d), new NpgsqlTypes.NpgsqlPoint(x: 0.21872013865186157d, y: 0.06445154939647413d), new NpgsqlTypes.NpgsqlPoint(x: 0.3781978295882362d, y: 0.5655969572549974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2627779646920346d, y: 0.21499007444018658d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098203074693762d, y: 0.6418493989971882d), new NpgsqlTypes.NpgsqlPoint(x: 0.4238065524604141d, y: 0.5696174579926304d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9586730536162776d, y: 0.3926623095870385d), new NpgsqlTypes.NpgsqlPoint(x: 0.7962699938543683d, y: 0.48036106484252816d), new NpgsqlTypes.NpgsqlPoint(x: 0.9347339744852338d, y: 0.5423035385967289d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18131383566750092d, y: 0.32231521317855116d), new NpgsqlTypes.NpgsqlPoint(x: 0.7199092286496337d, y: 0.09127216102011637d), new NpgsqlTypes.NpgsqlPoint(x: 0.2902933828642039d, y: 0.2946908232421497d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5920536396224411d, y: 0.1952118421343414d), new NpgsqlTypes.NpgsqlPoint(x: 0.7861511529732896d, y: 0.46594813540576974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6506704581214899d, y: 0.2265708752290061d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6560165385633506d, y: 0.13765568873574086d), new NpgsqlTypes.NpgsqlPoint(x: 0.2700046246999579d, y: 0.9652009123494883d), new NpgsqlTypes.NpgsqlPoint(x: 0.07544072244997635d, y: 0.37770595662376205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.047548642489033455d, y: 0.08765946965922977d), new NpgsqlTypes.NpgsqlPoint(x: 0.00619229603773408d, y: 0.556446870183782d), new NpgsqlTypes.NpgsqlPoint(x: 0.9649729965494412d, y: 0.716627305754263d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4797846759131722d, y: 0.7170885194166137d), new NpgsqlTypes.NpgsqlPoint(x: 0.43354923486124974d, y: 0.9357483875827042d), new NpgsqlTypes.NpgsqlPoint(x: 0.23350557541752748d, y: 0.880456746713923d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32392292083444885d, y: 0.23121455425648985d), new NpgsqlTypes.NpgsqlPoint(x: 0.26973623758796494d, y: 0.03312679574713251d), new NpgsqlTypes.NpgsqlPoint(x: 0.8612298437130693d, y: 0.828667963677831d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7881383503558801d, y: 0.7105683991995686d), new NpgsqlTypes.NpgsqlPoint(x: 0.28206340626819315d, y: 0.6924729685837413d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019617398105511d, y: 0.39910218108036355d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7176543159806714d, y: 0.8941538009044984d), new NpgsqlTypes.NpgsqlPoint(x: 0.4303854742943639d, y: 0.8294251860849622d), new NpgsqlTypes.NpgsqlPoint(x: 0.6743811890736651d, y: 0.30048596143158557d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9359463413939233d, y: 0.15031158725761684d), new NpgsqlTypes.NpgsqlPoint(x: 0.8914036701811466d, y: 0.8293966411430544d), new NpgsqlTypes.NpgsqlPoint(x: 0.83069021218085d, y: 0.7801899130326422d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7047987059669741d, y: 0.877122190635174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9018405457779439d, y: 0.4276868456490073d), new NpgsqlTypes.NpgsqlPoint(x: 0.13441464759391553d, y: 0.675289177580986d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5064496617766536d, y: 0.16912778790554317d), new NpgsqlTypes.NpgsqlPoint(x: 0.780929888328373d, y: 0.8013742104316116d), new NpgsqlTypes.NpgsqlPoint(x: 0.9032580020389707d, y: 0.6262450577790949d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3188635579964233d, y: 0.5349077753148891d), new NpgsqlTypes.NpgsqlPoint(x: 0.4966973904435127d, y: 0.9765374637497818d), new NpgsqlTypes.NpgsqlPoint(x: 0.12080240777485751d, y: 0.4679892030270145d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8026001354174217d, y: 0.5776566739169839d), new NpgsqlTypes.NpgsqlPoint(x: 0.6878436578047673d, y: 0.9182873871365013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5584402561417401d, y: 0.02086097368653328d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4217385045462577d, y: 0.5777615442569892d), new NpgsqlTypes.NpgsqlPoint(x: 0.9382555978470561d, y: 0.8470235656339073d), new NpgsqlTypes.NpgsqlPoint(x: 0.7543058354685352d, y: 0.2551533768862245d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4582722374530648d, y: 0.5005539179670517d), new NpgsqlTypes.NpgsqlPoint(x: 0.03508890423035116d, y: 0.41240379963266005d), new NpgsqlTypes.NpgsqlPoint(x: 0.8601079709989841d, y: 0.061015345200053916d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3327738619869536d, y: 0.711285782335824d), new NpgsqlTypes.NpgsqlPoint(x: 0.6544366060430161d, y: 0.8447607109585331d), new NpgsqlTypes.NpgsqlPoint(x: 0.45257829798097604d, y: 0.8607427030776023d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6799112912348546d, y: 0.4100624531490361d), new NpgsqlTypes.NpgsqlPoint(x: 0.8014010102002096d, y: 0.21920199198354173d), new NpgsqlTypes.NpgsqlPoint(x: 0.3347237663871112d, y: 0.15026910989464204d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.56375600380518d, y: 0.06423865941456863d), new NpgsqlTypes.NpgsqlPoint(x: 0.2219187891190365d, y: 0.43472783948696847d), new NpgsqlTypes.NpgsqlPoint(x: 0.5931727119582174d, y: 0.5544104521283314d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9577974221907309d, y: 0.48351453689975243d), new NpgsqlTypes.NpgsqlPoint(x: 0.1919191355115919d, y: 0.39345919334316737d), new NpgsqlTypes.NpgsqlPoint(x: 0.6645996963125622d, y: 0.6247971834993943d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02840997642716636d, y: 0.06828970658367939d), new NpgsqlTypes.NpgsqlPoint(x: 0.26937835722580605d, y: 0.9710960932838975d), new NpgsqlTypes.NpgsqlPoint(x: 0.41675221132158635d, y: 0.8526041702214369d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1082069016330609d, y: 0.6373604656131961d), new NpgsqlTypes.NpgsqlPoint(x: 0.7270747683944172d, y: 0.19866600195114448d), new NpgsqlTypes.NpgsqlPoint(x: 0.6110634611943653d, y: 0.7042786135977138d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.935018508239758d, y: 0.7706067815161386d), new NpgsqlTypes.NpgsqlPoint(x: 0.5416116914206067d, y: 0.2744868268631594d), new NpgsqlTypes.NpgsqlPoint(x: 0.2558546094459495d, y: 0.28373395444792016d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.330866061049789d, y: 0.3317406245313992d), new NpgsqlTypes.NpgsqlPoint(x: 0.9267166754679355d, y: 0.6694391237034055d), new NpgsqlTypes.NpgsqlPoint(x: 0.9035674110967209d, y: 0.8264644102602399d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3826837246278939d, y: 0.7760482190137553d), new NpgsqlTypes.NpgsqlPoint(x: 0.4581135080773766d, y: 0.5425830481452153d), new NpgsqlTypes.NpgsqlPoint(x: 0.15206518205130115d, y: 0.822625968949729d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29657644417645534d, y: 0.35122722071498425d), new NpgsqlTypes.NpgsqlPoint(x: 0.6153723962426552d, y: 0.37576714823396995d), new NpgsqlTypes.NpgsqlPoint(x: 0.020312001020077797d, y: 0.7384052961044938d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12359983033373612d, y: 0.8701838909340086d), new NpgsqlTypes.NpgsqlPoint(x: 0.18605370019760392d, y: 0.874578173546961d), new NpgsqlTypes.NpgsqlPoint(x: 0.01138334871404445d, y: 0.08313761847117929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49078269926839124d, y: 0.981878008507213d), new NpgsqlTypes.NpgsqlPoint(x: 0.6309789259399323d, y: 0.7450833917811539d), new NpgsqlTypes.NpgsqlPoint(x: 0.12835140785094923d, y: 0.7064638294109903d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9478508288034192d, y: 0.06652469977950581d), new NpgsqlTypes.NpgsqlPoint(x: 0.9121957957373672d, y: 0.2760592844119386d), new NpgsqlTypes.NpgsqlPoint(x: 0.6514057181164975d, y: 0.5995333716265636d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8814906338591277d, y: 0.035804258198366856d), new NpgsqlTypes.NpgsqlPoint(x: 0.27552283718988735d, y: 0.6314781209054637d), new NpgsqlTypes.NpgsqlPoint(x: 0.06737197792616056d, y: 0.18644426465696462d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08023255698160958d, y: 0.5293848446056797d), new NpgsqlTypes.NpgsqlPoint(x: 0.7089280877536599d, y: 0.8882985326022999d), new NpgsqlTypes.NpgsqlPoint(x: 0.36987675297145883d, y: 0.4954150419937525d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2678786745745496d, y: 0.5240977628343932d), new NpgsqlTypes.NpgsqlPoint(x: 0.168399550495d, y: 0.5927981417264843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6807229583070475d, y: 0.6822622180868083d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28637929731429357d, y: 0.7834383250604784d), new NpgsqlTypes.NpgsqlPoint(x: 0.018070408045771202d, y: 0.5718337634078835d), new NpgsqlTypes.NpgsqlPoint(x: 0.49991142754361195d, y: 0.8620258547617734d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01389119340128131d, y: 0.592228250350512d), new NpgsqlTypes.NpgsqlPoint(x: 0.11696960537245982d, y: 0.1294054877475277d), new NpgsqlTypes.NpgsqlPoint(x: 0.7770934028888292d, y: 0.3477095718507759d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2343662369312346d, y: 0.6618180731714733d), new NpgsqlTypes.NpgsqlPoint(x: 0.39863191616649285d, y: 0.8369138790692331d), new NpgsqlTypes.NpgsqlPoint(x: 0.3939806203346332d, y: 0.6035234944463601d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.349162222614144d, y: 0.5768834508632018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7258951358830577d, y: 0.24494611558564727d), new NpgsqlTypes.NpgsqlPoint(x: 0.7268814026844588d, y: 0.5868242559958778d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0903002897076075d, y: 0.921833144958281d), new NpgsqlTypes.NpgsqlPoint(x: 0.8805484074241207d, y: 0.4309773272657881d), new NpgsqlTypes.NpgsqlPoint(x: 0.6962759085182235d, y: 0.8656412287697015d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9552052057482855d, y: 0.676272173178995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6019508758225025d, y: 0.12694509440169555d), new NpgsqlTypes.NpgsqlPoint(x: 0.6349395862795103d, y: 0.033543555593334995d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4625018841872186d, y: 0.04415920292004627d), new NpgsqlTypes.NpgsqlPoint(x: 0.1981127338269043d, y: 0.5932320120074362d), new NpgsqlTypes.NpgsqlPoint(x: 0.4010650617584335d, y: 0.43123705762489106d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2951032241756768d, y: 0.08328022721746475d), new NpgsqlTypes.NpgsqlPoint(x: 0.4994269406141346d, y: 0.28823817120630835d), new NpgsqlTypes.NpgsqlPoint(x: 0.012805565452784107d, y: 0.45011945518480756d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.029302626563576295d, y: 0.3798051596762241d), new NpgsqlTypes.NpgsqlPoint(x: 0.42195655634830787d, y: 0.1463024475243786d), new NpgsqlTypes.NpgsqlPoint(x: 0.23856807320856255d, y: 0.496782583484069d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.440149438479729d, y: 0.635446212710023d), new NpgsqlTypes.NpgsqlPoint(x: 0.9369056754740022d, y: 0.9799328289943021d), new NpgsqlTypes.NpgsqlPoint(x: 0.2845863208005295d, y: 0.23866295385850866d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6092040389400174d, y: 0.1552731045294795d), new NpgsqlTypes.NpgsqlPoint(x: 0.5991533698451916d, y: 0.33036189253571224d), new NpgsqlTypes.NpgsqlPoint(x: 0.9519082475222747d, y: 0.532812494193082d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03815757512811879d, y: 0.2586707421352771d), new NpgsqlTypes.NpgsqlPoint(x: 0.6570209214473361d, y: 0.11818756214836657d), new NpgsqlTypes.NpgsqlPoint(x: 0.8890486256595825d, y: 0.5720877664590927d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4164796282842206d, y: 0.3662227018450318d), new NpgsqlTypes.NpgsqlPoint(x: 0.9975646406345487d, y: 0.19147469826425223d), new NpgsqlTypes.NpgsqlPoint(x: 0.09669329880546851d, y: 0.5584049803540446d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.258981649175408d, y: 0.7872419968404883d), new NpgsqlTypes.NpgsqlPoint(x: 0.5230346581079283d, y: 0.0512310511130335d), new NpgsqlTypes.NpgsqlPoint(x: 0.44395414301066016d, y: 0.2097541599186159d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.317207213973841d, y: 0.5894960695320384d), new NpgsqlTypes.NpgsqlPoint(x: 0.41171667747934204d, y: 0.2415101909513787d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621973307999679d, y: 0.25664530292726395d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6705679273557168d, y: 0.6334128002917847d), new NpgsqlTypes.NpgsqlPoint(x: 0.7555570901207146d, y: 0.5630684189236284d), new NpgsqlTypes.NpgsqlPoint(x: 0.004516966083111695d, y: 0.8828061954316386d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06137843927009656d, y: 0.9708927890209842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8904346822804676d, y: 0.721403371572085d), new NpgsqlTypes.NpgsqlPoint(x: 0.9235131617343009d, y: 0.7593683190323579d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7189547049811787d, y: 0.7475969110076948d), new NpgsqlTypes.NpgsqlPoint(x: 0.6290077671413451d, y: 0.04856982797880094d), new NpgsqlTypes.NpgsqlPoint(x: 0.44988852348709774d, y: 0.09254261159354649d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8663142736591045d, y: 0.05802598125558722d), new NpgsqlTypes.NpgsqlPoint(x: 0.4458633724222505d, y: 0.06183766597361795d), new NpgsqlTypes.NpgsqlPoint(x: 0.09151657291841497d, y: 0.051621816362662165d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.839698527599315d, y: 0.6331766692250658d), new NpgsqlTypes.NpgsqlPoint(x: 0.16905583796839208d, y: 0.6214238523340009d), new NpgsqlTypes.NpgsqlPoint(x: 0.16086199704003856d, y: 0.4373876577277326d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022457083209988737d, y: 0.9591086875911563d), new NpgsqlTypes.NpgsqlPoint(x: 0.38253018989181986d, y: 0.6259454979873034d), new NpgsqlTypes.NpgsqlPoint(x: 0.574851593058455d, y: 0.5533847966692951d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26711154970186d, y: 0.7573750638851358d), new NpgsqlTypes.NpgsqlPoint(x: 0.18064044030891613d, y: 0.062137940031119276d), new NpgsqlTypes.NpgsqlPoint(x: 0.8615202205761844d, y: 0.31470750348533993d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5867232979417546d, y: 0.7029299873026212d), new NpgsqlTypes.NpgsqlPoint(x: 0.5564235577459049d, y: 0.6678708071401287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144053974888736d, y: 0.8319086935928256d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3670400248552056d, y: 0.3777174023881871d), new NpgsqlTypes.NpgsqlPoint(x: 0.42113311028129663d, y: 0.37379752579895476d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752904619582384d, y: 0.3822788011523991d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9457744434941666d, y: 0.384645396042243d), new NpgsqlTypes.NpgsqlPoint(x: 0.7335344684112582d, y: 0.011226754107320991d), new NpgsqlTypes.NpgsqlPoint(x: 0.2351484501845541d, y: 0.726322801406292d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1768944293551511d, y: 0.47982425492673764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6107239214332962d, y: 0.25213768099227807d), new NpgsqlTypes.NpgsqlPoint(x: 0.40565555984658663d, y: 0.3518219440591731d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22528524120557047d, y: 0.8703622080728327d), new NpgsqlTypes.NpgsqlPoint(x: 0.5667985442442877d, y: 0.3418997629960635d), new NpgsqlTypes.NpgsqlPoint(x: 0.0071826419070757375d, y: 0.5392384180317282d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.135335535374136d, y: 0.10217756321405913d), new NpgsqlTypes.NpgsqlPoint(x: 0.8188784837313214d, y: 0.1758393588524405d), new NpgsqlTypes.NpgsqlPoint(x: 0.7551540536451241d, y: 0.20198921926833757d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2429870448542638d, y: 0.5035327219813359d), new NpgsqlTypes.NpgsqlPoint(x: 0.20031900457949958d, y: 0.4431099416030143d), new NpgsqlTypes.NpgsqlPoint(x: 0.8885041204900288d, y: 0.04477114042128638d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4709903682898462d, y: 0.7994415574088751d), new NpgsqlTypes.NpgsqlPoint(x: 0.6339913434701994d, y: 0.09543398076686394d), new NpgsqlTypes.NpgsqlPoint(x: 0.15052953660184654d, y: 0.445997045471903d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42489306073599287d, y: 0.28250432487762056d), new NpgsqlTypes.NpgsqlPoint(x: 0.46725398886185066d, y: 0.7586664658411693d), new NpgsqlTypes.NpgsqlPoint(x: 0.35049623909061667d, y: 0.3808501832108191d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42764683467821385d, y: 0.2768338706539266d), new NpgsqlTypes.NpgsqlPoint(x: 0.8114103625848061d, y: 0.7150788568265157d), new NpgsqlTypes.NpgsqlPoint(x: 0.15198050436650368d, y: 0.37861867694190865d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9265222141522129d, y: 0.47581954809745064d), new NpgsqlTypes.NpgsqlPoint(x: 0.4953659493966429d, y: 0.8541655772792375d), new NpgsqlTypes.NpgsqlPoint(x: 0.7553047171453172d, y: 0.24661809283631753d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4501332752424483d, y: 0.8496209101375577d), new NpgsqlTypes.NpgsqlPoint(x: 0.38381890545777264d, y: 0.013457395727490273d), new NpgsqlTypes.NpgsqlPoint(x: 0.40422655603755187d, y: 0.7497023948585233d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1623847824749981d, y: 0.39795235256363604d), new NpgsqlTypes.NpgsqlPoint(x: 0.33113039682642476d, y: 0.647373839959879d), new NpgsqlTypes.NpgsqlPoint(x: 0.4752989535757661d, y: 0.05589458591765839d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010361410063531973d, y: 0.6430083909054284d), new NpgsqlTypes.NpgsqlPoint(x: 0.486543465175731d, y: 0.333980944035411d), new NpgsqlTypes.NpgsqlPoint(x: 0.2930432246098039d, y: 0.3004907802717377d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14062748564962035d, y: 0.41671678075416685d), new NpgsqlTypes.NpgsqlPoint(x: 0.8251719714455525d, y: 0.5271840988063368d), new NpgsqlTypes.NpgsqlPoint(x: 0.7984015403110378d, y: 0.0811437046902016d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4701815518020056d, y: 0.5894257278671342d), new NpgsqlTypes.NpgsqlPoint(x: 0.4311196641519861d, y: 0.9131007734608141d), new NpgsqlTypes.NpgsqlPoint(x: 0.6768483247150123d, y: 0.8474417273129432d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.894215930569234d, y: 0.5942645082163822d), new NpgsqlTypes.NpgsqlPoint(x: 0.15661782083675257d, y: 0.4827098058236221d), new NpgsqlTypes.NpgsqlPoint(x: 0.04001503229191594d, y: 0.471881442002411d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6732190705170763d, y: 0.0134197649563349d), new NpgsqlTypes.NpgsqlPoint(x: 0.39575607376973776d, y: 0.4173308561963691d), new NpgsqlTypes.NpgsqlPoint(x: 0.964448047579279d, y: 0.7535355009473143d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23377572024043503d, y: 0.11027046318886258d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420568518502594d, y: 0.43139817968844374d), new NpgsqlTypes.NpgsqlPoint(x: 0.1300573768454043d, y: 0.6358266886697693d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36567622241144204d, y: 0.5337508347920399d), new NpgsqlTypes.NpgsqlPoint(x: 0.42414270134443155d, y: 0.5152734544189724d), new NpgsqlTypes.NpgsqlPoint(x: 0.2605493808684365d, y: 0.06422791956989848d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6078751494879133d, y: 0.746717017509875d), new NpgsqlTypes.NpgsqlPoint(x: 0.8016241864065174d, y: 0.7808765451061517d), new NpgsqlTypes.NpgsqlPoint(x: 0.9520116094762694d, y: 0.23627026590829026d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3076510449841475d, y: 0.9120975694399489d), new NpgsqlTypes.NpgsqlPoint(x: 0.5954014480928017d, y: 0.5807646582933838d), new NpgsqlTypes.NpgsqlPoint(x: 0.9551401785168036d, y: 0.8290777692332199d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5348367415989824d, y: 0.6518752896372445d), new NpgsqlTypes.NpgsqlPoint(x: 0.7387831824059243d, y: 0.5976465879760203d), new NpgsqlTypes.NpgsqlPoint(x: 0.29672059858841204d, y: 0.2773676467215128d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2722958113022411d, y: 0.288759871545089d), new NpgsqlTypes.NpgsqlPoint(x: 0.8669551511233288d, y: 0.10634889474387588d), new NpgsqlTypes.NpgsqlPoint(x: 0.9456111948202091d, y: 0.2825338335775335d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.833478105973972d, y: 0.47677317888488113d), new NpgsqlTypes.NpgsqlPoint(x: 0.6873616475632983d, y: 0.188100443467202d), new NpgsqlTypes.NpgsqlPoint(x: 0.8784213428959827d, y: 0.9767931278584419d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04303865458010958d, y: 0.2591962067820618d), new NpgsqlTypes.NpgsqlPoint(x: 0.765699040025072d, y: 0.23218941619417444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6983008164532095d, y: 0.8848831653597747d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3364539288704985d, y: 0.49055494832119795d), new NpgsqlTypes.NpgsqlPoint(x: 0.28886496857785904d, y: 0.4648632894246968d), new NpgsqlTypes.NpgsqlPoint(x: 0.17564517129499668d, y: 0.5289644543095263d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8855281996756744d, y: 0.20929287389670992d), new NpgsqlTypes.NpgsqlPoint(x: 0.2181957720992017d, y: 0.5922341867586569d), new NpgsqlTypes.NpgsqlPoint(x: 0.11028318374690316d, y: 0.8871999815481394d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32558803749675125d, y: 0.1500839028137616d), new NpgsqlTypes.NpgsqlPoint(x: 0.997948764599823d, y: 0.8027096636513167d), new NpgsqlTypes.NpgsqlPoint(x: 0.8289300906690049d, y: 0.41632585933405486d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.809583130534014d, y: 0.29597536629136445d), new NpgsqlTypes.NpgsqlPoint(x: 0.783152252593529d, y: 0.6270827419196141d), new NpgsqlTypes.NpgsqlPoint(x: 0.48401419959418557d, y: 0.9021552512837667d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05666338038012475d, y: 0.3417857297045588d), new NpgsqlTypes.NpgsqlPoint(x: 0.3364632279935482d, y: 0.47008245280753436d), new NpgsqlTypes.NpgsqlPoint(x: 0.14165205986036333d, y: 0.8776045738007127d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7073603991178264d, y: 0.7456793645510309d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569633301381236d, y: 0.733202808725744d), new NpgsqlTypes.NpgsqlPoint(x: 0.7094364936467064d, y: 0.5793717245944223d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.956044260202334d, y: 0.37281813863901203d), new NpgsqlTypes.NpgsqlPoint(x: 0.8075543474305683d, y: 0.7653517726025401d), new NpgsqlTypes.NpgsqlPoint(x: 0.578559299745841d, y: 0.628203493672728d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02658019004136558d, y: 0.49678693165405663d), new NpgsqlTypes.NpgsqlPoint(x: 0.7679315387231235d, y: 0.3122557289362087d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359106418632304d, y: 0.8252919368025349d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028000949154080468d, y: 0.4700922641614005d), new NpgsqlTypes.NpgsqlPoint(x: 0.9814895021150369d, y: 0.9542113273467692d), new NpgsqlTypes.NpgsqlPoint(x: 0.9408926896617704d, y: 0.6373727408932167d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7499929883826405d, y: 0.6413112435879055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6240854837506692d, y: 0.041573252060065014d), new NpgsqlTypes.NpgsqlPoint(x: 0.6259736507726658d, y: 0.9378044924794213d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.435135206770323d, y: 0.45781465571690605d), new NpgsqlTypes.NpgsqlPoint(x: 0.6246489362462769d, y: 0.5760380046806068d), new NpgsqlTypes.NpgsqlPoint(x: 0.20935354855681987d, y: 0.702995169187394d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3569726258854229d, y: 0.5162066776808703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8619022703235713d, y: 0.7957765562737362d), new NpgsqlTypes.NpgsqlPoint(x: 0.6544695643358734d, y: 0.06127039128914957d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9944448144668064d, y: 0.9264131741734614d), new NpgsqlTypes.NpgsqlPoint(x: 0.5688627256983353d, y: 0.4243585998311312d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138290774098681d, y: 0.7458999890665032d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2196967459336423d, y: 0.6328228336881273d), new NpgsqlTypes.NpgsqlPoint(x: 0.07538694511393862d, y: 0.5947029758888148d), new NpgsqlTypes.NpgsqlPoint(x: 0.3486318179896205d, y: 0.2708974814903793d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3752534351134815d, y: 0.6257140606038993d), new NpgsqlTypes.NpgsqlPoint(x: 0.8761988294639308d, y: 0.36324283484540953d), new NpgsqlTypes.NpgsqlPoint(x: 0.4357527344696771d, y: 0.5889946628179362d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4551637864230421d, y: 0.7387983085086294d), new NpgsqlTypes.NpgsqlPoint(x: 0.802365096059695d, y: 0.5693375990099052d), new NpgsqlTypes.NpgsqlPoint(x: 0.3934542506592016d, y: 0.43435660628864503d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8091908703877682d, y: 0.7224960175522225d), new NpgsqlTypes.NpgsqlPoint(x: 0.422440469125028d, y: 0.4755789651832818d), new NpgsqlTypes.NpgsqlPoint(x: 0.6305947639843064d, y: 0.24014684577445944d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6354050536137802d, y: 0.6109066387723764d), new NpgsqlTypes.NpgsqlPoint(x: 0.45275938506720403d, y: 0.9691373533553674d), new NpgsqlTypes.NpgsqlPoint(x: 0.3598474396850644d, y: 0.44539829270765285d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6037925124900252d, y: 0.6657307774544217d), new NpgsqlTypes.NpgsqlPoint(x: 0.4724066401619077d, y: 0.22079369012748984d), new NpgsqlTypes.NpgsqlPoint(x: 0.23057259575422595d, y: 0.0409691148263005d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5447691816757172d, y: 0.227084449432589d), new NpgsqlTypes.NpgsqlPoint(x: 0.9340578483288617d, y: 0.5562082992825895d), new NpgsqlTypes.NpgsqlPoint(x: 0.6773420751949703d, y: 0.9959022369527902d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9313086564278672d, y: 0.1552441294127036d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942487929117423d, y: 0.12157333684236626d), new NpgsqlTypes.NpgsqlPoint(x: 0.5099944959483306d, y: 0.9020881970714391d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10707507617387635d, y: 0.8049052346581884d), new NpgsqlTypes.NpgsqlPoint(x: 0.15547796232860367d, y: 0.17549303186047138d), new NpgsqlTypes.NpgsqlPoint(x: 0.830760256359624d, y: 0.5338598421066759d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6281004722006399d, y: 0.9194497071612955d), new NpgsqlTypes.NpgsqlPoint(x: 0.3332857402823741d, y: 0.6824993933250725d), new NpgsqlTypes.NpgsqlPoint(x: 0.4052658643307876d, y: 0.7137494907561001d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8361883703369265d, y: 0.34709815074219186d), new NpgsqlTypes.NpgsqlPoint(x: 0.2144142239951936d, y: 0.7779177876580405d), new NpgsqlTypes.NpgsqlPoint(x: 0.17428896535769756d, y: 0.5775420977210491d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9109124281383015d, y: 0.6089126496231941d), new NpgsqlTypes.NpgsqlPoint(x: 0.7639513850389368d, y: 0.9134530126601678d), new NpgsqlTypes.NpgsqlPoint(x: 0.03017882824569751d, y: 0.6524088983100873d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7280569145719537d, y: 0.7982915024028887d), new NpgsqlTypes.NpgsqlPoint(x: 0.15725318114499165d, y: 0.8772357654387692d), new NpgsqlTypes.NpgsqlPoint(x: 0.04721222950584192d, y: 0.7488345850769881d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6083403641842711d, y: 0.6871251272687819d), new NpgsqlTypes.NpgsqlPoint(x: 0.05062338830602664d, y: 0.6088260242088724d), new NpgsqlTypes.NpgsqlPoint(x: 0.10489243557014694d, y: 0.24341707496268705d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5853264224976147d, y: 0.6589462938245786d), new NpgsqlTypes.NpgsqlPoint(x: 0.40448634231038794d, y: 0.8146751608030091d), new NpgsqlTypes.NpgsqlPoint(x: 0.3686928569330731d, y: 0.5432518720281315d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11344038639255671d, y: 0.6741727876111656d), new NpgsqlTypes.NpgsqlPoint(x: 0.3710226976472789d, y: 0.3572638592130176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8998256836161518d, y: 0.22643977949926963d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7197179794730862d, y: 0.009450703635666358d), new NpgsqlTypes.NpgsqlPoint(x: 0.9170309068111084d, y: 0.1125454069802071d), new NpgsqlTypes.NpgsqlPoint(x: 0.9606240083578772d, y: 0.6311874024993995d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.975728219744469d, y: 0.7554949399553623d), new NpgsqlTypes.NpgsqlPoint(x: 0.1116497480848544d, y: 0.2473362395750267d), new NpgsqlTypes.NpgsqlPoint(x: 0.5784107962976532d, y: 0.6613632821518498d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.629050125226487d, y: 0.3641225099034301d), new NpgsqlTypes.NpgsqlPoint(x: 0.5452042712292682d, y: 0.013650038178787405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8396049205357331d, y: 0.009594831909634616d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09710692530409049d, y: 0.026039827100855395d), new NpgsqlTypes.NpgsqlPoint(x: 0.515910985403552d, y: 0.7778927383823664d), new NpgsqlTypes.NpgsqlPoint(x: 0.0993428110738116d, y: 0.2720678666583668d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14118755304709196d, y: 0.177176710953026d), new NpgsqlTypes.NpgsqlPoint(x: 0.307647359464994d, y: 0.7875782474027139d), new NpgsqlTypes.NpgsqlPoint(x: 0.3112876337331123d, y: 0.9947842691071566d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7117516174284044d, y: 0.9083503355934253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5801124328311125d, y: 0.9537704282094457d), new NpgsqlTypes.NpgsqlPoint(x: 0.010410780377039686d, y: 0.7628075101729354d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.424818855009521d, y: 0.9622509549959694d), new NpgsqlTypes.NpgsqlPoint(x: 0.8611245414844361d, y: 0.40212932879896657d), new NpgsqlTypes.NpgsqlPoint(x: 0.18664717950088183d, y: 0.6841546119937808d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41989169093248224d, y: 0.5773764406992943d), new NpgsqlTypes.NpgsqlPoint(x: 0.7812558162932883d, y: 0.02165608207448766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5926959910625987d, y: 0.26105515318456307d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3664502296787373d, y: 0.02337751377664632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7416634020076847d, y: 0.8712897566958847d), new NpgsqlTypes.NpgsqlPoint(x: 0.8130826365631209d, y: 0.32254920346970195d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49432690469337626d, y: 0.1625719784818468d), new NpgsqlTypes.NpgsqlPoint(x: 0.9507393729050189d, y: 0.6550700096974978d), new NpgsqlTypes.NpgsqlPoint(x: 0.9304088958662625d, y: 0.37073087516573744d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8864564800642661d, y: 0.41116960252122636d), new NpgsqlTypes.NpgsqlPoint(x: 0.46834710887262265d, y: 0.8361649913229098d), new NpgsqlTypes.NpgsqlPoint(x: 0.9716633563127045d, y: 0.32978149460806316d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3794072828640732d, y: 0.6980042176715107d), new NpgsqlTypes.NpgsqlPoint(x: 0.4692682383370991d, y: 0.1651667747686194d), new NpgsqlTypes.NpgsqlPoint(x: 0.8584974063268324d, y: 0.9867576758709447d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8226329674233416d, y: 0.21184817733188954d), new NpgsqlTypes.NpgsqlPoint(x: 0.9840982916804839d, y: 0.006686747946850646d), new NpgsqlTypes.NpgsqlPoint(x: 0.14141637007052532d, y: 0.13448263867544008d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7635650549047315d, y: 0.3032216146968507d), new NpgsqlTypes.NpgsqlPoint(x: 0.7915736868696576d, y: 0.46238589433985655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5353348431555146d, y: 0.7523679598578997d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6353970737678309d, y: 0.8033804162246821d), new NpgsqlTypes.NpgsqlPoint(x: 0.5046404246734456d, y: 0.939521937655442d), new NpgsqlTypes.NpgsqlPoint(x: 0.8693419316332945d, y: 0.7298956066461407d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8128719447583628d, y: 0.167297317993073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8394112836505664d, y: 0.13068637920685788d), new NpgsqlTypes.NpgsqlPoint(x: 0.04838937666255483d, y: 0.45710232173956633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5063463039686269d, y: 0.588786331357003d), new NpgsqlTypes.NpgsqlPoint(x: 0.2129382746050501d, y: 0.1307362547731321d), new NpgsqlTypes.NpgsqlPoint(x: 0.374937558486777d, y: 0.45819793334260817d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0333039211378664d, y: 0.1746319670833395d), new NpgsqlTypes.NpgsqlPoint(x: 0.3351781133891414d, y: 0.6876027705341745d), new NpgsqlTypes.NpgsqlPoint(x: 0.9991591292917851d, y: 0.9896091603360215d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6496606936399035d, y: 0.6599715849708563d), new NpgsqlTypes.NpgsqlPoint(x: 0.790946818611437d, y: 0.7281081850250389d), new NpgsqlTypes.NpgsqlPoint(x: 0.24180363076872302d, y: 0.5467276270179677d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24318184459187775d, y: 0.16036487345539474d), new NpgsqlTypes.NpgsqlPoint(x: 0.9730924276333749d, y: 0.20881166381831862d), new NpgsqlTypes.NpgsqlPoint(x: 0.986356829076306d, y: 0.010630913830556477d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5104876383636395d, y: 0.9158503423191809d), new NpgsqlTypes.NpgsqlPoint(x: 0.24080560368127613d, y: 0.9536315617777035d), new NpgsqlTypes.NpgsqlPoint(x: 0.6273663216989328d, y: 0.7671835248154146d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07489195651823544d, y: 0.9917519712838664d), new NpgsqlTypes.NpgsqlPoint(x: 0.11324044720856186d, y: 0.24315369596948644d), new NpgsqlTypes.NpgsqlPoint(x: 0.100339369424154d, y: 0.2857742915586968d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1633284242460704d, y: 0.5429635418836314d), new NpgsqlTypes.NpgsqlPoint(x: 0.016654477344474894d, y: 0.39685158895866246d), new NpgsqlTypes.NpgsqlPoint(x: 0.7614992015791832d, y: 0.5236827900851707d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6138601547982164d, y: 0.5723911376191456d), new NpgsqlTypes.NpgsqlPoint(x: 0.938610806551085d, y: 0.2641842726577156d), new NpgsqlTypes.NpgsqlPoint(x: 0.546601955400484d, y: 0.013862920699944659d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7403713168592263d, y: 0.78862222800958d), new NpgsqlTypes.NpgsqlPoint(x: 0.760141423530429d, y: 0.03342772638044511d), new NpgsqlTypes.NpgsqlPoint(x: 0.275645255071426d, y: 0.8046108838415107d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4917563225712217d, y: 0.7356528436716069d), new NpgsqlTypes.NpgsqlPoint(x: 0.5574815727998313d, y: 0.3373274678149747d), new NpgsqlTypes.NpgsqlPoint(x: 0.21772887257142293d, y: 0.5363860712585835d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.733490869893402d, y: 0.9951530186176378d), new NpgsqlTypes.NpgsqlPoint(x: 0.592417695818379d, y: 0.4708469842125558d), new NpgsqlTypes.NpgsqlPoint(x: 0.5114456080827088d, y: 0.6660942105386896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2031925976484723d, y: 0.600182225865068d), new NpgsqlTypes.NpgsqlPoint(x: 0.6655429400731232d, y: 0.7655993298625461d), new NpgsqlTypes.NpgsqlPoint(x: 0.008874317796543685d, y: 0.9072238773787111d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3352036991162932d, y: 0.3215784910108265d), new NpgsqlTypes.NpgsqlPoint(x: 0.4842616833595398d, y: 0.5801946619072352d), new NpgsqlTypes.NpgsqlPoint(x: 0.3273303354066327d, y: 0.18502813896128723d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6362474450322164d, y: 0.6940664540195968d), new NpgsqlTypes.NpgsqlPoint(x: 0.8757430560868397d, y: 0.3855782602938541d), new NpgsqlTypes.NpgsqlPoint(x: 0.17400468104119393d, y: 0.548793161388176d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01701424875202806d, y: 0.7341338114786107d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166684953657921d, y: 0.046048796219044674d), new NpgsqlTypes.NpgsqlPoint(x: 0.9570990068110539d, y: 0.18767736984792494d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37184695213598473d, y: 0.3014843739379346d), new NpgsqlTypes.NpgsqlPoint(x: 0.053222054514026285d, y: 0.6959060364421522d), new NpgsqlTypes.NpgsqlPoint(x: 0.7845427643811109d, y: 0.3388786534066405d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010872201974341134d, y: 0.3122406775144011d), new NpgsqlTypes.NpgsqlPoint(x: 0.09266937222276161d, y: 0.40740355677811046d), new NpgsqlTypes.NpgsqlPoint(x: 0.9396226108082415d, y: 0.7165433924292643d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20153162166379646d, y: 0.03824291430940696d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560327063778221d, y: 0.4002784642756074d), new NpgsqlTypes.NpgsqlPoint(x: 0.14316320257880688d, y: 0.2999794039569834d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21069487431296963d, y: 0.5176077604557984d), new NpgsqlTypes.NpgsqlPoint(x: 0.16585104786927374d, y: 0.9696761412516273d), new NpgsqlTypes.NpgsqlPoint(x: 0.25028378704819576d, y: 0.2367662980694799d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8476476194885693d, y: 0.4223520946611453d), new NpgsqlTypes.NpgsqlPoint(x: 0.4505714533911508d, y: 0.02559864315760163d), new NpgsqlTypes.NpgsqlPoint(x: 0.8692816710415338d, y: 0.40415702513204643d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3433486317610157d, y: 0.1386669038298467d), new NpgsqlTypes.NpgsqlPoint(x: 0.9952292263232271d, y: 0.1861632859283373d), new NpgsqlTypes.NpgsqlPoint(x: 0.7739893257279317d, y: 0.8192392663597654d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7001327167188495d, y: 0.6591010105650897d), new NpgsqlTypes.NpgsqlPoint(x: 0.7365450017413001d, y: 0.9913812278664702d), new NpgsqlTypes.NpgsqlPoint(x: 0.08259482505356674d, y: 0.7796333243563771d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36869989861320873d, y: 0.5511486929955769d), new NpgsqlTypes.NpgsqlPoint(x: 0.7945525821780334d, y: 0.5831736497601382d), new NpgsqlTypes.NpgsqlPoint(x: 0.7086911148158332d, y: 0.3135829704028823d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34228929915758965d, y: 0.28524190280381145d), new NpgsqlTypes.NpgsqlPoint(x: 0.6061105770309995d, y: 0.645204205100399d), new NpgsqlTypes.NpgsqlPoint(x: 0.4582979332326469d, y: 0.6870369857853329d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16684523317339373d, y: 0.5838205326080484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5420296438870588d, y: 0.6139012064938378d), new NpgsqlTypes.NpgsqlPoint(x: 0.8115050688374145d, y: 0.40738569551751036d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24932026068745883d, y: 0.012576110354633241d), new NpgsqlTypes.NpgsqlPoint(x: 0.7551615446874733d, y: 0.04513212505953046d), new NpgsqlTypes.NpgsqlPoint(x: 0.42416620996810905d, y: 0.01729724293029955d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5914902620244092d, y: 0.8509266637058961d), new NpgsqlTypes.NpgsqlPoint(x: 0.28873106944323035d, y: 0.17202924899568262d), new NpgsqlTypes.NpgsqlPoint(x: 0.0018953473737223225d, y: 0.7330629633462671d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35265569256805007d, y: 0.5155459288441441d), new NpgsqlTypes.NpgsqlPoint(x: 0.9528675337423332d, y: 0.15236809761573977d), new NpgsqlTypes.NpgsqlPoint(x: 0.43295396268294617d, y: 0.7976220155754956d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8396235910272575d, y: 0.550385952231938d), new NpgsqlTypes.NpgsqlPoint(x: 0.6260292446612391d, y: 0.6742505155344808d), new NpgsqlTypes.NpgsqlPoint(x: 0.21835380632692925d, y: 0.17750109679780357d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4773182319918433d, y: 0.004412406861335039d), new NpgsqlTypes.NpgsqlPoint(x: 0.8694718556475369d, y: 0.7630049527938092d), new NpgsqlTypes.NpgsqlPoint(x: 0.1690534556964559d, y: 0.43584082517943656d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8805639464305081d, y: 0.5906498986743971d), new NpgsqlTypes.NpgsqlPoint(x: 0.7355052587717675d, y: 0.4590952882059147d), new NpgsqlTypes.NpgsqlPoint(x: 0.8853008746649293d, y: 0.5132412519335602d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8681151224574138d, y: 0.7518777208061285d), new NpgsqlTypes.NpgsqlPoint(x: 0.18153320213008406d, y: 0.4003785343915759d), new NpgsqlTypes.NpgsqlPoint(x: 0.3435772570078115d, y: 0.9277330590133159d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9583240488305546d, y: 0.646669314452663d), new NpgsqlTypes.NpgsqlPoint(x: 0.4969159608005943d, y: 0.3188196695240485d), new NpgsqlTypes.NpgsqlPoint(x: 0.5213168256990144d, y: 0.32153672958957713d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4626926819152428d, y: 0.2795034966095702d), new NpgsqlTypes.NpgsqlPoint(x: 0.8566244310551014d, y: 0.8574198486874535d), new NpgsqlTypes.NpgsqlPoint(x: 0.4356407267102391d, y: 0.6736978683161098d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8857504170500707d, y: 0.27021503769192945d), new NpgsqlTypes.NpgsqlPoint(x: 0.5265994054127756d, y: 0.7866032020413417d), new NpgsqlTypes.NpgsqlPoint(x: 0.6204731763572475d, y: 0.2612085987256716d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.767107576386236d, y: 0.620341208677292d), new NpgsqlTypes.NpgsqlPoint(x: 0.34003938611896223d, y: 0.3493140268061684d), new NpgsqlTypes.NpgsqlPoint(x: 0.8407505802925187d, y: 0.29827936099661667d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6896000150857664d, y: 0.06586963522429079d), new NpgsqlTypes.NpgsqlPoint(x: 0.1494977487937933d, y: 0.28405558891055316d), new NpgsqlTypes.NpgsqlPoint(x: 0.8416402908646611d, y: 0.5331680192220518d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3216355369255597d, y: 0.25567416221517625d), new NpgsqlTypes.NpgsqlPoint(x: 0.5677909212071307d, y: 0.6995881778864798d), new NpgsqlTypes.NpgsqlPoint(x: 0.26219370120131047d, y: 0.7999940793540581d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7839317258980595d, y: 0.7531738400736077d), new NpgsqlTypes.NpgsqlPoint(x: 0.5461051188830764d, y: 0.47966749282986754d), new NpgsqlTypes.NpgsqlPoint(x: 0.6873685395777953d, y: 0.37490648276055405d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35083320181521516d, y: 0.4290276106368025d), new NpgsqlTypes.NpgsqlPoint(x: 0.6798391968853594d, y: 0.2334681582498902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6194986475688926d, y: 0.06219610810342213d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8154172407443925d, y: 0.4051870616628649d), new NpgsqlTypes.NpgsqlPoint(x: 0.5303462821428577d, y: 0.17206989821799445d), new NpgsqlTypes.NpgsqlPoint(x: 0.5304624387566601d, y: 0.48945588370955917d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019113021620667192d, y: 0.063561904854197d), new NpgsqlTypes.NpgsqlPoint(x: 0.5101027488414036d, y: 0.12290966055383779d), new NpgsqlTypes.NpgsqlPoint(x: 0.6071317132566849d, y: 0.9340925975162198d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.728295704130131d, y: 0.7085650514777405d), new NpgsqlTypes.NpgsqlPoint(x: 0.5702318254919222d, y: 0.6145129942691979d), new NpgsqlTypes.NpgsqlPoint(x: 0.013151312092537282d, y: 0.6104396188675083d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6375275027513783d, y: 0.07863821265008353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9185976935607858d, y: 0.6916259338828625d), new NpgsqlTypes.NpgsqlPoint(x: 0.870829429339571d, y: 0.3253062804774951d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9080725415199277d, y: 0.24546942210693679d), new NpgsqlTypes.NpgsqlPoint(x: 0.9726707088121523d, y: 0.14621388139540314d), new NpgsqlTypes.NpgsqlPoint(x: 0.9041795605760802d, y: 0.8674076517828684d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19737069869681612d, y: 0.9352792753389054d), new NpgsqlTypes.NpgsqlPoint(x: 0.8847924738222896d, y: 0.1673508415459838d), new NpgsqlTypes.NpgsqlPoint(x: 0.997912881742283d, y: 0.19091372838145781d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09470776320378704d, y: 0.7858627580711651d), new NpgsqlTypes.NpgsqlPoint(x: 0.30937839561885083d, y: 0.3875257896834502d), new NpgsqlTypes.NpgsqlPoint(x: 0.9363110295009154d, y: 0.7856240555674381d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8073827880913156d, y: 0.5786064393018538d), new NpgsqlTypes.NpgsqlPoint(x: 0.9523449722111343d, y: 0.250685870665466d), new NpgsqlTypes.NpgsqlPoint(x: 0.556858274591501d, y: 0.5622463856277006d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21746543685776487d, y: 0.7597397805932845d), new NpgsqlTypes.NpgsqlPoint(x: 0.8896925227014654d, y: 0.6841466593936922d), new NpgsqlTypes.NpgsqlPoint(x: 0.5498339112863918d, y: 0.5961540848288424d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7229788242645196d, y: 0.96896312253823d), new NpgsqlTypes.NpgsqlPoint(x: 0.7442890112463582d, y: 0.9134949156174735d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205899133248087d, y: 0.6714476241217276d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1343151579890699d, y: 0.22054319074172235d), new NpgsqlTypes.NpgsqlPoint(x: 0.3361425268533643d, y: 0.6268083614800003d), new NpgsqlTypes.NpgsqlPoint(x: 0.32449903766371546d, y: 0.36061081914135273d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5350670593096938d, y: 0.010427410926270975d), new NpgsqlTypes.NpgsqlPoint(x: 0.06925016302663001d, y: 0.266235189453226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6778493491309244d, y: 0.6129645849832924d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25982665092735013d, y: 0.07904920997471876d), new NpgsqlTypes.NpgsqlPoint(x: 0.05801733201732995d, y: 0.641069630459998d), new NpgsqlTypes.NpgsqlPoint(x: 0.27215844953421586d, y: 0.4232971500671625d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7377592256829343d, y: 0.7129895006360376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5264731916237886d, y: 0.5799692411762637d), new NpgsqlTypes.NpgsqlPoint(x: 0.8961476474579682d, y: 0.8652560533628885d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01181064082264116d, y: 0.5624269050794726d), new NpgsqlTypes.NpgsqlPoint(x: 0.8313520288364625d, y: 0.7773385688472916d), new NpgsqlTypes.NpgsqlPoint(x: 0.7514957901792654d, y: 0.7435271192987429d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22570946769101596d, y: 0.7997651945523397d), new NpgsqlTypes.NpgsqlPoint(x: 0.139146757425881d, y: 0.8214812307587069d), new NpgsqlTypes.NpgsqlPoint(x: 0.9984008116973603d, y: 0.5115543209635219d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.453921103029749d, y: 0.21584264295387712d), new NpgsqlTypes.NpgsqlPoint(x: 0.5524986688738133d, y: 0.45266192963803564d), new NpgsqlTypes.NpgsqlPoint(x: 0.1294197747773861d, y: 0.8678264923307601d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29579610839807535d, y: 0.27465733947278925d), new NpgsqlTypes.NpgsqlPoint(x: 0.2008007553818738d, y: 0.19529821209781584d), new NpgsqlTypes.NpgsqlPoint(x: 0.39129042435467076d, y: 0.3738252648054109d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5711296273516693d, y: 0.8312638829858853d), new NpgsqlTypes.NpgsqlPoint(x: 0.20448640567944532d, y: 0.26344398884319353d), new NpgsqlTypes.NpgsqlPoint(x: 0.17637350220614367d, y: 0.28351211434627044d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9857083140910545d, y: 0.7957659950745609d), new NpgsqlTypes.NpgsqlPoint(x: 0.052636536736050066d, y: 0.5769318287345657d), new NpgsqlTypes.NpgsqlPoint(x: 0.8827459676185471d, y: 0.23247523654379698d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.720138963579585d, y: 0.20490689442443122d), new NpgsqlTypes.NpgsqlPoint(x: 0.29731935593711956d, y: 0.4339878721822673d), new NpgsqlTypes.NpgsqlPoint(x: 0.7131545830414942d, y: 0.15838141541354034d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9679242501969513d, y: 0.2613725611232163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9645714506680296d, y: 0.3269004748112919d), new NpgsqlTypes.NpgsqlPoint(x: 0.4156219764307598d, y: 0.6577844403118631d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.032904869245879764d, y: 0.8522154643007024d), new NpgsqlTypes.NpgsqlPoint(x: 0.6473131624933257d, y: 0.43041128530329886d), new NpgsqlTypes.NpgsqlPoint(x: 0.8048664149614951d, y: 0.48440976423188853d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6763594814195427d, y: 0.8594380397816176d), new NpgsqlTypes.NpgsqlPoint(x: 0.2831651425185646d, y: 0.4047507651810621d), new NpgsqlTypes.NpgsqlPoint(x: 0.32355043524212446d, y: 0.43294652947167067d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9924427561350758d, y: 0.032014820906904884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9961354560779238d, y: 0.9104512839204958d), new NpgsqlTypes.NpgsqlPoint(x: 0.060978010014774875d, y: 0.0870996964287506d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7062043097312668d, y: 0.6563626941358589d), new NpgsqlTypes.NpgsqlPoint(x: 0.27068716396038606d, y: 0.9721178518137416d), new NpgsqlTypes.NpgsqlPoint(x: 0.27672938180735207d, y: 0.049738402566893436d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4200280613942762d, y: 0.9286133768529236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3317683544403882d, y: 0.6378703001189238d), new NpgsqlTypes.NpgsqlPoint(x: 0.23011933083058023d, y: 0.5318982001200876d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5391772350816716d, y: 0.19423360675971568d), new NpgsqlTypes.NpgsqlPoint(x: 0.43516126073073236d, y: 0.08597733363637028d), new NpgsqlTypes.NpgsqlPoint(x: 0.9644698183718158d, y: 0.7837478121950262d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8881611464999335d, y: 0.07307907611936015d), new NpgsqlTypes.NpgsqlPoint(x: 0.9831554888076555d, y: 0.18703205776614595d), new NpgsqlTypes.NpgsqlPoint(x: 0.6681499398900307d, y: 0.6660856867745991d)),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6685181808679643d, y: 0.8066613949632405d), new NpgsqlTypes.NpgsqlPoint(x: 0.813379350273635d, y: 0.8840925562848869d), new NpgsqlTypes.NpgsqlPoint(x: 0.1422260844830946d, y: 0.13687215135813602d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20491294272784755d, y: 0.1637143715075362d), new NpgsqlTypes.NpgsqlPoint(x: 0.10357412544516853d, y: 0.7763099324161223d), new NpgsqlTypes.NpgsqlPoint(x: 0.17244230116933146d, y: 0.07353796833958348d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7365200403173988d, y: 0.2328163509498501d), new NpgsqlTypes.NpgsqlPoint(x: 0.057553783556261506d, y: 0.26154222463732524d), new NpgsqlTypes.NpgsqlPoint(x: 0.978750920713341d, y: 0.6746948359305972d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35130549272752465d, y: 0.594814077598571d), new NpgsqlTypes.NpgsqlPoint(x: 0.7508451983126222d, y: 0.5403468913754648d), new NpgsqlTypes.NpgsqlPoint(x: 0.42345522502380484d, y: 0.9969855790546587d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23248319861937305d, y: 0.43151278316067543d), new NpgsqlTypes.NpgsqlPoint(x: 0.2727016408546037d, y: 0.17341500544716792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9843042677814337d, y: 0.5442200439955428d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8550538629209126d, y: 0.9370502389266303d), new NpgsqlTypes.NpgsqlPoint(x: 0.6982024772078854d, y: 0.0029999565691153363d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534635114870948d, y: 0.3264838590910233d)),
}));
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 135;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 117, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 121, query1, 104, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 97, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 1, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 97, query1, 104, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 31, query1, 120, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 105, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 31, query1, 121, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 152, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 129, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[29], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 17);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[29], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[30], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[31], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[32], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[33], false);
                NpgsqlPathpathArray1M.AssertModel(models[30],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI), typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                await ((INpgsqlPathArraypathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                ((INpgsqlPathArraypathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathArraypathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

