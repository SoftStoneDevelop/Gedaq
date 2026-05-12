

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
    internal partial interface INpgsqlPointListpointListD1
    {
    }
    
    internal partial class NpgsqlPointListpointListD1 : INpgsqlPointListpointListD1
    {


#region TestData

        private readonly NpgsqlPointpointListD1E2M[] _testData = new NpgsqlPointpointListD1E2M[]
        {
            new NpgsqlPointpointListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8835661987233576d, y: 0.8602643902903734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7486831695839732d, y: 0.4483186906620048d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07899851245456835d, y: 0.8197301185326394d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2401754835297123d, y: 0.5671190100486226d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4201519152281338d, y: 0.07915237034793565d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40912932242063593d, y: 0.013494424378442615d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9984681670112766d, y: 0.9107466478297785d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.78061578694304d, y: 0.9738309689133196d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7595349642239793d, y: 0.09767036659621808d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03940934422306708d, y: 0.8151249207866417d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21054711638596102d, y: 0.6486339789013378d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6774562763703931d, y: 0.32169498405684027d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8494863238586102d, y: 0.6799092614491902d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6984234071904765d, y: 0.7118410352185761d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7993064629534228d, y: 0.07205351687101891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42603852818051946d, y: 0.8940930935339472d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19224491676227362d, y: 0.4216152655252816d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1449240535164411d, y: 0.7462706800970338d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26554654659448673d, y: 0.4777253930342371d),

new NpgsqlTypes.NpgsqlPoint(x: 0.859309823182885d, y: 0.5065172807574025d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5066865922211949d, y: 0.2603681061894687d),

new NpgsqlTypes.NpgsqlPoint(x: 0.77368915497791d, y: 0.12331059245347487d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9174968347255116d, y: 0.413033541091427d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6656355798643594d, y: 0.7696439414897719d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9568759352471329d, y: 0.39941028814794644d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4711901266967362d, y: 0.10980823644606152d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7267571390972549d, y: 0.2761316110808616d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.662643941869225d, y: 0.006929355626389744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7464388094791131d, y: 0.2687884887735221d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6460612288693723d, y: 0.717611220572084d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19082150561829592d, y: 0.9401571260241804d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6851535636788011d, y: 0.030675214389354277d),

new NpgsqlTypes.NpgsqlPoint(x: 0.963961751046759d, y: 0.26931669408043724d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6565971854645003d, y: 0.2228708904700819d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8152131188407078d, y: 0.910366807962099d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40224383028517796d, y: 0.10726921737647843d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08577223785351218d, y: 0.6544224594195752d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7939003806482975d, y: 0.14566643439694293d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4900002755631925d, y: 0.8682608407987489d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12859408988028098d, y: 0.5789349122034845d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3482107990127735d, y: 0.7727451766064829d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45350863624652915d, y: 0.8722090287975774d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5249133582886849d, y: 0.1275461090532014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7816754084562862d, y: 0.09814315279834152d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7110034900969687d, y: 0.4504645472621075d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13386607039627296d, y: 0.7331776681598715d),

new NpgsqlTypes.NpgsqlPoint(x: 0.86925575932193d, y: 0.376440696913554d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7297487670635502d, y: 0.6616406403575856d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.35298642691851256d, y: 0.25594885063587747d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32060480050249207d, y: 0.12214416941554662d),

new NpgsqlTypes.NpgsqlPoint(x: 0.434643510684283d, y: 0.6224618413762368d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16308718350091855d, y: 0.9844698426792531d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.368264228082379d, y: 0.3815924915161193d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2729910324051764d, y: 0.087038381594162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6780522176211264d, y: 0.38096355494221057d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.698188248622928d, y: 0.26847426553208276d),

new NpgsqlTypes.NpgsqlPoint(x: 0.035928289883588094d, y: 0.10026015492814389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9621332659853675d, y: 0.167737676035297d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8613986487522695d, y: 0.10137116963808612d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04813453766348885d, y: 0.3911672921223842d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2978070215367601d, y: 0.0733034879803276d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47020223612190915d, y: 0.8108507483222405d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7001095867053931d, y: 0.536689215014208d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22496983671073179d, y: 0.6141064098636584d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25867873157381027d, y: 0.03907897581241082d),

new NpgsqlTypes.NpgsqlPoint(x: 0.563210952964427d, y: 0.6713454310015566d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8685151843338603d, y: 0.03811403745592423d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6081174046593373d, y: 0.4180071483376452d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35140174548742176d, y: 0.9233716840053454d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6827345148892763d, y: 0.826687924652405d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.017832425652204886d, y: 0.9100855945893768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3178793151571665d, y: 0.06226995790540979d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47390722295348753d, y: 0.8400060173958873d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7342996917491313d, y: 0.8604174975230595d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5287016569480039d, y: 0.16468298776373347d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29080441159397385d, y: 0.3904710922499637d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45740358890791843d, y: 0.6553714441026254d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3303731487061383d, y: 0.490225369686458d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8921327459952544d, y: 0.18333402383883757d),

new NpgsqlTypes.NpgsqlPoint(x: 0.472065751735385d, y: 0.6640680874582282d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7554021561204718d, y: 0.09294292066697951d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5804674435963656d, y: 0.6303796413241279d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7448172964624978d, y: 0.9144533135289088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6720129072919181d, y: 0.6492857328932563d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3127598140244511d, y: 0.21344066120060967d),

new NpgsqlTypes.NpgsqlPoint(x: 0.057762434523226935d, y: 0.270484689406148d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7714359277905595d, y: 0.2152736196580215d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09463129756921085d, y: 0.8028251103611671d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9531140006106236d, y: 0.06989898009025142d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20402907660053704d, y: 0.5556804023486613d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47125098931505216d, y: 0.10715347552356957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9109331623140823d, y: 0.3885438985191242d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3121928633739782d, y: 0.9533060450287076d),

new NpgsqlTypes.NpgsqlPoint(x: 0.59253361161599d, y: 0.8197829737959861d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28672818540518163d, y: 0.912800223304585d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5660147848023628d, y: 0.874629135427332d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0008128036679013739d, y: 0.1680295963184758d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8140275683257153d, y: 0.12856267894719942d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4263953459997153d, y: 0.7895127307012654d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7873362231328732d, y: 0.5885453505659128d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4992785379752852d, y: 0.1346279450534904d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05155791689220357d, y: 0.3986246443907818d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22409813713861693d, y: 0.6562839009143303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3135202895747766d, y: 0.20114773002305808d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7155216582603503d, y: 0.09688704567582673d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11751677093344115d, y: 0.5127206472730701d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23600501326212775d, y: 0.5615913905168929d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8860765778413391d, y: 0.05352757901562111d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25287035400339897d, y: 0.5475111352570363d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08814109879613607d, y: 0.34561213175245187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7501810385215024d, y: 0.6633877915154894d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9486259174982425d, y: 0.6688407965263525d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28201450277303464d, y: 0.5825306318213065d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6642381369770514d, y: 0.5612983859493941d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.400716176085524d, y: 0.007577732164542272d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9032216396186096d, y: 0.7839306757661096d),

new NpgsqlTypes.NpgsqlPoint(x: 0.774850511407293d, y: 0.4922123609118d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8284774068660729d, y: 0.35438753377027676d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4354366688901953d, y: 0.667926505422197d),

new NpgsqlTypes.NpgsqlPoint(x: 0.938357359875994d, y: 0.5770478364540028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.737526393381711d, y: 0.12161365049848083d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9738675675481505d, y: 0.45100784953037876d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5676190108301422d, y: 0.8375104097463022d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6313442738552606d, y: 0.9808596810347451d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.781198706337107d, y: 0.5558388947889895d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9432995407325249d, y: 0.07454378416769558d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24413528776228888d, y: 0.5114830741698746d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7017348355872919d, y: 0.06745879475299743d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6179789947682434d, y: 0.8135168283102745d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07870564185292472d, y: 0.01097094616680827d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06154012774302209d, y: 0.4911410973041759d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5236907174872987d, y: 0.26862091385409714d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7170454176918137d, y: 0.7909235162547783d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3337167830775021d, y: 0.220082325352159d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15111245365583859d, y: 0.9401613740948577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8671526876799602d, y: 0.9351583495733107d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4185657594392148d, y: 0.16918889161553186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39037788989858213d, y: 0.3121572313212624d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7001941286708525d, y: 0.7011127368654775d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5064023840762165d, y: 0.8544646223062726d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11874108263098138d, y: 0.20716757832619725d),

new NpgsqlTypes.NpgsqlPoint(x: 0.829010398277403d, y: 0.7205218477726509d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8764336676926793d, y: 0.4872595579761587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7235829194997249d, y: 0.13422939792894217d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14824518692824584d, y: 0.6503819617645291d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7202670846493219d, y: 0.43856484760895964d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3138487103313917d, y: 0.24075462084918475d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5301723502384514d, y: 0.7190552678614015d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11211830484995611d, y: 0.22697133505006273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16963798559404974d, y: 0.07079632626085575d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4069315346400725d, y: 0.9545771534467749d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8840671675814166d, y: 0.6714786214608781d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43581091578497855d, y: 0.6804420760793025d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2606052729452658d, y: 0.9001842062974102d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03448570885502655d, y: 0.18495413143698813d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6675715375273802d, y: 0.7469960953254281d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36146933680403937d, y: 0.8796147819971345d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7708529874801698d, y: 0.9336758126040413d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7487033625248151d, y: 0.23164314750839443d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05732511555257025d, y: 0.9152497696016615d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4909275999546654d, y: 0.43243374842886273d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9055413984899044d, y: 0.4136168250744522d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08381688296734624d, y: 0.9018886106459864d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3771216290790763d, y: 0.2729666465162388d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6822439841682026d, y: 0.4377440983132611d),

new NpgsqlTypes.NpgsqlPoint(x: 0.808379689326315d, y: 0.2343660132054094d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7793104059661813d, y: 0.8138603620519169d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5858296084154349d, y: 0.4949480844879931d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3147772202943775d, y: 0.777609247381966d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7647412057628477d, y: 0.4201281030690589d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7144816743044434d, y: 0.27641030055435856d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1547675998777588d, y: 0.3978952789771385d),

new NpgsqlTypes.NpgsqlPoint(x: 0.836290920880376d, y: 0.06713611362045313d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05925397963106227d, y: 0.4027579782169053d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8690429063420554d, y: 0.1591649007336633d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02700861325785675d, y: 0.6704082540135816d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3799991266277206d, y: 0.876785133200187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9314217500820527d, y: 0.060786784382821146d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2719245140060147d, y: 0.7092575330621801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4334091989781069d, y: 0.37386046490796865d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3848777920285702d, y: 0.9768390289909508d),

new NpgsqlTypes.NpgsqlPoint(x: 0.44334535749516635d, y: 0.640187662910706d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5687239728628083d, y: 0.5085957923876282d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3420680499709826d, y: 0.43454748055798487d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7952790235404728d, y: 0.46314407931444257d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10260510387581956d, y: 0.5560750016628623d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1076538660710662d, y: 0.5747118742000634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.056395816167930546d, y: 0.30982620310904996d),

new NpgsqlTypes.NpgsqlPoint(x: 0.017257398300203675d, y: 0.6404956845490125d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.051646758880072974d, y: 0.5779925969832473d),

new NpgsqlTypes.NpgsqlPoint(x: 0.452944639197693d, y: 0.21181231059417083d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4985868695665787d, y: 0.2418886871779754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38095188602409524d, y: 0.9499534227976285d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.36311547585983117d, y: 0.262890897895975d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3565668117867955d, y: 0.5550536348998754d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5703964326343702d, y: 0.22489248270757245d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42291588695040905d, y: 0.11407970227829467d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14719638118370604d, y: 0.6155626595023095d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9975217237798194d, y: 0.037690815611302164d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9430795124050023d, y: 0.07991790642751317d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9214519120184614d, y: 0.5032834340015185d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9483457496393188d, y: 0.5646070814224291d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8215218052659773d, y: 0.17154947826542744d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7263413428883866d, y: 0.18629683566552335d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2139953821491778d, y: 0.5279199114573484d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9657741064871165d, y: 0.1991607650694629d),

new NpgsqlTypes.NpgsqlPoint(x: 0.765313937092728d, y: 0.11441454121997341d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6988571841518416d, y: 0.4427650628208374d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41166365628180457d, y: 0.4406075817547307d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47769940702315616d, y: 0.335363365415691d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7222647655587888d, y: 0.09173278402533658d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1299860809914576d, y: 0.30159802223144705d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26253301997818024d, y: 0.37373649951092036d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5622274250809254d, y: 0.6070071740938671d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22506493768849878d, y: 0.254010933798157d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2033562972706221d, y: 0.8058271384505088d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5026176557164458d, y: 0.3669638375701765d),

new NpgsqlTypes.NpgsqlPoint(x: 0.810209484333059d, y: 0.44431887370228196d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4783497981232063d, y: 0.9245309356939018d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31380565482288625d, y: 0.7117837172096414d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37352808214338107d, y: 0.41600496480422455d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3442202242603756d, y: 0.1969412493118976d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30577259212006846d, y: 0.9779666556371878d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47522002844055866d, y: 0.3994325464587395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9077910995880406d, y: 0.738307600509343d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9719319445648169d, y: 0.6209767130343146d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5455738088550048d, y: 0.17202338774636672d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11426272885909328d, y: 0.9648709056737867d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.21904134409162912d, y: 0.739713821856189d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2160637495166403d, y: 0.17209772849539362d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18377964593503582d, y: 0.9885618474370721d),

new NpgsqlTypes.NpgsqlPoint(x: 0.037051653562352405d, y: 0.849165412667759d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7995914977749543d, y: 0.06995794370550801d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19179503272452558d, y: 0.8622390338973223d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4689011461033411d, y: 0.012807690018480034d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6773544269084358d, y: 0.7306652516907463d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8165349912799997d, y: 0.5000194477033794d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9899853079985355d, y: 0.1749243326542056d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2522090866462008d, y: 0.05199050501951685d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7156179212537429d, y: 0.367399796059651d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4048962773537851d, y: 0.5857379258368466d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18417804370892177d, y: 0.19381490110147026d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5452263772836177d, y: 0.13615953641262002d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7197928319748871d, y: 0.2042010877068442d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6728483685916155d, y: 0.7456632960387745d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4486247372378398d, y: 0.4821010597221367d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9331019160593466d, y: 0.6301518558445947d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4798998310121394d, y: 0.41364928632449427d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9941103342315425d, y: 0.29559283651108514d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 8.022357674075664E-05d, y: 0.7805445657530841d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4979704570869119d, y: 0.09117112945075256d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10558025374708901d, y: 0.4270438523495005d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5678358033678088d, y: 0.1648504728286263d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9590574030475146d, y: 0.25369471204026683d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38596787193233195d, y: 0.6030067303483237d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6503564883707205d, y: 0.2682259882315301d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7022756369044805d, y: 0.6694260034286628d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5171981240201033d, y: 0.37095432676430107d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.360198084033164d, y: 0.7308111558982316d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26474303888842343d, y: 0.7255404889464979d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7996015668958646d, y: 0.030806081602549273d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1657430838722851d, y: 0.4891448243289226d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7386635241981155d, y: 0.29272951516375423d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13692593377847684d, y: 0.7767590162508539d),

},
    ModelInner = new NpgsqlPointpointListD1E2MI
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6091096568203859d, y: 0.91693671544377d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14704741401268606d, y: 0.6520445308412448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6727717143222952d, y: 0.031875024529036344d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7072398992432827d, y: 0.06277685035039737d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3639681612533122d, y: 0.15869275256629745d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3324345135696878d, y: 0.18850962412939865d),

},
},
            new NpgsqlPointpointListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6166595566877232d, y: 0.22194781270413488d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20929730141635927d, y: 0.5565857307496901d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5248483472567588d, y: 0.3958873820646116d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38631132713390814d, y: 0.022731377918442597d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
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

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointlistd1e2mi_id
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
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointlistd1e2mi_id", 
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
                List<NpgsqlPointpointListD1E2M> models = null;

                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointListD1E2M> models = null;

                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await ((INpgsqlPointListpointListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M), typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 51, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 134, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var models2 = new List<FlatNpgsqlPointpointListD1E2M>();
                ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 16, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 59, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 119, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                await ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 29, query1, 140, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 36, query1, 127, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
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
FROM public.npgsqlpointpointlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointListD1E2M>();
                 ((INpgsqlPointListpointListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 147, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpointpointlistd1e2m m
LEFT JOIN public.npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
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
                var models = await((INpgsqlPointListpointListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 115))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlPointListpointListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointListD1)this).DbConnectionSTSelectModelBatch(connection, 42, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 42);
                var models = await ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[7], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[8], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[9], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[10], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[11], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[12], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[13], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[14], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[15], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[9],_testData[16], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[10],_testData[17], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[11],_testData[18], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[12],_testData[19], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[13],_testData[20], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[14],_testData[21], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[15],_testData[22], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[16],_testData[23], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[17],_testData[24], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[18],_testData[25], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[19],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[20],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[21],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[22],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[23],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[24],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[25],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[26],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointListD1)this).SetDbConnectionSelectModelParametrs(cmd, 127);
                var models =  ((INpgsqlPointListpointListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                NpgsqlPointpointListD1E2M.AssertModel(models[0],_testData[26], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[1],_testData[27], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[2],_testData[28], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[3],_testData[29], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[4],_testData[30], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[5],_testData[31], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[6],_testData[32], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[7],_testData[33], false);
                NpgsqlPointpointListD1E2M.AssertModel(models[8],_testData[34], false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
FROM public.binary_npgsqlpointpointlistd1e2m m
LEFT JOIN public.binary_npgsqlpointpointlistd1e2mi mi ON mi.id = m.npgsqlpointpointlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models =  ((INpgsqlPointListpointListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointlistd1e2mi
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
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI), typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointListD1E2MI>();
                var models2 = new List<NpgsqlPointpointListD1E2MI>();
                await ((INpgsqlPointListpointListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MI>();
                var models2 = new List<NpgsqlPointpointListD1E2MI>();
                ((INpgsqlPointListpointListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointListpointListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA), typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                await ((INpgsqlPointListpointListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointListD1E2MIWA>();
                var models2 = new List<NpgsqlPointpointListD1E2MIWA>();
                ((INpgsqlPointListpointListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointListD1))]
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
                var models = await ((INpgsqlPointListpointListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

