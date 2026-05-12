

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
    internal partial interface INpgsqlPathMArraypathMMArrayD2
    {
    }
    
    internal partial class NpgsqlPathMArraypathMMArrayD2 : INpgsqlPathMArraypathMMArrayD2
    {


#region TestData

        private readonly NpgsqlPathpathMMArrayD2E1M[] _testData = new NpgsqlPathpathMMArrayD2E1M[]
        {
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07950337748814473d, y: 0.18641443900111299d), new NpgsqlTypes.NpgsqlPoint(x: 0.13668833245963885d, y: 0.2176466519892949d), new NpgsqlTypes.NpgsqlPoint(x: 0.015505247831088087d, y: 0.9777261485649823d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18465340013299558d, y: 0.5802316815210564d), new NpgsqlTypes.NpgsqlPoint(x: 0.8921070757766218d, y: 0.7732430202778767d), new NpgsqlTypes.NpgsqlPoint(x: 0.2756830113951618d, y: 0.920045507984873d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.512250665013595d, y: 0.01044220375492444d), new NpgsqlTypes.NpgsqlPoint(x: 0.9205370288016854d, y: 0.811502183578363d), new NpgsqlTypes.NpgsqlPoint(x: 0.03331453960004571d, y: 0.546917595781468d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35164862217942283d, y: 0.39273531897210456d), new NpgsqlTypes.NpgsqlPoint(x: 0.331478702344184d, y: 0.33636195163332594d), new NpgsqlTypes.NpgsqlPoint(x: 0.7054886116390269d, y: 0.736602208794687d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40299597940016263d, y: 0.5951034684725592d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428087117803389d, y: 0.7006994883830507d), new NpgsqlTypes.NpgsqlPoint(x: 0.14271835353148998d, y: 0.21775373294851597d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6764693800594134d, y: 0.1544126411425909d), new NpgsqlTypes.NpgsqlPoint(x: 0.12454178354223167d, y: 0.7706615973955206d), new NpgsqlTypes.NpgsqlPoint(x: 0.6103441937673656d, y: 0.7621621903105144d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6295174038190247d, y: 0.22850801941514254d), new NpgsqlTypes.NpgsqlPoint(x: 0.051732037720114143d, y: 0.998863602464319d), new NpgsqlTypes.NpgsqlPoint(x: 0.26674555364699004d, y: 0.6217592047719023d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07613836040116528d, y: 0.8744110331915435d), new NpgsqlTypes.NpgsqlPoint(x: 0.609152025381961d, y: 0.10578303740986761d), new NpgsqlTypes.NpgsqlPoint(x: 0.9474717758222486d, y: 0.6693809432347068d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2385511591590379d, y: 0.08020550972896778d), new NpgsqlTypes.NpgsqlPoint(x: 0.9750876553586584d, y: 0.3074033489831336d), new NpgsqlTypes.NpgsqlPoint(x: 0.8860644199009425d, y: 0.518281329332742d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6958499790341622d, y: 0.5246785802429101d), new NpgsqlTypes.NpgsqlPoint(x: 0.4466128253184485d, y: 0.877505274720832d), new NpgsqlTypes.NpgsqlPoint(x: 0.20914525290748864d, y: 0.24559705580323588d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1797847293868272d, y: 0.7455041222040967d), new NpgsqlTypes.NpgsqlPoint(x: 0.19582159896400397d, y: 0.7692031939353926d), new NpgsqlTypes.NpgsqlPoint(x: 0.07378726067137864d, y: 0.7646235823531902d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4164396273300931d, y: 0.3351222116489081d), new NpgsqlTypes.NpgsqlPoint(x: 0.10192503076249337d, y: 0.7683776439575286d), new NpgsqlTypes.NpgsqlPoint(x: 0.45203237132976837d, y: 0.8629979381565452d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1988067813856499d, y: 0.32962419396387077d), new NpgsqlTypes.NpgsqlPoint(x: 0.055803871838067676d, y: 0.6450035955279473d), new NpgsqlTypes.NpgsqlPoint(x: 0.7854832927689096d, y: 0.9398975104375462d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9927506955778889d, y: 0.6334603978072868d), new NpgsqlTypes.NpgsqlPoint(x: 0.10044453914310192d, y: 0.35162564435036714d), new NpgsqlTypes.NpgsqlPoint(x: 0.2363331570963949d, y: 0.8309918743390611d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5383529538498971d, y: 0.2122699094276651d), new NpgsqlTypes.NpgsqlPoint(x: 0.2638564396615829d, y: 0.11835324644403544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8716037506526043d, y: 0.8453280953097607d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.717305617019285d, y: 0.8919851260424233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5417993055253364d, y: 0.33085912428578645d), new NpgsqlTypes.NpgsqlPoint(x: 0.5713692608555959d, y: 0.2936417062929727d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.531184294416478d, y: 0.12119627167089642d), new NpgsqlTypes.NpgsqlPoint(x: 0.6818350921601875d, y: 0.014243821997675932d), new NpgsqlTypes.NpgsqlPoint(x: 0.24539909614601796d, y: 0.9704327415311511d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23888465739829423d, y: 0.7022472614611067d), new NpgsqlTypes.NpgsqlPoint(x: 0.6949894312089065d, y: 0.21050444886017727d), new NpgsqlTypes.NpgsqlPoint(x: 0.09919744234258876d, y: 0.2472384938161558d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6303338103055428d, y: 0.4575527654114847d), new NpgsqlTypes.NpgsqlPoint(x: 0.43646012323433103d, y: 0.29109040734619107d), new NpgsqlTypes.NpgsqlPoint(x: 0.5205989492660977d, y: 0.7621701501802003d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27781646448913655d, y: 0.38494758608763535d), new NpgsqlTypes.NpgsqlPoint(x: 0.38838262045396277d, y: 0.15921760479537728d), new NpgsqlTypes.NpgsqlPoint(x: 0.7672853931264249d, y: 0.07388782352007739d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5817123538344747d, y: 0.6562804789713751d), new NpgsqlTypes.NpgsqlPoint(x: 0.027014742718293405d, y: 0.5317742239049965d), new NpgsqlTypes.NpgsqlPoint(x: 0.9899379994222115d, y: 0.4262427073070931d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36732685587873704d, y: 0.007623469820940865d), new NpgsqlTypes.NpgsqlPoint(x: 0.30798609140700395d, y: 0.44726121643469785d), new NpgsqlTypes.NpgsqlPoint(x: 0.19659494832820135d, y: 0.0059526635495259494d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8466722868452435d, y: 0.2519839775919037d), new NpgsqlTypes.NpgsqlPoint(x: 0.16145602918896274d, y: 0.7557071111474077d), new NpgsqlTypes.NpgsqlPoint(x: 0.13501774232760388d, y: 0.19129046515633452d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9707951125570818d, y: 0.8186947284712068d), new NpgsqlTypes.NpgsqlPoint(x: 0.18850689477645077d, y: 0.7729412450707601d), new NpgsqlTypes.NpgsqlPoint(x: 0.3150636880892801d, y: 0.3496720623873725d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7272811815305704d, y: 0.8816069377093111d), new NpgsqlTypes.NpgsqlPoint(x: 0.14757333792802063d, y: 0.8012590373452548d), new NpgsqlTypes.NpgsqlPoint(x: 0.19680406769366166d, y: 0.5348232397040543d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5149004423077415d, y: 0.3551632920550406d), new NpgsqlTypes.NpgsqlPoint(x: 0.06961069813616672d, y: 0.6604923715142005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5537437312043214d, y: 0.4509951782117556d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.049027896117440184d, y: 0.4517542538927344d), new NpgsqlTypes.NpgsqlPoint(x: 0.4990900800772352d, y: 0.021403474343388518d), new NpgsqlTypes.NpgsqlPoint(x: 0.49520409154886735d, y: 0.5257517180896759d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4788063507622826d, y: 0.8192113573891338d), new NpgsqlTypes.NpgsqlPoint(x: 0.4078394759050624d, y: 0.46894266401571705d), new NpgsqlTypes.NpgsqlPoint(x: 0.10638923423381919d, y: 0.3758239597489377d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24084460505881d, y: 0.18901641219482312d), new NpgsqlTypes.NpgsqlPoint(x: 0.4461410260438635d, y: 0.9602746851233455d), new NpgsqlTypes.NpgsqlPoint(x: 0.24358452451638068d, y: 0.6434919260009205d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6074111713613055d, y: 0.4533317509793272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5232717302739963d, y: 0.9765718171621357d), new NpgsqlTypes.NpgsqlPoint(x: 0.3417056101122993d, y: 0.04825320031980418d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.523142370233452d, y: 0.41599646381759825d), new NpgsqlTypes.NpgsqlPoint(x: 0.8292312644696571d, y: 0.7201165331744481d), new NpgsqlTypes.NpgsqlPoint(x: 0.7780499802842127d, y: 0.526606623422632d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49975026179600013d, y: 0.4989492393480318d), new NpgsqlTypes.NpgsqlPoint(x: 0.45218426698269343d, y: 0.1174754369060168d), new NpgsqlTypes.NpgsqlPoint(x: 0.21351850444802156d, y: 0.16383280241964449d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8899071706281011d, y: 0.3569849966546872d), new NpgsqlTypes.NpgsqlPoint(x: 0.8881643174487633d, y: 0.24968886071081398d), new NpgsqlTypes.NpgsqlPoint(x: 0.004096768692773978d, y: 0.21984144175086706d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9121565811167842d, y: 0.2606895573151853d), new NpgsqlTypes.NpgsqlPoint(x: 0.434400573349522d, y: 0.6845677310554891d), new NpgsqlTypes.NpgsqlPoint(x: 0.9216757265510069d, y: 0.9436357575647603d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7226746835744912d, y: 0.7152595658509022d), new NpgsqlTypes.NpgsqlPoint(x: 0.17220253272816166d, y: 0.14418901123378092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8470960796716412d, y: 0.6249676733987644d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8011521568867417d, y: 0.9929567826490944d), new NpgsqlTypes.NpgsqlPoint(x: 0.7253488162102403d, y: 0.5281885815844698d), new NpgsqlTypes.NpgsqlPoint(x: 0.18376639593739663d, y: 0.6765516352986661d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09386714294663911d, y: 0.04822451537150707d), new NpgsqlTypes.NpgsqlPoint(x: 0.6486538299108999d, y: 0.382124126341591d), new NpgsqlTypes.NpgsqlPoint(x: 0.6966560938270576d, y: 0.06502302088267142d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31517649355580946d, y: 0.5546663523182104d), new NpgsqlTypes.NpgsqlPoint(x: 0.6384704083655457d, y: 0.9961277947482585d), new NpgsqlTypes.NpgsqlPoint(x: 0.9777559323147743d, y: 0.03066022985150052d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5459063786062022d, y: 0.0049821582252416174d), new NpgsqlTypes.NpgsqlPoint(x: 0.11955902393274842d, y: 0.9922613669650172d), new NpgsqlTypes.NpgsqlPoint(x: 0.47156020391374687d, y: 0.38752826490627146d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07662603446106186d, y: 0.07031708776096701d), new NpgsqlTypes.NpgsqlPoint(x: 0.044894379516063676d, y: 0.5308632016699713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9116856985174643d, y: 0.3279180379080723d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36041887853424737d, y: 0.3430222537205634d), new NpgsqlTypes.NpgsqlPoint(x: 0.711225449116874d, y: 0.19768786933044347d), new NpgsqlTypes.NpgsqlPoint(x: 0.05800923005839553d, y: 0.6704545440323483d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9530955468170014d, y: 0.6535307886569027d), new NpgsqlTypes.NpgsqlPoint(x: 0.07305953531424358d, y: 0.046872318270678504d), new NpgsqlTypes.NpgsqlPoint(x: 0.10393018008995414d, y: 0.32572191104805115d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38372096998441496d, y: 0.30282796789304445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9810866297015236d, y: 0.30611096192981313d), new NpgsqlTypes.NpgsqlPoint(x: 0.1135641559647873d, y: 0.5114683631094646d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21313872766334485d, y: 0.7174400387793036d), new NpgsqlTypes.NpgsqlPoint(x: 0.48969236755075163d, y: 0.5501470236580093d), new NpgsqlTypes.NpgsqlPoint(x: 0.08537696214344326d, y: 0.6847319672111247d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6140184701012007d, y: 0.07615387875914448d), new NpgsqlTypes.NpgsqlPoint(x: 0.6809834229821571d, y: 0.5567178873689226d), new NpgsqlTypes.NpgsqlPoint(x: 0.19029317347004693d, y: 0.8280603921691463d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01599433097554659d, y: 0.6171283431030417d), new NpgsqlTypes.NpgsqlPoint(x: 0.3376862526704174d, y: 0.8675669347059839d), new NpgsqlTypes.NpgsqlPoint(x: 0.59592063472713d, y: 0.4862387111992975d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3120903543575937d, y: 0.6474853305879574d), new NpgsqlTypes.NpgsqlPoint(x: 0.7738516159055264d, y: 0.7945675388705146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8369341093753785d, y: 0.2660780973160799d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8850505530813674d, y: 0.7533936275259034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8879842497543167d, y: 0.6998169562809861d), new NpgsqlTypes.NpgsqlPoint(x: 0.5775501291943577d, y: 0.08547199229313684d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028983406952175828d, y: 0.5859989949609133d), new NpgsqlTypes.NpgsqlPoint(x: 0.7771936557719211d, y: 0.1240797057116334d), new NpgsqlTypes.NpgsqlPoint(x: 0.5164193823393183d, y: 0.6639121924362962d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37980156109191476d, y: 0.007893658011322024d), new NpgsqlTypes.NpgsqlPoint(x: 0.2102056714168924d, y: 0.4496031564980616d), new NpgsqlTypes.NpgsqlPoint(x: 0.6966644770784725d, y: 0.19357097044838079d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31513729114593736d, y: 0.42198763612550694d), new NpgsqlTypes.NpgsqlPoint(x: 0.5247158609883351d, y: 0.4800607856174599d), new NpgsqlTypes.NpgsqlPoint(x: 0.9897493395407786d, y: 0.7793994876318016d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9645969923382017d, y: 0.700620967499354d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805673544455183d, y: 0.07414907900155498d), new NpgsqlTypes.NpgsqlPoint(x: 0.5295207216283985d, y: 0.28332490266070254d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02777869106668962d, y: 0.6190131184380548d), new NpgsqlTypes.NpgsqlPoint(x: 0.3987138364703945d, y: 0.15654997420057903d), new NpgsqlTypes.NpgsqlPoint(x: 0.5070610939117584d, y: 0.28845056457283846d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41542263219514464d, y: 0.09342537220791036d), new NpgsqlTypes.NpgsqlPoint(x: 0.33289773185537186d, y: 0.5856956450039189d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410908420414338d, y: 0.45400963865633437d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3126228233158045d, y: 0.47760008248149866d), new NpgsqlTypes.NpgsqlPoint(x: 0.08435925629592989d, y: 0.20042929604102278d), new NpgsqlTypes.NpgsqlPoint(x: 0.859682182412861d, y: 0.46933719723306344d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30053237958915924d, y: 0.430722869700885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5394233619202163d, y: 0.5303307613679747d), new NpgsqlTypes.NpgsqlPoint(x: 0.5757200867006617d, y: 0.17625888996228145d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6066148633695034d, y: 0.5459192344219373d), new NpgsqlTypes.NpgsqlPoint(x: 0.08808712143969577d, y: 0.24619401240577266d), new NpgsqlTypes.NpgsqlPoint(x: 0.4593405401965066d, y: 0.9998793908657666d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5601251318410595d, y: 0.4052220152017084d), new NpgsqlTypes.NpgsqlPoint(x: 0.4140151458379664d, y: 0.725736414291862d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420992878353339d, y: 0.6437407670095027d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.533896626190639d, y: 0.8182287564215566d), new NpgsqlTypes.NpgsqlPoint(x: 0.9668900669990103d, y: 0.34652270407448815d), new NpgsqlTypes.NpgsqlPoint(x: 0.07265589105079928d, y: 0.5634547720148576d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7712590687446541d, y: 0.7768682378852471d), new NpgsqlTypes.NpgsqlPoint(x: 0.39138044620174295d, y: 0.9702091534132452d), new NpgsqlTypes.NpgsqlPoint(x: 0.8453005769910251d, y: 0.8123224119431668d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6941684905033004d, y: 0.9574539305777525d), new NpgsqlTypes.NpgsqlPoint(x: 0.149540084215382d, y: 0.6884643170710887d), new NpgsqlTypes.NpgsqlPoint(x: 0.8253931638206992d, y: 0.8200311464209515d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9107666139847479d, y: 0.9702430819900185d), new NpgsqlTypes.NpgsqlPoint(x: 0.4310439477989727d, y: 0.9925880034625888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8071148357558745d, y: 0.930741319181926d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23270993606526558d, y: 0.9021583437071489d), new NpgsqlTypes.NpgsqlPoint(x: 0.14201895594258818d, y: 0.3174778125738382d), new NpgsqlTypes.NpgsqlPoint(x: 0.0376223640597142d, y: 0.49260497621459753d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9958424159281869d, y: 0.45799761732742184d), new NpgsqlTypes.NpgsqlPoint(x: 0.2785635582259819d, y: 0.01571890622295047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5165909799442392d, y: 0.13455596488939525d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8700664337847464d, y: 0.02816694150025545d), new NpgsqlTypes.NpgsqlPoint(x: 0.08717578492710631d, y: 0.757451409975864d), new NpgsqlTypes.NpgsqlPoint(x: 0.9879543039513009d, y: 0.9759416148449531d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9378291286215333d, y: 0.3834219740320378d), new NpgsqlTypes.NpgsqlPoint(x: 0.2574689673164834d, y: 0.4554925832788874d), new NpgsqlTypes.NpgsqlPoint(x: 0.3102085704075682d, y: 0.8057343689840585d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.652466967935453d, y: 0.37601343039217905d), new NpgsqlTypes.NpgsqlPoint(x: 0.09121551951153684d, y: 0.7037835851571115d), new NpgsqlTypes.NpgsqlPoint(x: 0.20822467388565802d, y: 0.9875739899404323d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24478811510187448d, y: 0.5496676190167203d), new NpgsqlTypes.NpgsqlPoint(x: 0.20164505199690985d, y: 0.40249682569811096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9426541403791177d, y: 0.8455594748276833d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9456168507899707d, y: 0.9916462622036549d), new NpgsqlTypes.NpgsqlPoint(x: 0.1996285767795678d, y: 0.1385376384811008d), new NpgsqlTypes.NpgsqlPoint(x: 0.6330732795168115d, y: 0.5970263996960204d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5171704540601761d, y: 0.4269296834300358d), new NpgsqlTypes.NpgsqlPoint(x: 0.23352672227128424d, y: 0.34932098502272546d), new NpgsqlTypes.NpgsqlPoint(x: 0.3191342371512438d, y: 0.057782854893537405d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3391941123262735d, y: 0.37477368864658445d), new NpgsqlTypes.NpgsqlPoint(x: 0.020559603541398297d, y: 0.8785401363240991d), new NpgsqlTypes.NpgsqlPoint(x: 0.588119996211893d, y: 0.6313389884067684d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.627294617415814d, y: 0.12472419448744165d), new NpgsqlTypes.NpgsqlPoint(x: 0.2461483558085854d, y: 0.9933527499505227d), new NpgsqlTypes.NpgsqlPoint(x: 0.36778286453798137d, y: 0.5301371786307072d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8981399841952007d, y: 0.967998342254712d), new NpgsqlTypes.NpgsqlPoint(x: 0.5891233553417895d, y: 0.0464661704738607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8421063867101476d, y: 0.763932588091107d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5043650866243788d, y: 0.6809379125150374d), new NpgsqlTypes.NpgsqlPoint(x: 0.244245744022195d, y: 0.020548890843169354d), new NpgsqlTypes.NpgsqlPoint(x: 0.01613203745151892d, y: 0.9614964004355759d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20636655234026846d, y: 0.7950836521327954d), new NpgsqlTypes.NpgsqlPoint(x: 0.09550817155010649d, y: 0.7052157538054056d), new NpgsqlTypes.NpgsqlPoint(x: 0.3113362808178308d, y: 0.5968560699821466d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8441250262120661d, y: 0.7102494295093538d), new NpgsqlTypes.NpgsqlPoint(x: 0.8548900648459609d, y: 0.7782291704333847d), new NpgsqlTypes.NpgsqlPoint(x: 0.7109229451232656d, y: 0.7263778519713552d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42361809470263356d, y: 0.5319210282364124d), new NpgsqlTypes.NpgsqlPoint(x: 0.20056870682375394d, y: 0.26334062232247957d), new NpgsqlTypes.NpgsqlPoint(x: 0.1646320178941838d, y: 0.13914271309114d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00808658157186637d, y: 0.981935038106151d), new NpgsqlTypes.NpgsqlPoint(x: 0.192139462612544d, y: 0.0848469448950373d), new NpgsqlTypes.NpgsqlPoint(x: 0.754821897498532d, y: 0.27022471182207797d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9133281011504153d, y: 0.9335716645796414d), new NpgsqlTypes.NpgsqlPoint(x: 0.9685171973212249d, y: 0.673254262764401d), new NpgsqlTypes.NpgsqlPoint(x: 0.10836802966988479d, y: 0.648299186652393d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9071216855057277d, y: 0.8623515049443077d), new NpgsqlTypes.NpgsqlPoint(x: 0.7458540791036448d, y: 0.09008074032464608d), new NpgsqlTypes.NpgsqlPoint(x: 0.9735503476700357d, y: 0.364050178302748d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4437745953359251d, y: 0.7640113421411174d), new NpgsqlTypes.NpgsqlPoint(x: 0.42614673418725013d, y: 0.280664937305685d), new NpgsqlTypes.NpgsqlPoint(x: 0.4326940260710518d, y: 0.26451184450162635d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3984464700241013d, y: 0.41013223321341563d), new NpgsqlTypes.NpgsqlPoint(x: 0.09826861106218543d, y: 0.5559560372496505d), new NpgsqlTypes.NpgsqlPoint(x: 0.5999467862919242d, y: 0.5604882722599984d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2301855915933958d, y: 0.9199650458541372d), new NpgsqlTypes.NpgsqlPoint(x: 0.8387456218346361d, y: 0.8200146119326502d), new NpgsqlTypes.NpgsqlPoint(x: 0.250101675124352d, y: 0.11981324360122159d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7863626722939612d, y: 0.06015197018899532d), new NpgsqlTypes.NpgsqlPoint(x: 0.4203231484061015d, y: 0.619894797364546d), new NpgsqlTypes.NpgsqlPoint(x: 0.3650049644272986d, y: 0.29754295977601175d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.75796076354275d, y: 0.00891979339030724d), new NpgsqlTypes.NpgsqlPoint(x: 0.21639833978457867d, y: 0.2730967322877913d), new NpgsqlTypes.NpgsqlPoint(x: 0.2909190009901561d, y: 0.241158335448879d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8876368159279283d, y: 0.9811201076556229d), new NpgsqlTypes.NpgsqlPoint(x: 0.6480475433332339d, y: 0.031828460948671755d), new NpgsqlTypes.NpgsqlPoint(x: 0.9534355256265885d, y: 0.6961105930601198d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4435090516736975d, y: 0.11898009546139554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111937417623247d, y: 0.5517262042122395d), new NpgsqlTypes.NpgsqlPoint(x: 0.9227235907400706d, y: 0.21047268834465704d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5328555953819768d, y: 0.04866272845036268d), new NpgsqlTypes.NpgsqlPoint(x: 0.9894485410537492d, y: 0.2249621280724895d), new NpgsqlTypes.NpgsqlPoint(x: 0.8024388008522757d, y: 0.5475417611947755d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04067619775399023d, y: 0.10553118399857742d), new NpgsqlTypes.NpgsqlPoint(x: 0.25217709275427835d, y: 0.42468657115359365d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794312286945247d, y: 0.7191129422083926d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7952647523866738d, y: 0.44301873341263787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9200990889361969d, y: 0.5699926729176691d), new NpgsqlTypes.NpgsqlPoint(x: 0.4800886903938757d, y: 0.7849241453091251d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6831674735703624d, y: 0.34244728801399427d), new NpgsqlTypes.NpgsqlPoint(x: 0.44727203629144974d, y: 0.7293155255219971d), new NpgsqlTypes.NpgsqlPoint(x: 0.9544138481195599d, y: 0.8496312115071382d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2008466953567314d, y: 0.5764865159899666d), new NpgsqlTypes.NpgsqlPoint(x: 0.5046682607628781d, y: 0.8043866048827153d), new NpgsqlTypes.NpgsqlPoint(x: 0.610207267627571d, y: 0.7726246270189477d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4190429071889826d, y: 0.4776580308273827d), new NpgsqlTypes.NpgsqlPoint(x: 0.6337654099383544d, y: 0.9854370793085339d), new NpgsqlTypes.NpgsqlPoint(x: 0.9198456218981076d, y: 0.9957908885684591d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43006500341373544d, y: 0.021889438966291253d), new NpgsqlTypes.NpgsqlPoint(x: 0.36067652683110574d, y: 0.8168559210248331d), new NpgsqlTypes.NpgsqlPoint(x: 0.3510277273509145d, y: 0.8416932471018133d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2229649098181633d, y: 0.3936859290943674d), new NpgsqlTypes.NpgsqlPoint(x: 0.1687201881885909d, y: 0.747356359553931d), new NpgsqlTypes.NpgsqlPoint(x: 0.32889892438863d, y: 0.8490669192822415d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32705597933928654d, y: 0.8873237828609747d), new NpgsqlTypes.NpgsqlPoint(x: 0.4868767023362446d, y: 0.35401953587411183d), new NpgsqlTypes.NpgsqlPoint(x: 0.5297458338397254d, y: 0.781211168205684d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8311070376205115d, y: 0.4116975167244865d), new NpgsqlTypes.NpgsqlPoint(x: 0.971101704928987d, y: 0.42424613562532665d), new NpgsqlTypes.NpgsqlPoint(x: 0.9177580462804537d, y: 0.6667634947132669d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7849262970387941d, y: 0.690525596572479d), new NpgsqlTypes.NpgsqlPoint(x: 0.7382188790959437d, y: 0.31700081438700833d), new NpgsqlTypes.NpgsqlPoint(x: 0.005086357937683417d, y: 0.10389760655935165d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.686494004170244d, y: 0.7685511423162549d), new NpgsqlTypes.NpgsqlPoint(x: 0.224730430441758d, y: 0.9210040214523476d), new NpgsqlTypes.NpgsqlPoint(x: 0.7300919972421769d, y: 0.3044532008453491d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4065485452517166d, y: 0.6361096121593387d), new NpgsqlTypes.NpgsqlPoint(x: 0.46312613740526687d, y: 0.4478617470484221d), new NpgsqlTypes.NpgsqlPoint(x: 0.010321427300185815d, y: 0.7508057744358593d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4152581893159927d, y: 0.2651162788543182d), new NpgsqlTypes.NpgsqlPoint(x: 0.44234152134291427d, y: 0.969725338026851d), new NpgsqlTypes.NpgsqlPoint(x: 0.9829653562427645d, y: 0.49554281746303563d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5582594458381948d, y: 0.19466437671245806d), new NpgsqlTypes.NpgsqlPoint(x: 0.4533716631225525d, y: 0.03162809408181744d), new NpgsqlTypes.NpgsqlPoint(x: 0.6701655182822328d, y: 0.5798841166156058d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9355816259670499d, y: 0.1525845446051518d), new NpgsqlTypes.NpgsqlPoint(x: 0.5742784344310127d, y: 0.21563741074249165d), new NpgsqlTypes.NpgsqlPoint(x: 0.8296386921091345d, y: 0.6040077954739309d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8101225546991427d, y: 0.0807608330943439d), new NpgsqlTypes.NpgsqlPoint(x: 0.6641219936592151d, y: 0.5459116958300861d), new NpgsqlTypes.NpgsqlPoint(x: 0.21814852140319974d, y: 0.6037939052473316d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5935936788436256d, y: 0.06026129514124712d), new NpgsqlTypes.NpgsqlPoint(x: 0.34199944335735066d, y: 0.5534768347582207d), new NpgsqlTypes.NpgsqlPoint(x: 0.580566258902282d, y: 0.48192424694031133d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8060823762515439d, y: 0.1051710506497957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6190454053303615d, y: 0.07696104265811576d), new NpgsqlTypes.NpgsqlPoint(x: 0.5169202869907186d, y: 0.6274980985966543d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4684783075437837d, y: 0.7369953956365594d), new NpgsqlTypes.NpgsqlPoint(x: 0.3429227063300879d, y: 0.26961210676719916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6019034846516357d, y: 0.010264426350641953d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2398758687387641d, y: 0.6403142359414226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6080088118844158d, y: 0.38800091628601463d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348396848458602d, y: 0.606547023601123d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08972075600943352d, y: 0.9656284836502488d), new NpgsqlTypes.NpgsqlPoint(x: 0.43065155277870903d, y: 0.7301842122679338d), new NpgsqlTypes.NpgsqlPoint(x: 0.21656564675756151d, y: 0.665089920787759d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8050478124611008d, y: 0.26636636211197096d), new NpgsqlTypes.NpgsqlPoint(x: 0.6508890385478868d, y: 0.9506809910408982d), new NpgsqlTypes.NpgsqlPoint(x: 0.39943562540766d, y: 0.4959102423783667d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46005096983685634d, y: 0.43621541345529524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5507286358064648d, y: 0.6286113140929211d), new NpgsqlTypes.NpgsqlPoint(x: 0.4714177459071177d, y: 0.9259092626023325d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41124041148768953d, y: 0.6464058243510021d), new NpgsqlTypes.NpgsqlPoint(x: 0.13112050296640287d, y: 0.3656623131468555d), new NpgsqlTypes.NpgsqlPoint(x: 0.07402349615479764d, y: 0.8643009150506272d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7920422242632201d, y: 0.730322927986811d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989115246048319d, y: 0.002188484735697993d), new NpgsqlTypes.NpgsqlPoint(x: 0.2636282278186931d, y: 0.6881359888529222d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6950991160747485d, y: 0.9823288839321425d), new NpgsqlTypes.NpgsqlPoint(x: 0.7093135948543173d, y: 0.6689068136944152d), new NpgsqlTypes.NpgsqlPoint(x: 0.06363964449790416d, y: 0.7452503322240097d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9416146522986995d, y: 0.38752912223826774d), new NpgsqlTypes.NpgsqlPoint(x: 0.8238319974650571d, y: 0.3173989159802626d), new NpgsqlTypes.NpgsqlPoint(x: 0.7920632508642913d, y: 0.7097257068131406d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1320327502780051d, y: 0.8691988846566194d), new NpgsqlTypes.NpgsqlPoint(x: 0.7200529112249664d, y: 0.13421552301137984d), new NpgsqlTypes.NpgsqlPoint(x: 0.2973548858607614d, y: 0.5971295664935101d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08018308829928777d, y: 0.8866646451759965d), new NpgsqlTypes.NpgsqlPoint(x: 0.27396600925283787d, y: 0.15548967856473517d), new NpgsqlTypes.NpgsqlPoint(x: 0.14023484181949075d, y: 0.8782501054142325d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8316647930590311d, y: 0.18122709275544446d), new NpgsqlTypes.NpgsqlPoint(x: 0.4122440235575925d, y: 0.2918297278046561d), new NpgsqlTypes.NpgsqlPoint(x: 0.8426771755936535d, y: 0.14578074393486384d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32018750756057646d, y: 0.2713975004100102d), new NpgsqlTypes.NpgsqlPoint(x: 0.6858630186346735d, y: 0.29228915542580025d), new NpgsqlTypes.NpgsqlPoint(x: 0.2648422879223772d, y: 0.20458285487587702d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4387082635469113d, y: 0.49183055104606743d), new NpgsqlTypes.NpgsqlPoint(x: 0.6018691866562572d, y: 0.8861420860261525d), new NpgsqlTypes.NpgsqlPoint(x: 0.8026248970072193d, y: 0.6855319885454263d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21317003479315055d, y: 0.08211386525497522d), new NpgsqlTypes.NpgsqlPoint(x: 0.3587274297576585d, y: 0.04880384400038118d), new NpgsqlTypes.NpgsqlPoint(x: 0.27144623009409086d, y: 0.8729597510545196d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9767945214198943d, y: 0.6793838427549364d), new NpgsqlTypes.NpgsqlPoint(x: 0.6796333073726111d, y: 0.48682557851070984d), new NpgsqlTypes.NpgsqlPoint(x: 0.5999249888616611d, y: 0.37726810818343326d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28427194195583205d, y: 0.7447463575917034d), new NpgsqlTypes.NpgsqlPoint(x: 0.369858084494769d, y: 0.6279719692026319d), new NpgsqlTypes.NpgsqlPoint(x: 0.599914090464782d, y: 0.8647173637388033d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2881785455396887d, y: 0.37977525901035236d), new NpgsqlTypes.NpgsqlPoint(x: 0.1767165606001957d, y: 0.2269675336991912d), new NpgsqlTypes.NpgsqlPoint(x: 0.2219886932071521d, y: 0.09196945167957749d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4871351182134871d, y: 0.9227613850621659d), new NpgsqlTypes.NpgsqlPoint(x: 0.5940935606750398d, y: 0.038291237938132494d), new NpgsqlTypes.NpgsqlPoint(x: 0.4250738598625381d, y: 0.5401468073383617d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9505366964130383d, y: 0.742156392467654d), new NpgsqlTypes.NpgsqlPoint(x: 0.25320943618862524d, y: 0.3155450167639141d), new NpgsqlTypes.NpgsqlPoint(x: 0.24179109056483494d, y: 0.6390412706071436d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9437977478883863d, y: 0.43119609071834153d), new NpgsqlTypes.NpgsqlPoint(x: 0.08971743262493159d, y: 0.013359838609881325d), new NpgsqlTypes.NpgsqlPoint(x: 0.5346023015404263d, y: 0.5336939003089152d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39509035949997884d, y: 0.11781316710355816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5872931772250327d, y: 0.7574192340024435d), new NpgsqlTypes.NpgsqlPoint(x: 0.34646328239400004d, y: 0.8216382407550357d)), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6933682362606279d, y: 0.11220173190608251d), new NpgsqlTypes.NpgsqlPoint(x: 0.06525123838131086d, y: 0.9848561680166739d), new NpgsqlTypes.NpgsqlPoint(x: 0.6176541859522813d, y: 0.29052341291217365d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20499509388306558d, y: 0.07505223041205156d), new NpgsqlTypes.NpgsqlPoint(x: 0.29942386316510605d, y: 0.48385746558479736d), new NpgsqlTypes.NpgsqlPoint(x: 0.971885782564473d, y: 0.17680612163345677d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.669776376229779d, y: 0.05731800615783511d), new NpgsqlTypes.NpgsqlPoint(x: 0.5632510468501034d, y: 0.7944877120075806d), new NpgsqlTypes.NpgsqlPoint(x: 0.08873841722232378d, y: 0.7785757057049677d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8291794266604692d, y: 0.25092034259589857d), new NpgsqlTypes.NpgsqlPoint(x: 0.6097713264242715d, y: 0.35332833535059005d), new NpgsqlTypes.NpgsqlPoint(x: 0.22896362417157456d, y: 0.015346038182390664d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7906789210635888d, y: 0.8206724670071387d), new NpgsqlTypes.NpgsqlPoint(x: 0.890572322603725d, y: 0.9174919355633121d), new NpgsqlTypes.NpgsqlPoint(x: 0.7229848526484491d, y: 0.2445357392436739d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47927665162358435d, y: 0.9896759735176087d), new NpgsqlTypes.NpgsqlPoint(x: 0.18958831690110267d, y: 0.7098977240364822d), new NpgsqlTypes.NpgsqlPoint(x: 0.30912094538869617d, y: 0.3650797580592344d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5433348365630265d, y: 0.13814544089763658d), new NpgsqlTypes.NpgsqlPoint(x: 0.30032928853532337d, y: 0.24606404163024964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8782978338124566d, y: 0.8983840728998006d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5215777148981875d, y: 0.050055417262119484d), new NpgsqlTypes.NpgsqlPoint(x: 0.9182483077062933d, y: 0.14466813658501543d), new NpgsqlTypes.NpgsqlPoint(x: 0.7885912677062978d, y: 0.3935410253209125d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9616900755931963d, y: 0.8849702233296054d), new NpgsqlTypes.NpgsqlPoint(x: 0.5680953176751546d, y: 0.3632882457871307d), new NpgsqlTypes.NpgsqlPoint(x: 0.693045620097517d, y: 0.8584154926630977d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08844782150635855d, y: 0.7391955924325188d), new NpgsqlTypes.NpgsqlPoint(x: 0.28638358017493826d, y: 0.8336804709617792d), new NpgsqlTypes.NpgsqlPoint(x: 0.37024237238627233d, y: 0.9779785425962942d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6264713910786796d, y: 0.6544832014758677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7591909398710339d, y: 0.31211539778233d), new NpgsqlTypes.NpgsqlPoint(x: 0.3765493705262227d, y: 0.7141357268698547d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45560841433441934d, y: 0.3791595641934832d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903319066284785d, y: 0.03453514643669864d), new NpgsqlTypes.NpgsqlPoint(x: 0.1493217364066799d, y: 0.10564336604295921d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5798617995068399d, y: 0.2078258948697197d), new NpgsqlTypes.NpgsqlPoint(x: 0.4650170834143922d, y: 0.8356146938478812d), new NpgsqlTypes.NpgsqlPoint(x: 0.9049648729962921d, y: 0.9934428873254555d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4000480454735089d, y: 0.5697888610633801d), new NpgsqlTypes.NpgsqlPoint(x: 0.49512205119324637d, y: 0.11084315065442141d), new NpgsqlTypes.NpgsqlPoint(x: 0.6856035384868394d, y: 0.5248206880246987d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4832770921659435d, y: 0.5498087440069694d), new NpgsqlTypes.NpgsqlPoint(x: 0.23265454850626943d, y: 0.493598409914634d), new NpgsqlTypes.NpgsqlPoint(x: 0.0865655551584682d, y: 0.23929892172426748d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6709135607827396d, y: 0.06085406250524139d), new NpgsqlTypes.NpgsqlPoint(x: 0.23832570504278672d, y: 0.46262601964225203d), new NpgsqlTypes.NpgsqlPoint(x: 0.24508972624054026d, y: 0.4950609572181133d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20800814770737752d, y: 0.9665521735660466d), new NpgsqlTypes.NpgsqlPoint(x: 0.12180958788560858d, y: 0.2819838581611429d), new NpgsqlTypes.NpgsqlPoint(x: 0.19052842801504688d, y: 0.2988669820011117d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22051092312861065d, y: 0.29890676157794294d), new NpgsqlTypes.NpgsqlPoint(x: 0.4398294706199588d, y: 0.25405166730487516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9122463487267918d, y: 0.3323140324256869d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18381394994772005d, y: 0.07221864763781183d), new NpgsqlTypes.NpgsqlPoint(x: 0.16704011902244909d, y: 0.7866400859938549d), new NpgsqlTypes.NpgsqlPoint(x: 0.6917088499715847d, y: 0.30324364643855806d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9394349903895529d, y: 0.6975423920654654d), new NpgsqlTypes.NpgsqlPoint(x: 0.3427509960817291d, y: 0.5464999778034487d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236909737637485d, y: 0.06769945439169955d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23229798264753176d, y: 0.13030036984853444d), new NpgsqlTypes.NpgsqlPoint(x: 0.2409414171512665d, y: 0.6448008611211736d), new NpgsqlTypes.NpgsqlPoint(x: 0.19072546109026656d, y: 0.15303682534904195d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37059790571046025d, y: 0.853294389740587d), new NpgsqlTypes.NpgsqlPoint(x: 0.8775637251410591d, y: 0.01839291586675884d), new NpgsqlTypes.NpgsqlPoint(x: 0.44772147415075136d, y: 0.5755453851120965d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6637102570144287d, y: 0.6174967531449688d), new NpgsqlTypes.NpgsqlPoint(x: 0.14481695521676652d, y: 0.507927890299054d), new NpgsqlTypes.NpgsqlPoint(x: 0.23683647822696086d, y: 0.17120121929028742d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8823452472439917d, y: 0.5533909314280269d), new NpgsqlTypes.NpgsqlPoint(x: 0.18453494745874433d, y: 0.26220396035799276d), new NpgsqlTypes.NpgsqlPoint(x: 0.09603159045162257d, y: 0.3608495019879786d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8133813133344067d, y: 0.5198654356403922d), new NpgsqlTypes.NpgsqlPoint(x: 0.8180418356282725d, y: 0.8961930601929773d), new NpgsqlTypes.NpgsqlPoint(x: 0.7109031654787964d, y: 0.5437178200968722d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14315698274272648d, y: 0.5674494552128009d), new NpgsqlTypes.NpgsqlPoint(x: 0.22927032983650952d, y: 0.6150767027972531d), new NpgsqlTypes.NpgsqlPoint(x: 0.7944160620373545d, y: 0.22033238960618506d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5033049648058219d, y: 0.3702004201485045d), new NpgsqlTypes.NpgsqlPoint(x: 0.3230507752753048d, y: 0.3496961078215689d), new NpgsqlTypes.NpgsqlPoint(x: 0.027723201539117004d, y: 0.4138646910157501d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17642990362025057d, y: 0.5369035794076069d), new NpgsqlTypes.NpgsqlPoint(x: 0.3842717851859596d, y: 0.38177421764956976d), new NpgsqlTypes.NpgsqlPoint(x: 0.16091534859850187d, y: 0.689625883686452d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6965803944317117d, y: 0.3396028823246918d), new NpgsqlTypes.NpgsqlPoint(x: 0.8878639733302984d, y: 0.698798811691816d), new NpgsqlTypes.NpgsqlPoint(x: 0.2098587462668685d, y: 0.6741195144008979d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8378525187394422d, y: 0.04693612949154391d), new NpgsqlTypes.NpgsqlPoint(x: 0.3218353079459322d, y: 0.8292427131564882d), new NpgsqlTypes.NpgsqlPoint(x: 0.22611325426643347d, y: 0.7146490400724229d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7683851069395568d, y: 0.4371646162402757d), new NpgsqlTypes.NpgsqlPoint(x: 0.35187216354938067d, y: 0.7894817415646281d), new NpgsqlTypes.NpgsqlPoint(x: 0.8417840611264752d, y: 0.1336072060308413d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8879099226057265d, y: 0.5462690557759464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6457488441623823d, y: 0.17259766164270052d), new NpgsqlTypes.NpgsqlPoint(x: 0.9347507086586628d, y: 0.17724061346273356d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9963348544914011d, y: 0.5208721301644675d), new NpgsqlTypes.NpgsqlPoint(x: 0.7193143181609091d, y: 0.19634828425163608d), new NpgsqlTypes.NpgsqlPoint(x: 0.2564191619065801d, y: 0.6900804595930251d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6416004499168222d, y: 0.22501331104604472d), new NpgsqlTypes.NpgsqlPoint(x: 0.6747956118142688d, y: 0.9976935939060698d), new NpgsqlTypes.NpgsqlPoint(x: 0.8065347744747723d, y: 0.9566829750744523d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8807448831291187d, y: 0.3247217370448069d), new NpgsqlTypes.NpgsqlPoint(x: 0.9737243734906544d, y: 0.8789163115016504d), new NpgsqlTypes.NpgsqlPoint(x: 0.42041145689639825d, y: 0.5776030457156889d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0013099254289844486d, y: 0.2886994011957791d), new NpgsqlTypes.NpgsqlPoint(x: 0.3031231503337376d, y: 0.8455692635246367d), new NpgsqlTypes.NpgsqlPoint(x: 0.0034113013888874555d, y: 0.5414518486856545d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7507741252399558d, y: 0.7878722373810818d), new NpgsqlTypes.NpgsqlPoint(x: 0.070285107511037d, y: 0.7274071735802985d), new NpgsqlTypes.NpgsqlPoint(x: 0.6626220010451485d, y: 0.1519838482962068d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.743040071851202d, y: 0.2226238449288499d), new NpgsqlTypes.NpgsqlPoint(x: 0.36954765403907486d, y: 0.478114004958205d), new NpgsqlTypes.NpgsqlPoint(x: 0.5385878621125487d, y: 0.04466918091102756d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44966213907294206d, y: 0.3278027235916322d), new NpgsqlTypes.NpgsqlPoint(x: 0.5734179728515336d, y: 0.6503900259766406d), new NpgsqlTypes.NpgsqlPoint(x: 0.25473564624939526d, y: 0.2844964419659125d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007749883937488988d, y: 0.8395144424509358d), new NpgsqlTypes.NpgsqlPoint(x: 0.4551222596235146d, y: 0.09120672110380978d), new NpgsqlTypes.NpgsqlPoint(x: 0.2761754644253004d, y: 0.8726563373519844d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7941576521634514d, y: 0.4574206434580994d), new NpgsqlTypes.NpgsqlPoint(x: 0.3934201495920373d, y: 0.8002196174281676d), new NpgsqlTypes.NpgsqlPoint(x: 0.19510627117339352d, y: 0.8779800561262493d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6223839732671897d, y: 0.8699386090825483d), new NpgsqlTypes.NpgsqlPoint(x: 0.5872629854182722d, y: 0.24561822085487883d), new NpgsqlTypes.NpgsqlPoint(x: 0.2502846158351777d, y: 0.3818483264904682d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9548928157581028d, y: 0.38791050641816127d), new NpgsqlTypes.NpgsqlPoint(x: 0.25715068140366315d, y: 0.7386347634219794d), new NpgsqlTypes.NpgsqlPoint(x: 0.6972983329526409d, y: 0.00377706798084787d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7058965461283563d, y: 0.4617843974420308d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096925528841323d, y: 0.016918279267804537d), new NpgsqlTypes.NpgsqlPoint(x: 0.976825872754008d, y: 0.9259593814210583d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23946727305189375d, y: 0.4299408692247343d), new NpgsqlTypes.NpgsqlPoint(x: 0.284481664214559d, y: 0.28860125725416585d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540236305794178d, y: 0.9825461260775752d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1320545836283068d, y: 0.5645427510278691d), new NpgsqlTypes.NpgsqlPoint(x: 0.5601005210159152d, y: 0.3421506906491978d), new NpgsqlTypes.NpgsqlPoint(x: 0.73655442760209d, y: 0.8586406276225808d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6813486460708549d, y: 0.7182878189877143d), new NpgsqlTypes.NpgsqlPoint(x: 0.10509924977765583d, y: 0.8951942874585421d), new NpgsqlTypes.NpgsqlPoint(x: 0.41091784661343456d, y: 0.5591194158714321d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36656367479267005d, y: 0.12936740905694832d), new NpgsqlTypes.NpgsqlPoint(x: 0.3228360279932697d, y: 0.4456033246783203d), new NpgsqlTypes.NpgsqlPoint(x: 0.31513924866757426d, y: 0.16756034339558457d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5626095328674708d, y: 0.29345267143324316d), new NpgsqlTypes.NpgsqlPoint(x: 0.3670325709460207d, y: 0.833295451754932d), new NpgsqlTypes.NpgsqlPoint(x: 0.6133248933440472d, y: 0.23234191741359167d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8495500447581517d, y: 0.11972504854495036d), new NpgsqlTypes.NpgsqlPoint(x: 0.30820281577455366d, y: 0.48377934956619617d), new NpgsqlTypes.NpgsqlPoint(x: 0.779959464812153d, y: 0.679735525759904d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6056581372777999d, y: 0.2681823155025336d), new NpgsqlTypes.NpgsqlPoint(x: 0.7850347942166609d, y: 0.09527201627675719d), new NpgsqlTypes.NpgsqlPoint(x: 0.008762513799399185d, y: 0.449620665113313d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12097722154802437d, y: 0.5229309226145603d), new NpgsqlTypes.NpgsqlPoint(x: 0.4704302859434124d, y: 0.9837196514051937d), new NpgsqlTypes.NpgsqlPoint(x: 0.8448564341725481d, y: 0.2606518500981547d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3867984992676011d, y: 0.8418325361060515d), new NpgsqlTypes.NpgsqlPoint(x: 0.18714465543771097d, y: 0.9294241611779344d), new NpgsqlTypes.NpgsqlPoint(x: 0.25331945237582365d, y: 0.5072910210327684d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22397408892451898d, y: 0.6366289638068702d), new NpgsqlTypes.NpgsqlPoint(x: 0.3259864973553047d, y: 0.3883701922472135d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772022635933769d, y: 0.34601812261989673d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019020721703480348d, y: 0.2531498425802394d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059718656848824d, y: 0.45382195619766386d), new NpgsqlTypes.NpgsqlPoint(x: 0.9023154388587064d, y: 0.4409132125945888d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06493749108845415d, y: 0.7642821578562581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5982221421459591d, y: 0.4666953978212819d), new NpgsqlTypes.NpgsqlPoint(x: 0.9457615897758082d, y: 0.6236490696906597d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7521965277753966d, y: 0.3058498280018491d), new NpgsqlTypes.NpgsqlPoint(x: 0.7045767910506128d, y: 0.8579820786072927d), new NpgsqlTypes.NpgsqlPoint(x: 0.09004056649125325d, y: 0.03703384019988165d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6912384830899033d, y: 0.9045359007846256d), new NpgsqlTypes.NpgsqlPoint(x: 0.15543965402493432d, y: 0.2897292021462813d), new NpgsqlTypes.NpgsqlPoint(x: 0.9184783611972871d, y: 0.046740705417518846d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3776947137712696d, y: 0.08769063534939014d), new NpgsqlTypes.NpgsqlPoint(x: 0.3308162946600851d, y: 0.22814084401113577d), new NpgsqlTypes.NpgsqlPoint(x: 0.08209181607684801d, y: 0.12580860244512404d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3808693871928073d, y: 0.08650060258328507d), new NpgsqlTypes.NpgsqlPoint(x: 0.39013437570096254d, y: 0.7652299089200063d), new NpgsqlTypes.NpgsqlPoint(x: 0.1816314195140727d, y: 0.853699719477385d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18224622205821184d, y: 0.44128994715464653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9485933130800271d, y: 0.8177383483689448d), new NpgsqlTypes.NpgsqlPoint(x: 0.02025043323173592d, y: 0.8487127693915428d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06180857508442272d, y: 0.1547983745614102d), new NpgsqlTypes.NpgsqlPoint(x: 0.4351641426727513d, y: 0.5405963602928602d), new NpgsqlTypes.NpgsqlPoint(x: 0.13816123743101727d, y: 0.8116593129919863d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14831621854897026d, y: 0.5124204690166012d), new NpgsqlTypes.NpgsqlPoint(x: 0.4992997914393942d, y: 0.21859479240628044d), new NpgsqlTypes.NpgsqlPoint(x: 0.6299002791652109d, y: 0.9596305948960212d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32084292850053575d, y: 0.9520603006516497d), new NpgsqlTypes.NpgsqlPoint(x: 0.368341387367515d, y: 0.2901904144052382d), new NpgsqlTypes.NpgsqlPoint(x: 0.06116232255245346d, y: 0.63409519890393d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5111697684160322d, y: 0.012301582507040387d), new NpgsqlTypes.NpgsqlPoint(x: 0.2561369841623937d, y: 0.8800593979554248d), new NpgsqlTypes.NpgsqlPoint(x: 0.8857897836410259d, y: 0.8290115445156475d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23786567867534347d, y: 0.0928582651123604d), new NpgsqlTypes.NpgsqlPoint(x: 0.9859926341781939d, y: 0.7467275626779782d), new NpgsqlTypes.NpgsqlPoint(x: 0.916488305625976d, y: 0.8831387531659891d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09609045121465742d, y: 0.14602240846251657d), new NpgsqlTypes.NpgsqlPoint(x: 0.14829389789592629d, y: 0.2144222443283076d), new NpgsqlTypes.NpgsqlPoint(x: 0.08229345402507571d, y: 0.661932718363861d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5775585137514925d, y: 0.3138124328217414d), new NpgsqlTypes.NpgsqlPoint(x: 0.06413692742522625d, y: 0.3661020210375969d), new NpgsqlTypes.NpgsqlPoint(x: 0.197730957556028d, y: 0.2445241305441047d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6868404790285177d, y: 0.8318063802741293d), new NpgsqlTypes.NpgsqlPoint(x: 0.6847983850302419d, y: 0.4744634085221566d), new NpgsqlTypes.NpgsqlPoint(x: 0.8538099310423387d, y: 0.863321452896074d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6822058809392756d, y: 0.2982715815666134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7550703690417675d, y: 0.17910542564415088d), new NpgsqlTypes.NpgsqlPoint(x: 0.9235040178967993d, y: 0.421466584412049d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7981884209045946d, y: 0.7355355257784456d), new NpgsqlTypes.NpgsqlPoint(x: 0.049652517619773406d, y: 0.17267817516315231d), new NpgsqlTypes.NpgsqlPoint(x: 0.3378935196687237d, y: 0.09350061309087365d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08616094710473943d, y: 0.38721452174633275d), new NpgsqlTypes.NpgsqlPoint(x: 0.5431308048503178d, y: 0.5249608779112667d), new NpgsqlTypes.NpgsqlPoint(x: 0.17759709085725806d, y: 0.4159827067705565d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3559794008504721d, y: 0.32549210606963896d), new NpgsqlTypes.NpgsqlPoint(x: 0.2932078900484596d, y: 0.5472051240984557d), new NpgsqlTypes.NpgsqlPoint(x: 0.03245303618648443d, y: 0.34313112432309667d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27445912949134565d, y: 0.36125412482569064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7417979623382003d, y: 0.7074113559491069d), new NpgsqlTypes.NpgsqlPoint(x: 0.533480457581585d, y: 0.7410632388528463d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03969834317658283d, y: 0.742771604839623d), new NpgsqlTypes.NpgsqlPoint(x: 0.030733227784307093d, y: 0.8705618811767384d), new NpgsqlTypes.NpgsqlPoint(x: 0.6596245221966701d, y: 0.34673655505577594d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3151571649178241d, y: 0.11407797758371874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8390246096393195d, y: 0.1405207978933275d), new NpgsqlTypes.NpgsqlPoint(x: 0.1377803039639276d, y: 0.9194177532375942d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6464435970848985d, y: 0.7954078544939548d), new NpgsqlTypes.NpgsqlPoint(x: 0.3921153143200682d, y: 0.8555289014239756d), new NpgsqlTypes.NpgsqlPoint(x: 0.07525987950052038d, y: 0.6302938370370791d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3953422306459681d, y: 0.12635046098448688d), new NpgsqlTypes.NpgsqlPoint(x: 0.20700069620517314d, y: 0.6887561286695901d), new NpgsqlTypes.NpgsqlPoint(x: 0.8538735178279463d, y: 0.04299960030753536d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8820522448717991d, y: 0.49510160575730133d), new NpgsqlTypes.NpgsqlPoint(x: 0.6220860728957817d, y: 0.6289665839370273d), new NpgsqlTypes.NpgsqlPoint(x: 0.12576773797752894d, y: 0.2976360432215942d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9819568080369852d, y: 0.46217779973271844d), new NpgsqlTypes.NpgsqlPoint(x: 0.8228379721260276d, y: 0.0348617917752333d), new NpgsqlTypes.NpgsqlPoint(x: 0.15841540207714455d, y: 0.8800018461741916d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6156142847911313d, y: 0.5113574685213367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7243925919136616d, y: 0.6752531731694723d), new NpgsqlTypes.NpgsqlPoint(x: 0.9503988376945378d, y: 0.5653754121629245d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5147891790550394d, y: 0.8548341924099793d), new NpgsqlTypes.NpgsqlPoint(x: 0.13981714701163017d, y: 0.7925716385213413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8428863041662861d, y: 0.01951833672316028d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7862670539227071d, y: 0.09551569773335644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7696411331032493d, y: 0.009968621903136188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9010175550838586d, y: 0.61621917198186d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15758720858463282d, y: 0.679290672230812d), new NpgsqlTypes.NpgsqlPoint(x: 0.7394459638127613d, y: 0.5561342855136635d), new NpgsqlTypes.NpgsqlPoint(x: 0.985990969341415d, y: 0.29555735532534766d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6600349105178067d, y: 0.7436573802872082d), new NpgsqlTypes.NpgsqlPoint(x: 0.425336772196117d, y: 0.173544320205687d), new NpgsqlTypes.NpgsqlPoint(x: 0.852886344975702d, y: 0.9806747804940692d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8058291377169077d, y: 0.9321081337772179d), new NpgsqlTypes.NpgsqlPoint(x: 0.4129605353561384d, y: 0.23102254636326391d), new NpgsqlTypes.NpgsqlPoint(x: 0.153348048106683d, y: 0.6791518766199208d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6708883270209131d, y: 0.6739105901949267d), new NpgsqlTypes.NpgsqlPoint(x: 0.9848841750191054d, y: 0.5721913482466288d), new NpgsqlTypes.NpgsqlPoint(x: 0.5657328586524559d, y: 0.7775725661278251d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0761154060011543d, y: 0.20462034385334193d), new NpgsqlTypes.NpgsqlPoint(x: 0.9127522810166645d, y: 0.7150801867603617d), new NpgsqlTypes.NpgsqlPoint(x: 0.3646055647014178d, y: 0.2522031954541194d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9990884229278935d, y: 0.8235886490737573d), new NpgsqlTypes.NpgsqlPoint(x: 0.49780838798611937d, y: 0.08894634842984261d), new NpgsqlTypes.NpgsqlPoint(x: 0.3602625396109558d, y: 0.18968878824254465d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4953964203191543d, y: 0.6744157564217956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8401322324570816d, y: 0.6059355313322689d), new NpgsqlTypes.NpgsqlPoint(x: 0.49293488595726376d, y: 0.4277169830691022d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8820235245550884d, y: 0.912316122495491d), new NpgsqlTypes.NpgsqlPoint(x: 0.76562791214942d, y: 0.5955465733115852d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298553361028554d, y: 0.4907146916790207d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5005165227561795d, y: 0.9106277275534166d), new NpgsqlTypes.NpgsqlPoint(x: 0.7547368589478454d, y: 0.5085292574383382d), new NpgsqlTypes.NpgsqlPoint(x: 0.6855537060457532d, y: 0.8256365971982507d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39580075744640375d, y: 0.6804815526211832d), new NpgsqlTypes.NpgsqlPoint(x: 0.2648870899605601d, y: 0.2056565081425532d), new NpgsqlTypes.NpgsqlPoint(x: 0.2965572640132237d, y: 0.006444552257952818d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16482045021955494d, y: 0.13804242428712066d), new NpgsqlTypes.NpgsqlPoint(x: 0.10396807832381538d, y: 0.3848120196209558d), new NpgsqlTypes.NpgsqlPoint(x: 0.176153833195d, y: 0.6833784146375617d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3486865866884735d, y: 0.1502812619124544d), new NpgsqlTypes.NpgsqlPoint(x: 0.08289253044706946d, y: 0.6527170661232327d), new NpgsqlTypes.NpgsqlPoint(x: 0.02659831704079796d, y: 0.029986891984531305d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5196564393184236d, y: 0.09957880066992686d), new NpgsqlTypes.NpgsqlPoint(x: 0.20972910072297613d, y: 0.9290789033354612d), new NpgsqlTypes.NpgsqlPoint(x: 0.0479238911289287d, y: 0.19666226155077338d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5326606871905013d, y: 0.6272686339255363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7195372123357332d, y: 0.4518492330738846d), new NpgsqlTypes.NpgsqlPoint(x: 0.6704338136222422d, y: 0.9894642229362068d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05075358879205394d, y: 0.8417232028673041d), new NpgsqlTypes.NpgsqlPoint(x: 0.8457076347853436d, y: 0.8538997845890365d), new NpgsqlTypes.NpgsqlPoint(x: 0.4909242806229758d, y: 0.08806747723273944d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7217764640173435d, y: 0.06850395436996515d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375761924174454d, y: 0.8386777833753045d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905522390860627d, y: 0.8829272307074523d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7841267466467647d, y: 0.5925575000274625d), new NpgsqlTypes.NpgsqlPoint(x: 0.577703290677352d, y: 0.9586885720918685d), new NpgsqlTypes.NpgsqlPoint(x: 0.14084116307123806d, y: 0.517057222645513d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3603442544870541d, y: 0.4131507513695817d), new NpgsqlTypes.NpgsqlPoint(x: 0.6419986605209322d, y: 0.3325064634054815d), new NpgsqlTypes.NpgsqlPoint(x: 0.24926384557809678d, y: 0.7161055648688623d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32011423717007503d, y: 0.6527628755772726d), new NpgsqlTypes.NpgsqlPoint(x: 0.4079514860955398d, y: 0.4752703236910031d), new NpgsqlTypes.NpgsqlPoint(x: 0.3532940705588118d, y: 0.5215646953891315d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45254102308177635d, y: 0.13092444991813823d), new NpgsqlTypes.NpgsqlPoint(x: 0.44326725634284136d, y: 0.672245004487656d), new NpgsqlTypes.NpgsqlPoint(x: 0.5114061684653355d, y: 0.31208935038919405d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028723491809534707d, y: 0.6414166099516981d), new NpgsqlTypes.NpgsqlPoint(x: 0.03515809705627937d, y: 0.2197901236575025d), new NpgsqlTypes.NpgsqlPoint(x: 0.7921118787370107d, y: 0.2518118512585785d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.056626056961596505d, y: 0.7958453013231159d), new NpgsqlTypes.NpgsqlPoint(x: 0.22833255247666795d, y: 0.18997889802536638d), new NpgsqlTypes.NpgsqlPoint(x: 0.5687262056302368d, y: 0.7345327291637033d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9068390966813181d, y: 0.29360196794460747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7530569036977758d, y: 0.6226595563546261d), new NpgsqlTypes.NpgsqlPoint(x: 0.683037928973161d, y: 0.7958408119348653d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010350790123149989d, y: 0.8247852483085871d), new NpgsqlTypes.NpgsqlPoint(x: 0.965485355795306d, y: 0.9588642642826645d), new NpgsqlTypes.NpgsqlPoint(x: 0.6647647726308643d, y: 0.7440349649502922d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2327118914544879d, y: 0.9177305598355892d), new NpgsqlTypes.NpgsqlPoint(x: 0.39592391976797203d, y: 0.9846792533340611d), new NpgsqlTypes.NpgsqlPoint(x: 0.8638327499740085d, y: 0.8357521685581161d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4268620958092838d, y: 0.17840265615299267d), new NpgsqlTypes.NpgsqlPoint(x: 0.4688009494568828d, y: 0.4488831403625486d), new NpgsqlTypes.NpgsqlPoint(x: 0.31994302754163306d, y: 0.5956792215166868d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8095220333262414d, y: 0.33184828914576747d), new NpgsqlTypes.NpgsqlPoint(x: 0.8102810086038432d, y: 0.6340014620414088d), new NpgsqlTypes.NpgsqlPoint(x: 0.636172297651404d, y: 0.7989262088629283d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34453505933603235d, y: 0.3901076494689263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6872240526085317d, y: 0.10733204513768702d), new NpgsqlTypes.NpgsqlPoint(x: 0.09007433510489193d, y: 0.5555182552680282d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17560630864460314d, y: 0.6088538157965765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8691525423840134d, y: 0.3009242754007234d), new NpgsqlTypes.NpgsqlPoint(x: 0.2192202922165396d, y: 0.30127960758393313d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2740316344066892d, y: 0.41043644733450757d), new NpgsqlTypes.NpgsqlPoint(x: 0.823899016043224d, y: 0.6821805661866049d), new NpgsqlTypes.NpgsqlPoint(x: 0.4455638706666867d, y: 0.17454940291573895d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04323155893903052d, y: 0.47102236668807596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7198522910313928d, y: 0.5562736474189972d), new NpgsqlTypes.NpgsqlPoint(x: 0.6511354419295535d, y: 0.0671018363964676d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26777073168867527d, y: 0.7345447102690448d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995273704896932d, y: 0.9574551561622469d), new NpgsqlTypes.NpgsqlPoint(x: 0.4535732935370669d, y: 0.6482291699458577d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5508685179995971d, y: 0.8695621776477039d), new NpgsqlTypes.NpgsqlPoint(x: 0.302665774445241d, y: 0.7111173190236542d), new NpgsqlTypes.NpgsqlPoint(x: 0.0892633582224609d, y: 0.22904231289770138d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7472377261007607d, y: 0.16772421217810496d), new NpgsqlTypes.NpgsqlPoint(x: 0.24456707328659177d, y: 0.17755002009248977d), new NpgsqlTypes.NpgsqlPoint(x: 0.3826678449421689d, y: 0.21962167040012093d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5199466437546281d, y: 0.5489235319880886d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962179547355595d, y: 0.4818505187991159d), new NpgsqlTypes.NpgsqlPoint(x: 0.6118883039342541d, y: 0.9297544418641871d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4763325817046795d, y: 0.11216618144512958d), new NpgsqlTypes.NpgsqlPoint(x: 0.27112463104702944d, y: 0.5223975725875043d), new NpgsqlTypes.NpgsqlPoint(x: 0.5830080150955256d, y: 0.15704870501338575d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7337229324654235d, y: 0.7000446601377016d), new NpgsqlTypes.NpgsqlPoint(x: 0.7588483261044882d, y: 0.041326375416419925d), new NpgsqlTypes.NpgsqlPoint(x: 0.9538375103733635d, y: 0.61489832208388d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4182717040958146d, y: 0.5312446441214781d), new NpgsqlTypes.NpgsqlPoint(x: 0.8383340310371074d, y: 0.7386310894153353d), new NpgsqlTypes.NpgsqlPoint(x: 0.5943188498628275d, y: 0.8957043997418515d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48207663221147923d, y: 0.8004362200347988d), new NpgsqlTypes.NpgsqlPoint(x: 0.6868129153407708d, y: 0.7595738836227446d), new NpgsqlTypes.NpgsqlPoint(x: 0.7256176325109108d, y: 0.5364812013592875d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8980353989533666d, y: 0.7544456257061655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5482998726630888d, y: 0.7130708541442585d), new NpgsqlTypes.NpgsqlPoint(x: 0.8565941570107396d, y: 0.5347890192020603d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48992132325184734d, y: 0.8588331386709912d), new NpgsqlTypes.NpgsqlPoint(x: 0.060284670062695556d, y: 0.6527713334103457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236779787221303d, y: 0.8156219838121678d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.050986270708962d, y: 0.28279826190347646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9016833133986526d, y: 0.5807519197644915d), new NpgsqlTypes.NpgsqlPoint(x: 0.31249988303189513d, y: 0.23981839846042619d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35733564438258736d, y: 0.15335304490097845d), new NpgsqlTypes.NpgsqlPoint(x: 0.7267499804696311d, y: 0.1984424412273168d), new NpgsqlTypes.NpgsqlPoint(x: 0.7110159413678612d, y: 0.29171151939648476d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17061212603551423d, y: 0.34590956666626627d), new NpgsqlTypes.NpgsqlPoint(x: 0.7271038240573309d, y: 0.5709904126364377d), new NpgsqlTypes.NpgsqlPoint(x: 0.4540115282338949d, y: 0.0109431945978401d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5601406843607493d, y: 0.9366236374014196d), new NpgsqlTypes.NpgsqlPoint(x: 0.7426316377982534d, y: 0.9637851084103846d), new NpgsqlTypes.NpgsqlPoint(x: 0.8343082293841904d, y: 0.7405759506752378d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9476032740009397d, y: 0.8108296138423685d), new NpgsqlTypes.NpgsqlPoint(x: 0.23905842762982688d, y: 0.2261185559502037d), new NpgsqlTypes.NpgsqlPoint(x: 0.42053397736871867d, y: 0.4367367730982874d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43212547910738086d, y: 0.16413567662279638d), new NpgsqlTypes.NpgsqlPoint(x: 0.032131358486944706d, y: 0.40992397875928144d), new NpgsqlTypes.NpgsqlPoint(x: 0.1547329907165299d, y: 0.29912023743632765d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8835870530106473d, y: 0.5363423046741924d), new NpgsqlTypes.NpgsqlPoint(x: 0.48316567345798156d, y: 0.5855802887304272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5514880062766403d, y: 0.025353505055668468d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26133737890462827d, y: 0.2603535273829287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8846803387335513d, y: 0.967350278325573d), new NpgsqlTypes.NpgsqlPoint(x: 0.991624603303276d, y: 0.3400025078243365d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15191180420239636d, y: 0.32896425349920433d), new NpgsqlTypes.NpgsqlPoint(x: 0.6487685619917031d, y: 0.1290189832155435d), new NpgsqlTypes.NpgsqlPoint(x: 0.4650870769562757d, y: 0.7007344524856755d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8416938475514263d, y: 0.19578980524948997d), new NpgsqlTypes.NpgsqlPoint(x: 0.8864986928920888d, y: 0.28730714633275123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9371749087865348d, y: 0.6629816825701059d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.290470056442812d, y: 0.1423052991160474d), new NpgsqlTypes.NpgsqlPoint(x: 0.9586815953660467d, y: 0.1390855850856203d), new NpgsqlTypes.NpgsqlPoint(x: 0.5045491357383133d, y: 0.6641288381269866d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5611667166451116d, y: 0.30496456314147635d), new NpgsqlTypes.NpgsqlPoint(x: 0.20956294092011796d, y: 0.1032454830945847d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460641398607046d, y: 0.1543984024893098d)), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6159543381673761d, y: 0.6769223462287477d), new NpgsqlTypes.NpgsqlPoint(x: 0.2980247951001157d, y: 0.03308979448724647d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261081128119347d, y: 0.4261572184118264d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.703343042382055d, y: 0.07543331857235158d), new NpgsqlTypes.NpgsqlPoint(x: 0.9531333480827813d, y: 0.12564970227064864d), new NpgsqlTypes.NpgsqlPoint(x: 0.30088870958322433d, y: 0.1663454579718645d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2916591854541184d, y: 0.6817470267860211d), new NpgsqlTypes.NpgsqlPoint(x: 0.9766425705068421d, y: 0.5282260587203611d), new NpgsqlTypes.NpgsqlPoint(x: 0.3257648675967503d, y: 0.8665246496586633d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7323945294662135d, y: 0.21831826654592246d), new NpgsqlTypes.NpgsqlPoint(x: 0.7410929186201709d, y: 0.057523535792458724d), new NpgsqlTypes.NpgsqlPoint(x: 0.70031309583385d, y: 0.034381390571403214d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5366820625353158d, y: 0.7531849182849903d), new NpgsqlTypes.NpgsqlPoint(x: 0.1839504198444758d, y: 0.9831368720017863d), new NpgsqlTypes.NpgsqlPoint(x: 0.822721588077512d, y: 0.8958030719737651d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3518785218238898d, y: 0.8847435203035702d), new NpgsqlTypes.NpgsqlPoint(x: 0.9430179303520283d, y: 0.6746115110253571d), new NpgsqlTypes.NpgsqlPoint(x: 0.965856099053321d, y: 0.5476868498324879d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4613622929852421d, y: 0.5063528991682653d), new NpgsqlTypes.NpgsqlPoint(x: 0.032289612034986925d, y: 0.5600082684765245d), new NpgsqlTypes.NpgsqlPoint(x: 0.8875752699911905d, y: 0.6607723659311624d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5462385372544087d, y: 0.10025846995523446d), new NpgsqlTypes.NpgsqlPoint(x: 0.5715823831189577d, y: 0.6393002443727812d), new NpgsqlTypes.NpgsqlPoint(x: 0.4562220809942804d, y: 0.8764515807362683d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6943967720957039d, y: 0.4190085006284635d), new NpgsqlTypes.NpgsqlPoint(x: 0.03666592565543336d, y: 0.7333975746724175d), new NpgsqlTypes.NpgsqlPoint(x: 0.6268441561536084d, y: 0.24535363252095888d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47790118543694693d, y: 0.7857616925070766d), new NpgsqlTypes.NpgsqlPoint(x: 0.6687549659829278d, y: 0.43917263935799233d), new NpgsqlTypes.NpgsqlPoint(x: 0.7154475104446301d, y: 0.5594519172177582d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3631181799816273d, y: 0.2357683116493433d), new NpgsqlTypes.NpgsqlPoint(x: 0.4859699062842233d, y: 0.2724130126257249d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206410185264616d, y: 0.8446043510531764d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.462841389273263d, y: 0.6257911789415189d), new NpgsqlTypes.NpgsqlPoint(x: 0.8571121004293139d, y: 0.908164921823702d), new NpgsqlTypes.NpgsqlPoint(x: 0.9057744828343655d, y: 0.14013209118560466d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09098123434045968d, y: 0.8160859386065555d), new NpgsqlTypes.NpgsqlPoint(x: 0.21233833251035028d, y: 0.05883964454999313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9738794777150006d, y: 0.303622494694219d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3888364962818547d, y: 0.30493736251818226d), new NpgsqlTypes.NpgsqlPoint(x: 0.2286399614566218d, y: 0.24286785819596213d), new NpgsqlTypes.NpgsqlPoint(x: 0.4856588238103544d, y: 0.849840129000008d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.403267656231426d, y: 0.4787568757412147d), new NpgsqlTypes.NpgsqlPoint(x: 0.08751618232489344d, y: 0.5430764573159962d), new NpgsqlTypes.NpgsqlPoint(x: 0.11638106712640461d, y: 0.3678270180417599d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7056242124522417d, y: 0.06736804622781123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9321030488875311d, y: 0.5960028337578391d), new NpgsqlTypes.NpgsqlPoint(x: 0.9725347142636259d, y: 0.5788341814234796d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08466190491055015d, y: 0.15115007861301788d), new NpgsqlTypes.NpgsqlPoint(x: 0.66648878774395d, y: 0.5775796086133373d), new NpgsqlTypes.NpgsqlPoint(x: 0.12399291122810807d, y: 0.37650841882629216d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38412246680489226d, y: 0.035268399421471086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7080475183527315d, y: 0.5649950935769236d), new NpgsqlTypes.NpgsqlPoint(x: 0.9759146864563546d, y: 0.4239279117695808d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3124962510321806d, y: 0.9064290791062506d), new NpgsqlTypes.NpgsqlPoint(x: 0.17690057330618902d, y: 0.11945402268864425d), new NpgsqlTypes.NpgsqlPoint(x: 0.5779126957993695d, y: 0.45895765568456637d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7163510063799964d, y: 0.9108565592825002d), new NpgsqlTypes.NpgsqlPoint(x: 0.3069184853149144d, y: 0.13433169418914126d), new NpgsqlTypes.NpgsqlPoint(x: 0.6697809806388785d, y: 0.38140554131600435d)), }, },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7665603173038449d, y: 0.17114748565641646d), new NpgsqlTypes.NpgsqlPoint(x: 0.46428541015427593d, y: 0.01625926782994236d), new NpgsqlTypes.NpgsqlPoint(x: 0.4109537178101832d, y: 0.38674501626988234d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39182104705530807d, y: 0.4900132783813341d), new NpgsqlTypes.NpgsqlPoint(x: 0.12640852374467137d, y: 0.6359603559029129d), new NpgsqlTypes.NpgsqlPoint(x: 0.4164500330154991d, y: 0.1274595205275526d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9433661372321428d, y: 0.28373375055385386d), new NpgsqlTypes.NpgsqlPoint(x: 0.31394491063229535d, y: 0.6457599059502918d), new NpgsqlTypes.NpgsqlPoint(x: 0.3237143058147752d, y: 0.42536570612930913d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.825453745180276d, y: 0.7523695832209294d), new NpgsqlTypes.NpgsqlPoint(x: 0.2523070373797539d, y: 0.20674942820999065d), new NpgsqlTypes.NpgsqlPoint(x: 0.4723443493078541d, y: 0.8468741374241965d)), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37966257101665934d, y: 0.09147545042726868d), new NpgsqlTypes.NpgsqlPoint(x: 0.3148646571508733d, y: 0.1943875935083259d), new NpgsqlTypes.NpgsqlPoint(x: 0.11892546073474386d, y: 0.9104976133615308d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019207065299461257d, y: 0.42702479457853537d), new NpgsqlTypes.NpgsqlPoint(x: 0.9991781175943193d, y: 0.5791282295652858d), new NpgsqlTypes.NpgsqlPoint(x: 0.9110148729606127d, y: 0.24406762006250693d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39513619174203973d, y: 0.26012774597307287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6403583657674986d, y: 0.15609943579972452d), new NpgsqlTypes.NpgsqlPoint(x: 0.9479955519428258d, y: 0.35218482335578594d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1267151460129925d, y: 0.16829273830409985d), new NpgsqlTypes.NpgsqlPoint(x: 0.10474871730176627d, y: 0.12111632709871956d), new NpgsqlTypes.NpgsqlPoint(x: 0.33201166632762014d, y: 0.8101719012319948d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5242664058953103d, y: 0.04652528676621359d), new NpgsqlTypes.NpgsqlPoint(x: 0.9707536911051758d, y: 0.9295543174106795d), new NpgsqlTypes.NpgsqlPoint(x: 0.18634977564924282d, y: 0.016948469931499788d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23281897405449115d, y: 0.8276591389839136d), new NpgsqlTypes.NpgsqlPoint(x: 0.34560359603519686d, y: 0.528560410468896d), new NpgsqlTypes.NpgsqlPoint(x: 0.24633180100331964d, y: 0.4837264550776892d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15905055190363093d, y: 0.8955796551736676d), new NpgsqlTypes.NpgsqlPoint(x: 0.8609928400304615d, y: 0.8345447718485091d), new NpgsqlTypes.NpgsqlPoint(x: 0.9381910899583461d, y: 0.4185233779066725d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08328505005269837d, y: 0.5712260355391953d), new NpgsqlTypes.NpgsqlPoint(x: 0.6528721386810442d, y: 0.7313942908797932d), new NpgsqlTypes.NpgsqlPoint(x: 0.12161003875199494d, y: 0.8472065283537316d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6645446600755157d, y: 0.8149066016455986d), new NpgsqlTypes.NpgsqlPoint(x: 0.521090874976307d, y: 0.06984473101703093d), new NpgsqlTypes.NpgsqlPoint(x: 0.19265652670693656d, y: 0.25191637767533814d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35585139146984734d, y: 0.4101448576936506d), new NpgsqlTypes.NpgsqlPoint(x: 0.35613362475684074d, y: 0.2653022472117814d), new NpgsqlTypes.NpgsqlPoint(x: 0.5313279978972387d, y: 0.8847335565945766d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.76210504205493d, y: 0.5904898770079461d), new NpgsqlTypes.NpgsqlPoint(x: 0.5429327483436207d, y: 0.5404201997864602d), new NpgsqlTypes.NpgsqlPoint(x: 0.6968542107033912d, y: 0.6248981684973747d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.881092094157658d, y: 0.10575176046683299d), new NpgsqlTypes.NpgsqlPoint(x: 0.7882786944603641d, y: 0.4772154497456548d), new NpgsqlTypes.NpgsqlPoint(x: 0.2674887656444028d, y: 0.3363406894364125d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7099530019518362d, y: 0.8987769272046039d), new NpgsqlTypes.NpgsqlPoint(x: 0.1515190540742014d, y: 0.08847380204548128d), new NpgsqlTypes.NpgsqlPoint(x: 0.1353443399113774d, y: 0.5323600252406466d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.641265650391584d, y: 0.4954300794875167d), new NpgsqlTypes.NpgsqlPoint(x: 0.6210401543528403d, y: 0.3261892428579479d), new NpgsqlTypes.NpgsqlPoint(x: 0.4123482416651466d, y: 0.6250105901695987d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5562409431211999d, y: 0.7008224369198631d), new NpgsqlTypes.NpgsqlPoint(x: 0.15699359410694436d, y: 0.6159530147995643d), new NpgsqlTypes.NpgsqlPoint(x: 0.6913454052712673d, y: 0.18777368434860087d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7908638674849684d, y: 0.34952405283344634d), new NpgsqlTypes.NpgsqlPoint(x: 0.9012557499556235d, y: 0.3853207878205681d), new NpgsqlTypes.NpgsqlPoint(x: 0.8583610527002603d, y: 0.696248395321661d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26150162329884996d, y: 0.7861394837581069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8094152472438599d, y: 0.49979855159993625d), new NpgsqlTypes.NpgsqlPoint(x: 0.9261941314856352d, y: 0.6688223828328281d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8257922197051125d, y: 0.7420483805533385d), new NpgsqlTypes.NpgsqlPoint(x: 0.5091123460343769d, y: 0.6982501874139625d), new NpgsqlTypes.NpgsqlPoint(x: 0.18794288229330536d, y: 0.323880719639128d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9008872103185612d, y: 0.31214917011695287d), new NpgsqlTypes.NpgsqlPoint(x: 0.0324911500907501d, y: 0.8633823153814248d), new NpgsqlTypes.NpgsqlPoint(x: 0.4955138013124398d, y: 0.1914960133828043d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3194476155816517d, y: 0.08015579406086637d), new NpgsqlTypes.NpgsqlPoint(x: 0.659917425497092d, y: 0.2928026457603833d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379020646553559d, y: 0.5813878601951284d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005441159099007775d, y: 0.5936454114292384d), new NpgsqlTypes.NpgsqlPoint(x: 0.6815953163183109d, y: 0.19875944690031444d), new NpgsqlTypes.NpgsqlPoint(x: 0.037773949716895405d, y: 0.911663020407291d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006937687249108926d, y: 0.9333679270001838d), new NpgsqlTypes.NpgsqlPoint(x: 0.13120842346649142d, y: 0.16988292664929083d), new NpgsqlTypes.NpgsqlPoint(x: 0.8787648733479508d, y: 0.032537380150281625d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4346241521583005d, y: 0.6902188732361912d), new NpgsqlTypes.NpgsqlPoint(x: 0.354042769996351d, y: 0.8150158970762394d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572470727201721d, y: 0.2012431145477377d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7649596097618941d, y: 0.5977979174796327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8516050007548581d, y: 0.09406632966421224d), new NpgsqlTypes.NpgsqlPoint(x: 0.40183296118638656d, y: 0.5641845134937862d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15287012516059872d, y: 0.892068896903174d), new NpgsqlTypes.NpgsqlPoint(x: 0.8334162295044256d, y: 0.08185595469334683d), new NpgsqlTypes.NpgsqlPoint(x: 0.6070125599188942d, y: 0.6538247012485925d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24347998982931396d, y: 0.5370619118563499d), new NpgsqlTypes.NpgsqlPoint(x: 0.5964544466554365d, y: 0.7190862020575989d), new NpgsqlTypes.NpgsqlPoint(x: 0.725079762852871d, y: 0.06279928488541853d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01631052602397398d, y: 0.6554366871967932d), new NpgsqlTypes.NpgsqlPoint(x: 0.9768615143410114d, y: 0.08552449539437734d), new NpgsqlTypes.NpgsqlPoint(x: 0.42488463813245536d, y: 0.7874009287063616d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6167564997317757d, y: 0.23347472876998077d), new NpgsqlTypes.NpgsqlPoint(x: 0.1699666201733494d, y: 0.6114832014183564d), new NpgsqlTypes.NpgsqlPoint(x: 0.5041059701615634d, y: 0.701163988974403d)), }, },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08182722304248669d, y: 0.0808039115076784d), new NpgsqlTypes.NpgsqlPoint(x: 0.3666210999159327d, y: 0.8822754709422769d), new NpgsqlTypes.NpgsqlPoint(x: 0.8082287917424021d, y: 0.32553077928213403d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46249082017789034d, y: 0.4876624349792882d), new NpgsqlTypes.NpgsqlPoint(x: 0.7970470990236647d, y: 0.8503139041911888d), new NpgsqlTypes.NpgsqlPoint(x: 0.24848184968023568d, y: 0.7142210460582697d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10053140024415386d, y: 0.7782632087615878d), new NpgsqlTypes.NpgsqlPoint(x: 0.05146501933789771d, y: 0.5751869399684281d), new NpgsqlTypes.NpgsqlPoint(x: 0.5592031427267904d, y: 0.3563724261257547d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7502433880934165d, y: 0.5061419122162267d), new NpgsqlTypes.NpgsqlPoint(x: 0.0002680314770813208d, y: 0.1421706978766819d), new NpgsqlTypes.NpgsqlPoint(x: 0.2125883452313453d, y: 0.22155858845813903d)), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8611734523150918d, y: 0.5932723420973562d), new NpgsqlTypes.NpgsqlPoint(x: 0.30165245130829654d, y: 0.687742524956005d), new NpgsqlTypes.NpgsqlPoint(x: 0.0668500083080581d, y: 0.2740775867202164d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014688301247500979d, y: 0.894404374827931d), new NpgsqlTypes.NpgsqlPoint(x: 0.819454247465315d, y: 0.8423525103159344d), new NpgsqlTypes.NpgsqlPoint(x: 0.15358439599621376d, y: 0.2843365507391078d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.689490547936732d, y: 0.5164332988457431d), new NpgsqlTypes.NpgsqlPoint(x: 0.40418790234703106d, y: 0.9125532144189853d), new NpgsqlTypes.NpgsqlPoint(x: 0.7086534475821965d, y: 0.9579945656578184d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8559103900157076d, y: 0.5667077663427449d), new NpgsqlTypes.NpgsqlPoint(x: 0.5443596650040918d, y: 0.8156891294391249d), new NpgsqlTypes.NpgsqlPoint(x: 0.16456778623979607d, y: 0.09101428454475091d)), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9776980267617018d, y: 0.783887109559192d), new NpgsqlTypes.NpgsqlPoint(x: 0.7120369860071342d, y: 0.7039790485757517d), new NpgsqlTypes.NpgsqlPoint(x: 0.02793651681360687d, y: 0.5403958173323374d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002071794212802458d, y: 0.7687159310969233d), new NpgsqlTypes.NpgsqlPoint(x: 0.28056088296145587d, y: 0.515940024003132d), new NpgsqlTypes.NpgsqlPoint(x: 0.21831816483600308d, y: 0.23275147521410366d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5708273774475635d, y: 0.20763977432669867d), new NpgsqlTypes.NpgsqlPoint(x: 0.2379258251462404d, y: 0.1344627693241105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5245092866394508d, y: 0.6060466436056741d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3269525527209929d, y: 0.7061848934395112d), new NpgsqlTypes.NpgsqlPoint(x: 0.6554112180380091d, y: 0.8669140766429102d), new NpgsqlTypes.NpgsqlPoint(x: 0.883625942560517d, y: 0.7929595604330308d)), }, },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5120522160240741d, y: 0.5252019459903162d), new NpgsqlTypes.NpgsqlPoint(x: 0.38092192173600836d, y: 0.8635933680520305d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701269909177699d, y: 0.5063328244751183d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42847807212777156d, y: 0.9424822794457038d), new NpgsqlTypes.NpgsqlPoint(x: 0.6719987649818849d, y: 0.21504803872927614d), new NpgsqlTypes.NpgsqlPoint(x: 0.23305124684404055d, y: 0.16230085647793813d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17653791697700671d, y: 0.6292200159851317d), new NpgsqlTypes.NpgsqlPoint(x: 0.000960449340707048d, y: 0.34227028570645945d), new NpgsqlTypes.NpgsqlPoint(x: 0.34817612599993963d, y: 0.8807935226828442d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17740982324849708d, y: 0.8945951703643032d), new NpgsqlTypes.NpgsqlPoint(x: 0.8031161374027679d, y: 0.8167227644627384d), new NpgsqlTypes.NpgsqlPoint(x: 0.5995034096482735d, y: 0.4808142836547097d)), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08206949031663824d, y: 0.9766777495076674d), new NpgsqlTypes.NpgsqlPoint(x: 0.39602651166775626d, y: 0.6970810707240098d), new NpgsqlTypes.NpgsqlPoint(x: 0.4992034337936798d, y: 0.3702719541789553d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7767657745630561d, y: 0.24406395766120348d), new NpgsqlTypes.NpgsqlPoint(x: 0.34943924180464436d, y: 0.3447167520812294d), new NpgsqlTypes.NpgsqlPoint(x: 0.32227802933375527d, y: 0.44532849070659475d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.681870245356157d, y: 0.8759707335326574d), new NpgsqlTypes.NpgsqlPoint(x: 0.24256642711837983d, y: 0.40724680601915086d), new NpgsqlTypes.NpgsqlPoint(x: 0.5133404976994229d, y: 0.10053200260108786d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3952425574816678d, y: 0.916726710005086d), new NpgsqlTypes.NpgsqlPoint(x: 0.7893790305349064d, y: 0.5175213997376378d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477386143015673d, y: 0.5682792393780092d)), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
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

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36041887853424737d, y: 0.3430222537205634d), new NpgsqlTypes.NpgsqlPoint(x: 0.711225449116874d, y: 0.19768786933044347d), new NpgsqlTypes.NpgsqlPoint(x: 0.05800923005839553d, y: 0.6704545440323483d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9530955468170014d, y: 0.6535307886569027d), new NpgsqlTypes.NpgsqlPoint(x: 0.07305953531424358d, y: 0.046872318270678504d), new NpgsqlTypes.NpgsqlPoint(x: 0.10393018008995414d, y: 0.32572191104805115d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38372096998441496d, y: 0.30282796789304445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9810866297015236d, y: 0.30611096192981313d), new NpgsqlTypes.NpgsqlPoint(x: 0.1135641559647873d, y: 0.5114683631094646d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21313872766334485d, y: 0.7174400387793036d), new NpgsqlTypes.NpgsqlPoint(x: 0.48969236755075163d, y: 0.5501470236580093d), new NpgsqlTypes.NpgsqlPoint(x: 0.08537696214344326d, y: 0.6847319672111247d)), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02777869106668962d, y: 0.6190131184380548d), new NpgsqlTypes.NpgsqlPoint(x: 0.3987138364703945d, y: 0.15654997420057903d), new NpgsqlTypes.NpgsqlPoint(x: 0.5070610939117584d, y: 0.28845056457283846d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41542263219514464d, y: 0.09342537220791036d), new NpgsqlTypes.NpgsqlPoint(x: 0.33289773185537186d, y: 0.5856956450039189d), new NpgsqlTypes.NpgsqlPoint(x: 0.5410908420414338d, y: 0.45400963865633437d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3126228233158045d, y: 0.47760008248149866d), new NpgsqlTypes.NpgsqlPoint(x: 0.08435925629592989d, y: 0.20042929604102278d), new NpgsqlTypes.NpgsqlPoint(x: 0.859682182412861d, y: 0.46933719723306344d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30053237958915924d, y: 0.430722869700885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5394233619202163d, y: 0.5303307613679747d), new NpgsqlTypes.NpgsqlPoint(x: 0.5757200867006617d, y: 0.17625888996228145d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.75796076354275d, y: 0.00891979339030724d), new NpgsqlTypes.NpgsqlPoint(x: 0.21639833978457867d, y: 0.2730967322877913d), new NpgsqlTypes.NpgsqlPoint(x: 0.2909190009901561d, y: 0.241158335448879d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8876368159279283d, y: 0.9811201076556229d), new NpgsqlTypes.NpgsqlPoint(x: 0.6480475433332339d, y: 0.031828460948671755d), new NpgsqlTypes.NpgsqlPoint(x: 0.9534355256265885d, y: 0.6961105930601198d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4435090516736975d, y: 0.11898009546139554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111937417623247d, y: 0.5517262042122395d), new NpgsqlTypes.NpgsqlPoint(x: 0.9227235907400706d, y: 0.21047268834465704d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5328555953819768d, y: 0.04866272845036268d), new NpgsqlTypes.NpgsqlPoint(x: 0.9894485410537492d, y: 0.2249621280724895d), new NpgsqlTypes.NpgsqlPoint(x: 0.8024388008522757d, y: 0.5475417611947755d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4190429071889826d, y: 0.4776580308273827d), new NpgsqlTypes.NpgsqlPoint(x: 0.6337654099383544d, y: 0.9854370793085339d), new NpgsqlTypes.NpgsqlPoint(x: 0.9198456218981076d, y: 0.9957908885684591d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43006500341373544d, y: 0.021889438966291253d), new NpgsqlTypes.NpgsqlPoint(x: 0.36067652683110574d, y: 0.8168559210248331d), new NpgsqlTypes.NpgsqlPoint(x: 0.3510277273509145d, y: 0.8416932471018133d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2229649098181633d, y: 0.3936859290943674d), new NpgsqlTypes.NpgsqlPoint(x: 0.1687201881885909d, y: 0.747356359553931d), new NpgsqlTypes.NpgsqlPoint(x: 0.32889892438863d, y: 0.8490669192822415d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32705597933928654d, y: 0.8873237828609747d), new NpgsqlTypes.NpgsqlPoint(x: 0.4868767023362446d, y: 0.35401953587411183d), new NpgsqlTypes.NpgsqlPoint(x: 0.5297458338397254d, y: 0.781211168205684d)), }, }));
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08972075600943352d, y: 0.9656284836502488d), new NpgsqlTypes.NpgsqlPoint(x: 0.43065155277870903d, y: 0.7301842122679338d), new NpgsqlTypes.NpgsqlPoint(x: 0.21656564675756151d, y: 0.665089920787759d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8050478124611008d, y: 0.26636636211197096d), new NpgsqlTypes.NpgsqlPoint(x: 0.6508890385478868d, y: 0.9506809910408982d), new NpgsqlTypes.NpgsqlPoint(x: 0.39943562540766d, y: 0.4959102423783667d)), }, { new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46005096983685634d, y: 0.43621541345529524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5507286358064648d, y: 0.6286113140929211d), new NpgsqlTypes.NpgsqlPoint(x: 0.4714177459071177d, y: 0.9259092626023325d)), new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41124041148768953d, y: 0.6464058243510021d), new NpgsqlTypes.NpgsqlPoint(x: 0.13112050296640287d, y: 0.3656623131468555d), new NpgsqlTypes.NpgsqlPoint(x: 0.07402349615479764d, y: 0.8643009150506272d)), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 49, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 129, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 30, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 120, query1, 129, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 17, query1, 105, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 22, query1, 15, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 61, query1, 126, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 45, 17))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 17, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
FROM public.binary_npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI), typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

